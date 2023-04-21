using utilitaries.CustomControls;

namespace libraries
{
    /// <summary>
    /// Guardian es un conjunto de técnicas místicas que te permiten validar diferentes tipos de datos,
    /// con sus poderoso hechizos, puedes asegurarte de que tus usuarios ingresen datos correctos y evites errores inesperados en tu aplicación.
    /// </summary>
    public class Guardian
    {
        /// <summary>
        /// Recibe un email y verifica que tenga el formato válido
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Si el correo es válido</returns>
        public static bool IsValidEmail(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                return false;
            }
            try
            {
                var valido = new System.Net.Mail.MailAddress(textBox.Text);
                return valido.Address == textBox.Text;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsValidEmailCustom(CustomTextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                return false;
            }
            try
            {
                var valido = new System.Net.Mail.MailAddress(textBox.Text);
                return valido.Address == textBox.Text;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Esta función recibe uno o más TextBoxes como entrada y agrega un evento KeyPress a cada TextBox para validar que solo se ingresen valores decimales. Si el usuario ingresa un carácter no numérico o más de una coma, el carácter no se acepta y el valor del TextBox no se actualiza. La función también permite al usuario borrar caracteres usando la tecla de retroceso.
        /// </summary>
        /// <param name="textBoxes"></param>
        public static void ValidateDecimalInput(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.KeyPress += (sender, e) =>
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == ',' && textBox.Text.Contains(","))
                    {
                        e.Handled = true;
                    }
                };
            }
        }
        public static void ValidateDecimalInputCustom(params CustomTextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.KeyPress += (sender, e) =>
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == ',' && textBox.Text.Contains(","))
                    {
                        e.Handled = true;
                    }
                };
            }
        }

        /// <summary>
        /// Esta función recibe uno o más TextBoxes como entrada y agrega un evento KeyPress a cada TextBox para validar que solo se ingresen valores enteros. Si el usuario ingresa un carácter no numérico, el carácter no es aceptado y el valor del TextBox no se actualiza. La función permite al usuario eliminar caracteres usando la tecla de retroceso (backspace).
        /// </summary>
        /// <param name="textBoxes"></param>
        public static void ValidateIntegerInput(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.KeyPress += (sender, e) =>
                {
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                        return;
                    }
                };
            }
        }
        public static void ValidateIntegerInputCustom(params CustomTextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.KeyPress += (sender, e) =>
                {
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                        return;
                    }
                };
            }
        }

        /// <summary>
        /// Esta función recibe uno o más TextBoxes como entrada y agrega un evento KeyPress a cada uno de ellos para validar que solo se ingresen valores enteros positivos de hasta 10 dígitos. Si el usuario intenta ingresar un carácter que no es un dígito o presiona la tecla "Backspace", el carácter no se acepta y el valor del TextBox no se actualiza. Además, la función establece la longitud máxima del TextBox en 10 caracteres.
        /// </summary>
        /// <param name="textBoxes"></param>
        public static void ValidateIdInput(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.KeyPress += (sender, e) =>
                {
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                        return;
                    }
                };
                textBox.MaxLength = 10;
            }
        }
        public static void ValidateIdInputCustom(params CustomTextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.KeyPress += (sender, e) =>
                {
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                        return;
                    }
                };
                textBox.MaxLenght = 10;
            }
        }

        /// <summary>
        /// Esta función recibe uno o más TextBox como entrada y agrega un evento KeyPress a cada uno de ellos para validar que solo se ingresen caracteres de texto. Si el usuario ingresa un carácter que no es una letra o un carácter de control, el carácter no se acepta y el valor del TextBox no se actualiza. La función permite el uso de espacios en blanco y de la tecla de retroceso.
        /// </summary>
        /// <param name="textBoxes"></param>
        public static void ValidateTextInput(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.KeyPress += (sender, e) =>
                {
                    if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = true;
                        return;
                    }
                };
            }
        }
        public static void ValidateTextInputCustom(params CustomTextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.KeyPress += (sender, e) =>
                {
                    if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = true;
                        return;
                    }
                };
            }
        }

        /// <summary>
        /// Compara dos entradas de un textbox y devuelve si las cadenas son iguales o no como un bool
        /// </summary>
        /// <param name="textbox1"></param>
        /// <param name="textbox2"></param>
        /// <returns>Si las entradas son iguales</returns>
        public static bool AreTextEqual(TextBox textbox1, TextBox textbox2)
        {
            return textbox1.Text == textbox2.Text;
        }
        public static bool AreTextEqualCustom(CustomTextBox textbox1, CustomTextBox textbox2)
        {
            return textbox1.Text == textbox2.Text;
        }
    }
}