using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System.Diagnostics;
using Smart_Sale.Controller;

namespace Smart_Sale.Views
{
    public partial class MainView : RibbonForm
    {
        public MainView()
        {
            InitializeComponent();
        }

        MainBridge llamarMainBridge = new MainBridge();

        

        //Nuevo numerode azar
        Random azar = new Random();
        private void tmpReloj_Tick(object sender, EventArgs e)
        {
            barReloj.Caption = string.Format("{0}-{1:MMM} {2}",DateTime.Now.Day,DateTime.Now,DateTime.Now.ToShortTimeString());
        }

       
      

        private void tmpPublicidad_Tick(object sender, EventArgs e)
        {
            cambiarPublicidad();
        }

        //Establece la imagen que se seleccionara en el apartado de publicidad
        private void cambiarPublicidad()
        {
            switch (azar.Next(0, 8))
            {
                case 1:
                    petPublicidad.Image = Properties.Resources.bimbo;
                    break;
                case 2:
                    petPublicidad.Image = Properties.Resources.alpura;
                    break;
                case 3:
                    petPublicidad.Image = Properties.Resources.coca;
                    break;
                case 4:
                    petPublicidad.Image = Properties.Resources.devut;
                    break;
                case 5:
                    petPublicidad.Image = Properties.Resources.gamesa;
                    break;
                case 6:
                    petPublicidad.Image = Properties.Resources.lala;
                    break;
                case 7:
                    petPublicidad.Image = Properties.Resources.pepsi;
                    break;
                case 8:
                    petPublicidad.Image = Properties.Resources.sabritas;
                    break;
                default:
                    petPublicidad.Image = Properties.Resources.devut;
                    break;
            }
        }

        private void btnEnlacePagina_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            Process.Start(btnEnlacePagina.Caption);
        }

        private void btnMenuAjustes_ItemClick(object sender, ItemClickEventArgs e)
        {
            llamarMainBridge.leerProveedoresListBox(lbcProveedor);
            llamarMainBridge.leerDepartamentosListBox(lbcDepartamento);
        
            TabAjuste.PageVisible = true;
            XtraTabVentanas.SelectedTabPage = TabAjuste;
        }

        private void btnMenuUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            llamarMainBridge.leerUsuarios(gdcUsuarios);

            tabUsuarios.PageVisible = true;
            XtraTabVentanas.SelectedTabPage = tabUsuarios;
        }

        private void btnMenuProductos_ItemClick(object sender, ItemClickEventArgs e)
        {
            llamarMainBridge.leerProductos(gdcProductos);
            llamarMainBridge.leerDepartamentos(cbxDepartamento);
            llamarMainBridge.leerProveedores(cbxProveedor);

            restaurarProductos();   
            
            tabProductos.PageVisible = true;
            XtraTabVentanas.SelectedTabPage = tabProductos;
        }

        private void btnMenuVentas_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabVentas.PageVisible = true;
            XtraTabVentanas.SelectedTabPage = TabVentas;
        }
        //Metodo para poder cerrar las pestañas del XtraTabVentanas
        private void XtraTabVentanas_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs cerrar = e as ClosePageButtonEventArgs;
            if (cerrar.Page.Text == "Ajustes")
            {
                TabAjuste.PageVisible = false;
            }
            //aki inicia esto se puede comentarpero ahorita lo dejo asi victor le quito el else if de ventas para que no se podiera cerrar la pestaña del mismo
            else if (cerrar.Page.Text == "Ventas")
            {
                MessageBox.Show("No se puede cerrar  que no vez que es el principal wuey... LOSER!!!! :)");
            }
            //aki termina el else if de ventas
            else if (cerrar.Page.Text == "Productos")
            {
                tabProductos.PageVisible = false;
            }
            else if (cerrar.Page.Text == "Usuarios")
            {
                tabUsuarios.PageVisible = false;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            bool resul = llamarMainBridge.altaProducto(Convert.ToInt64(txtCodigoBarra.Text), txtDescripcion.Text, cbxDepartamento.Text, cbxProveedor.Text, Convert.ToInt32(cetExistencia.Value), Convert.ToDecimal(cetPrecioCompra.Value), Convert.ToDecimal(cetPrecioVenta.Value));

            if (resul)
            {
                //reajustar
                llamarMainBridge.leerProductos(gdcProductos);
                XtraMessageBox.Show(UserLookAndFeel.Default,"Si se clavo en la base de datos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            restaurarProductos();
        }

        private void btnAgregarDepartamento_Click(object sender, EventArgs e)
        {
            if (txtDepartamento.Text == "")
            {
                //mensaje que esta vacio
            }
            else
            {
               bool resul = llamarMainBridge.altaDepartamentos(txtDepartamento.Text);
                if (resul)
                {
                    //mensaje de que si jalo
                    llamarMainBridge.leerDepartamentosListBox(lbcDepartamento);
                    txtDepartamento.Text = "";
                }
                else
                {
                    //mensaje de que no jalo
                }
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            if (txtProveedor.Text == "")
            {
                //mensaje que esta vacio
            }
            else
            {
                bool resul = llamarMainBridge.altaProveedores(txtProveedor.Text);
                if (resul)
                {
                    //mensaje de que si jalo
                    llamarMainBridge.leerProveedoresListBox(lbcProveedor);
                    txtProveedor.Text = "";
                }
                else
                {
                    //mensaje de que no jalo
                }
            }

        }

        #region Limpieza

        private void restaurarProductos()
        {
            txtCodigoBarra.Text = "";
            txtDescripcion.Text = "";
            cbxDepartamento.SelectedIndex = 0;
            cbxProveedor.SelectedIndex = 0;
            cetExistencia.Value = 0;
            cetPrecioCompra.Value = 0;
            cetPrecioVenta.Value = 0;


            llamarMainBridge.leerProductos(gdcProductos);
        }



        #endregion

        private void petVerContrasena_MouseDown(object sender, MouseEventArgs e)
        {
            txtContrasena.Properties.PasswordChar = '\0';
            txtRContrasena.Properties.PasswordChar = '\0';
        }

        private void petVerContrasena_MouseUp(object sender, MouseEventArgs e)
        {
            txtContrasena.Properties.PasswordChar = '•';
            txtRContrasena.Properties.PasswordChar = '•';
        }

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {

            if (txtContrasena.Text == txtRContrasena.Text)
            {
                if (txtUsuario.Text == "" || txtEmail.Text == "" || txtPregunta.Text == "" || txtRespuesta.Text == "" || cbxPrivilegio.SelectedIndex < 0)
                {
                    //nos falta mensaje porque vitor tenia sueño
                }
                else
                {

                    bool resul = llamarMainBridge.altaUsuario(txtUsuario.Text, txtContrasena.Text, txtEmail.Text, txtPregunta.Text, txtRespuesta.Text, cbxPrivilegio.Text, petFotoUsuario.Image);
                    if (resul)
                    {
                        //reajustar
                        llamarMainBridge.leerUsuarios(gdcUsuarios);
                        XtraMessageBox.Show(UserLookAndFeel.Default, "Si se clavo en la base de datos");
                    }
                }
            }
            else
            {
                //nos falta mensaje porque vitor tenia sueño
            }
        }
    }
}