using libraries;
using model.Entities;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Configuration;

namespace model.Data
{
    public class PersonalBD
    {
        /// <summary>
        /// Valida las credenciales de acceso de un usuario en la base de datos.
        /// </summary>
        /// <param name="credencialesAcceso">Objeto de tipo CredencialesAcceso que contiene la información de las credenciales de acceso del usuario.</param>
        /// <returns>Un valor booleano que indica si las credenciales de acceso son válidas o no.</returns>
        public async Task<bool> ValidarCredenciales(CredencialesAcceso credencialesAcceso)
        {
            bool isValidUser = false;
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    var cmd = new SqlCommand("ValidarCredenciales", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", credencialesAcceso.Id_usuario);
                    cmd.Parameters.AddWithValue("@password", credencialesAcceso.Password);
                    SqlParameter esValidoParam = new SqlParameter("@EsValido", SqlDbType.Bit);
                    esValidoParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(esValidoParam);
                    SqlParameter nombreParam = new SqlParameter("@NombreCompleto", SqlDbType.NVarChar, 200);
                    nombreParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(nombreParam);
                    SqlParameter idRolParam = new SqlParameter("@IdRol", SqlDbType.Int);
                    idRolParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(idRolParam);
                    SqlParameter idParam = new SqlParameter("@IdUser", SqlDbType.NVarChar, 50);
                    idParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(idParam);

                    await cmd.ExecuteNonQueryAsync(); // Ejecuta el comando de forma asíncrona

                    isValidUser = (bool)esValidoParam.Value; // Obtiene el valor del parámetro de salida "EsValido" y lo asigna a la variable isValidUser
                    if (isValidUser)
                    {
                        // Asigna los valores de los parámetros de salida a variables globales
                        GlobalVariables.id_usuario_login = credencialesAcceso.Id_usuario;
                        GlobalVariables.id_rol = (int)idRolParam.Value;
                        GlobalVariables.usuario = (string)nombreParam.Value;
                        GlobalVariables.id_usuario_validator = (string)idParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync(); // Cierra la conexión a la base de datos
            }

            return isValidUser; // Retorna el valor booleano que indica si las credenciales de acceso son válidas o no
        }

        /// <summary>
        /// Envía un correo electrónico con un código OTP a la dirección de correo electrónico asociada a un ID.
        /// </summary>
        /// <param name="id">ID del usuario para el cual se enviará el correo electrónico.</param>
        /// <returns>Valor booleano que indica si el correo electrónico se ha enviado correctamente.</returns>
        public async Task<bool> SendEmail(string id)
        {
            bool sended = false;
            string OTP = OTPKey.GenerateOTP(Alquimia.Encrypt(id)); // Genera un código OTP a partir del ID encriptado
            string to = await GetEmail(id); // Obtiene la dirección de correo electrónico asociada al ID
            string subject = "Recuperar Contraseña";
            string body = "Su clave OTP es: \n"+OTP+"\nNo compartas esta clave con nadie.";
            try
            {
                // Obtiene la dirección de correo electrónico y la contraseña del cliente de correo electrónico de la configuración
                string direccionCorreo = DecryptEmailClient(ConfigurationManager.AppSettings["DireccionCorreo"]);
                string contraseñaCorreo = DecryptEmailClient(ConfigurationManager.AppSettings["ContraseñaCorreo"]);

                // Crea un objeto MailMessage para el correo electrónico
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(direccionCorreo);
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;

                // Configura el cliente de SMTP para el envío del correo electrónico
                SmtpClient client = new SmtpClient("smtp.office365.com",587);
                client.Credentials = new NetworkCredential(direccionCorreo, contraseñaCorreo);
                client.EnableSsl = true;
                client.Send(mail); // Envía el correo electrónico
                sended = true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);  // Lanza una excepción con el mensaje de error si ocurre alguna excepción durante el envío del correo electrónico
            }

            return sended;
        }

