using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void btnEnlacePagina_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            Process.Start(btnEnlacePagina.Caption);
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

       

        
    }
}