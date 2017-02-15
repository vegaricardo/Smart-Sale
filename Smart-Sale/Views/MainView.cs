using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System.Diagnostics;
namespace Smart_Sale.Views
{
    public partial class MainView : RibbonForm
    {
        public MainView()
        {
            InitializeComponent();
        }
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
            TabAjuste.PageVisible = true;
            XtraTabVentanas.SelectedTabPage = TabAjuste;
        }

        private void btnMenuUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            tabUsuarios.PageVisible = true;
            XtraTabVentanas.SelectedTabPage = tabUsuarios;
        }

        private void btnMenuProductos_ItemClick(object sender, ItemClickEventArgs e)
        {
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
    }
}