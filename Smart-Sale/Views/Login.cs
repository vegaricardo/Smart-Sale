using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace Smart_Sale.Views
{
    public partial class Login : XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void petVerContrasena_MouseDown(object sender, MouseEventArgs e)
        {
            petVerContrasena.Image = Properties.Resources.Invisible;
            txtContrasena.Properties.PasswordChar = '\0';

        }

        private void petVerContrasena_MouseUp(object sender, MouseEventArgs e)
        {
            petVerContrasena.Image = Properties.Resources.Visible;
            txtContrasena.Properties.PasswordChar = '•';
        }

        private void lblContrasenaOlvidada_Click(object sender, EventArgs e)
        {
            Process.Start("www.devut.com.mx");
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            MainView llamarMainView = new MainView();
            llamarMainView.Show();
            Hide();
        }

        private void petSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}