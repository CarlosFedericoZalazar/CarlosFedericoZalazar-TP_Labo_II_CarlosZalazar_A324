using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestoForm
{
    public class Validations
    {
        public static bool VerificarTextBoxesLlenos(Form f)
        {
            foreach (Control control in f.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show($"El campo {textBox.Name} no puede estar vacío.");
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