        /// <summary>
        /// Obtiene la dirección de correo electrónico asociada a un ID de usuario.
        /// </summary>
        /// <param name="id">ID del usuario para el cual se obtendrá la dirección de correo electrónico.</param>
        /// <returns>La dirección de correo electrónico del usuario.</returns>
        internal async Task<string> GetEmail(string id)
        {
            string email = "";
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    var cmd = new SqlCommand("ObtenerCorreo", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cedula", id);
                    SqlDataReader reader = await cmd.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                    {
                        email = reader.GetString(0);
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            return email;
        }

        /// <summary>
        /// Desencripta las credenciales del correo cliente que estan en base64 utilizando el algoritmo de cifrado AES.
        /// </summary>
        /// <param name="input">Credenciales del correo cliente en base64 a desencriptar.</param>
        /// <returns>Las credenciales desencriptadas.</returns>
        internal static string DecryptEmailClient(string input)
        {
            try
            {
                input = input.Replace(" ", "+");
                byte[] cipherBytes = Convert.FromBase64String(input);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(GlobalVariables.encryptionKey.Trim(), new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        input = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is IOException)
                {
                    throw new Exception("Archivo no encontrado o inaccesible!");
                }
                if (ex is FormatException)
                {
                    throw new Exception("Formato de cifrado incorrecto!");
                }
                throw;
            }
            return input;
        }

        /// <summary>
        /// Registra información de personal en la base de datos utilizando un procedimiento almacenado.
        /// </summary>
        /// <param name="personal">Objeto del tipo Personal que contiene los datos del personal a registrar.</param>
        /// <returns>True si el registro es exitoso, False si no lo es.</returns>
        public async Task<bool> RegistrarPersonal(Personal personal)
        {
            bool registroExitoso = false;
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    // Crear un nuevo comando SQL con el nombre del procedimiento almacenado y la conexión de base de datos
                    var cmd = new SqlCommand("RegistrarPersonal", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros al comando con los valores del objeto Personal
                    cmd.Parameters.AddWithValue("@id_cedula", personal.Id_personal);
                    cmd.Parameters.AddWithValue("@nombre_personal", personal.Nombre_personal);
                    cmd.Parameters.AddWithValue("@apellido_personal", personal.Apellido_personal);
                    cmd.Parameters.AddWithValue("@cargo_personal", personal.Cargo);
                    cmd.Parameters.AddWithValue("@fecha_nacimiento", personal.Fecha_nacimiento);
                    cmd.Parameters.AddWithValue("@sexo", personal.Sexo);
                    cmd.Parameters.AddWithValue("@telefono_personal", personal.Telefono);
                    cmd.Parameters.AddWithValue("@correo_personal", personal.Correo);
                    cmd.Parameters.AddWithValue("@direccion_personal", personal.Direccion);
                    cmd.Parameters.AddWithValue("@fecha_ingreso", personal.Fecha_ingreso);
                    cmd.Parameters.AddWithValue("@salario_mensual", personal.Salario);
                    cmd.Parameters.AddWithValue("@personal_activo", personal.Personal_activo);
                    cmd.Parameters.AddWithValue("@usuario_asignado", personal.Usuario_asignado);

                    // Agregar un parámetro de salida para capturar el resultado del registro exitoso
                    SqlParameter registroExitosoParam = new SqlParameter("@RegistroExitoso", SqlDbType.Bit);
                    registroExitosoParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(registroExitosoParam);

                    // Ejecutar el comando en la base de datos de forma asíncrona
                    await cmd.ExecuteNonQueryAsync();

                    // Obtener el valor del parámetro de salida que indica si el registro fue exitoso
                    registroExitoso = (bool)registroExitosoParam.Value;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            return registroExitoso;
        }

        /// <summary>
        /// Obtiene la información de personal que no tiene un usuario asociado en la base de datos.
        /// </summary>
        /// <returns>Un objeto DataTable que contiene la información de personal sin usuario.</returns>
        public async Task<DataTable> ObtenerPersonalSinUsuario()
        {
            DataTable personalDT = new DataTable();
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    // Crear un nuevo comando SQL con el nombre del procedimiento almacenado y la conexión de base de datos
                    var cmd = new SqlCommand("ObtenerPersonalSinUsuario", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Crear un SqlDataAdapter para obtener los datos del comando en el DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(personalDT);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            return personalDT;
        }

        /// <summary>
        /// Obtiene la lista de roles de usuarios desde la base de datos.
        /// </summary>
        /// <returns>Una lista de objetos RolUsuario que representan los roles de usuarios.</returns>
        public async Task<List<RolUsuario>> ObtenerRoles()
        {
            List<RolUsuario> roles = new List<RolUsuario>();
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    // Crear un nuevo comando SQL con el nombre del procedimiento almacenado y la conexión de base de datos
                    var cmd = new SqlCommand("ObtenerRoles", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdRol", GlobalVariables.id_rol);

                    // Insertar un elemento inicial en la lista de roles
                    roles.Insert(0, new RolUsuario(-1, "Elegir cargo..."));

                    // Utilizar un SqlDataReader para obtener los datos del comando y agregarlos a la lista de roles
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            roles.Add(new RolUsuario(id, nombre));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            return roles;
        }

        /// <summary>
        /// Registra un nuevo usuario en la base de datos.
        /// </summary>
        /// <param name="personal">El objeto Personal que contiene la información personal del usuario.</param>
        /// <param name="usuario">El objeto Usuario que contiene la información adicional del usuario.</param>
        /// <param name="credenciales">El objeto CredencialesAcceso que contiene las credenciales de acceso del usuario.</param>
        /// <returns>Un valor booleano que indica si el registro fue exitoso o no.</returns>
        public async Task<bool> RegistrarUsuario(Personal personal, Usuario usuario, CredencialesAcceso credenciales)
        {
            bool registroExitoso = false;
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    // Crear un nuevo comando SQL con el nombre del procedimiento almacenado y la conexión de base de datos
                    var cmd = new SqlCommand("RegistrarUsuario", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros necesarios para el procedimiento almacenado
                    cmd.Parameters.AddWithValue("@id_usuario", usuario.Id);
                    cmd.Parameters.AddWithValue("@nombre_rol", personal.Cargo);
                    cmd.Parameters.AddWithValue("@nombre_usuario", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@apellido_usuario", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@imagen_usuario", usuario.Imagen);
                    cmd.Parameters.AddWithValue("@usuario", credenciales.Usuario);
                    cmd.Parameters.AddWithValue("@password", credenciales.Password);
                    cmd.Parameters.AddWithValue("@usuario_activo", credenciales.Usuario_activo);

                    // Agregar un parámetro de salida para capturar el resultado de registro exitoso
                    SqlParameter registroExitosoParam = new SqlParameter("@RegistroExitoso", SqlDbType.Bit);
                    registroExitosoParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(registroExitosoParam);

                    // Ejecutar el comando SQL
                    await cmd.ExecuteNonQueryAsync();

                    // Obtener el resultado de registro exitoso del parámetro de salida
                    registroExitoso = (bool)registroExitosoParam.Value;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            return registroExitoso;
        }

        /// <summary>
        /// Obtiene los usuarios registrados en la base de datos.
        /// </summary>
        /// <returns>Un objeto DataTable que contiene los datos de los usuarios.</returns>
        public async Task<DataTable> ObtenerUsuarios()
        {
            DataTable usuariosDT = new DataTable();
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    // Crear un nuevo comando SQL con el nombre del procedimiento almacenado y la conexión de base de datos
                    var cmd = new SqlCommand("ObtenerUsuarios", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Crear un adaptador de datos SQL para ejecutar el comando y llenar el DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(usuariosDT);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            return usuariosDT;
        }

        /// <summary>
        /// Obtiene los datos combinados de un usuario específico en la base de datos.
        /// </summary>
        /// <param name="id">El identificador de cédula del usuario.</param>
        /// <returns>Un diccionario que contiene los datos combinados del usuario.</returns>
        public async Task<Dictionary<string, object>> ObtenerDatosUsuarios(string id)
        {
            Dictionary<string, object> DatosCombinados = new Dictionary<string, object>();
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    Personal personal = new Personal();
                    Usuario usuario = new Usuario();
                    CredencialesAcceso credenciales = new CredencialesAcceso();

                    // Crear un nuevo comando SQL con el nombre del procedimiento almacenado y la conexión de base de datos
                    var cmd = new SqlCommand("ObtenerDatosUsuarios", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cedula", id);
                    SqlDataReader reader = await cmd.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                    {
                        // Leer los datos del usuario desde el SqlDataReader y asignarlos a los objetos correspondientes
                        personal.Id_personal = id;
                        personal.Nombre_personal = reader.GetString(0);
                        personal.Apellido_personal = reader.GetString(1);
                        personal.Cargo = reader.GetString(2);
                        personal.Fecha_nacimiento = reader.GetDateTime(3);
                        personal.Sexo = reader.GetString(4);
                        personal.Telefono = reader.GetString(5);
                        personal.Correo = reader.GetString(6);
                        personal.Direccion = reader.GetString(7);
                        personal.Fecha_ingreso = reader.GetDateTime(8);
                        if (!reader.IsDBNull(9))
                        {
                            usuario.Imagen = (byte[])reader.GetValue(9);
                        }
                        else
                        {
                            usuario.Imagen = null;
                        }
                        credenciales.Usuario = reader.GetString(10);

                        // Combinar los objetos personal, usuario y credenciales en un diccionario
                        DatosCombinados = Alquimia.CombineObjects(personal, usuario, credenciales);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            return DatosCombinados;
        }

        /// <summary>
        /// Registra un gerente en la base de datos.
        /// </summary>
        /// <param name="DatosGerente">Diccionario que contiene los datos del gerente a registrar.</param>
        /// <returns>Valor booleano que indica si el registro del gerente fue exitoso.</returns>
        public async Task<bool>RegistrarGerente(Dictionary<string,object> DatosGerente)
        {
            bool registrado=false;
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    var cmd = new SqlCommand("RegistrarGerente", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado
                    cmd.Parameters.AddWithValue("@id_cedula", (string)DatosGerente["Id_personal"]);
                    cmd.Parameters.AddWithValue("@nombre_gerente", (string)DatosGerente["Nombre_personal"]);
                    cmd.Parameters.AddWithValue("@apellido_gerente", (string)DatosGerente["Apellido_personal"]);
                    cmd.Parameters.AddWithValue("@fecha_nacimiento", (DateTime)DatosGerente["Fecha_nacimiento"]);
                    cmd.Parameters.AddWithValue("@sexo_gerente", (string)DatosGerente["Sexo"]);
                    cmd.Parameters.AddWithValue("@telefono_gerente", (string)DatosGerente["Telefono"]);
                    cmd.Parameters.AddWithValue("@correo_gerente", (string)DatosGerente["Correo"]);
                    cmd.Parameters.AddWithValue("@direccion_gerente", (string)DatosGerente["Direccion"]);
                    cmd.Parameters.AddWithValue("@fecha_ingreso", (DateTime)DatosGerente["Fecha_ingreso"]);
                    cmd.Parameters.AddWithValue("@salario_mensual", (double)DatosGerente["Salario"]);
                    cmd.Parameters.AddWithValue("@imagen_gerente", (byte[])DatosGerente["Imagen"]);
                    cmd.Parameters.AddWithValue("@usuario", (string)DatosGerente["Usuario"]);
                    cmd.Parameters.AddWithValue("@password", (string)DatosGerente["Password"]);
                    SqlParameter registroExitosoParam = new SqlParameter("@RegistroExitoso", SqlDbType.Bit);
                    registroExitosoParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(registroExitosoParam);
                    await cmd.ExecuteNonQueryAsync();

                    registrado = (bool)registroExitosoParam.Value;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            return registrado;
        }

        ///<summary>
        /// Actualiza los datos personales de un empleado en la base de datos.
        ///</summary>
        ///<param name="DatosPersonal">Un diccionario que contiene los datos personales del empleado.</param>
        ///<returns>Un booleano que indica si los datos fueron actualizados correctamente (true) o no (false).</returns>
        public async Task<bool>ActualizarDatosPersonal(Dictionary<string,object> DatosPersonal)
        {
            bool actualizado = false;
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    var cmd = new SqlCommand("ActualizarDatosPersonal", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cedula", (string)DatosPersonal["Id_personal"]);
                    cmd.Parameters.AddWithValue("@telefono_personal", (string)DatosPersonal["Telefono"]);
                    cmd.Parameters.AddWithValue("@correo_personal", (string)DatosPersonal["Correo"]);
                    cmd.Parameters.AddWithValue("@direccion_personal", (string)DatosPersonal["Direccion"]);
                    cmd.Parameters.AddWithValue("@imagen_personal", (byte[])DatosPersonal["Imagen"]);
                    SqlParameter actualizadoParam = new SqlParameter("@Actualizado", SqlDbType.Bit);
                    actualizadoParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(actualizadoParam);
                    await cmd.ExecuteNonQueryAsync();

                    actualizado = (bool)actualizadoParam.Value;
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            return actualizado;
        }

        ///<summary>
        /// Cambia las credenciales de acceso de un usuario en la base de datos.
        ///</summary>
        ///<param name="credencialesAcceso">Un objeto CredencialesAcceso que contiene las credenciales de acceso del usuario.</param>
        ///<returns>Un booleano que indica si las credenciales fueron cambiadas correctamente (true) o no (false).</returns>
        public async Task<bool> CambiarCredenciales(CredencialesAcceso credencialesAcceso)
        {
            bool IsChanged = false;
            try
            {
                if(await ConexionBD.AbrirConexionAsync())
                {
                    var cmd = new SqlCommand("CambiarCredenciales", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", credencialesAcceso.Id_usuario);
                    cmd.Parameters.AddWithValue("@new_password", credencialesAcceso.Password);
                    SqlParameter cambiadoParam = new SqlParameter("@cambiado", SqlDbType.Bit);
                    cambiadoParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cambiadoParam);
                    await cmd.ExecuteNonQueryAsync();

                    IsChanged = (bool)cambiadoParam.Value;
                }

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            return IsChanged;
        }
    }
}