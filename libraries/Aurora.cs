﻿namespace libraries
{
    /// <summary>
    /// Aurora es la librería dedicada a las funciones gráficas y manejo de formularios,
    /// tal como un artista con las herramientas brillantes para su lienzo
    /// </summary>
    public class Aurora
    {
        /// <summary>
        /// Recibe como parametro un formulario y comprueba si los text box estan vacios o no devolviendo un bool
        /// </summary>
        /// <param name="form"></param>
        /// <returns>Si los TextBox están vacíos</returns>
        public static bool AreTextBoxEmpty(Form form)
        {
            bool isEmpty = false;
            foreach(Control control in form.Controls)
            {
                if(control is TextBox textBox)
                {
                    if(string.IsNullOrEmpty(textBox.Text))
                    {
                        isEmpty = true;
                        break;
                    }
                }
            }
            return isEmpty;
        }

        /// <summary>
        /// Recibe como parametro un panel y comprueba si los text box estan vacios o no devolviendo un bool
        /// </summary>
        /// <param name="panel"></param>
        /// <returns>Si los TexBox están vacíos</returns>
        public static bool AreTextBoxPanelEmpty(Panel panel)
        {
            bool isEmpty = false;
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        isEmpty = true;
                        break;
                    }
                }
            }
            return isEmpty;
        }

        /// <summary>
        /// Recibe como parametro un formulario y comprueba si los text box han sido modificado o no, devolviendo un bool
        /// </summary>
        /// <param name="form"></param>
        /// <returns>Si los TextBox han sido modificados</returns>
        public static bool AreTextBoxModified(Form form)
        {
            bool isModified = false;
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (textBox.Modified == true)
                    {
                        //Los textBox han sido modificados
                        isModified = true;
                    }
                }
            }
            return isModified;
        }

        /// <summary>
        /// Recibe como parametro un panel y comprueba si los text box han sido modificado o no, devolviendo un bool
        /// </summary>
        /// <param name="panel"></param>
        /// <returns></returns>
        public static bool AreTextBoxPanelModified(Panel panel)
        {
            bool isModified = false;
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (textBox.Modified == true)
                    {
                        //Los textBox han sido modificados
                        isModified = true;
                    }
                }
            }
            return isModified;
        }

        /// <summary>
        /// Reestablece todos los controles del formulario
        /// </summary>
        /// <param name="form"></param>
        public static void ClearForm(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if(control is TextBox textBox)
                {
                    textBox.Clear();
                }
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                if(control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                if(control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now;
                }
            }
        }

        /// <summary>
        /// Reestablece todos los controles de un panel
        /// </summary>
        /// <param name="panel"></param>
        public static void ClearPanel(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now;
                }
            }
        }

        /// <summary>
        /// Toma uno o más parámetros TextBox y establece la propiedad "UseSystemPasswordChar" de cada TextBox en true, lo que hace que los caracteres ingresados en los TextBox aparezcan como asteriscos o puntos para ocultar la contraseña.
        /// </summary>
        /// <param name="textBoxes"></param>
        public static void HidePassword(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// Toma uno o más parámetros TextBox y establece la propiedad "UseSystemPasswordChar" de cada TextBox en false, lo que hace que los caracteres ingresados en los TextBox aparezcan en texto legible para ver la contraseña.
        /// </summary>
        /// <param name="textBoxes"></param>
        public static void ShowPassword(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.UseSystemPasswordChar = false;
            }
        }

    }
}