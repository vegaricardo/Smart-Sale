using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Smart_Sale.Errors
{
    class Errores
    {
        public static string redireccion = "Por favor pongase en contacto con soporte técnico si el error persiste.\n Escribanos al E-Mail: soporte@devut.com.mx";

        public DialogResult errorAltaProductoCritico()
        {
            return XtraMessageBox.Show(UserLookAndFeel.Default, "Error: 0x000pr1\n\n" + redireccion, "Error",MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
        public DialogResult errorAltaProducto()
        {
            return XtraMessageBox.Show(UserLookAndFeel.Default, "Por favor verifique los datos", "Datos incomplmetos o erróneos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
    }
}
