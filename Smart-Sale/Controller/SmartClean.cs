using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using System.Windows.Forms;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid;

namespace Smart_Sale.Controller
{
    class SmartClean
    {
        public void limpiarTextEdit(GroupControl seccion)
        {
            foreach (Control ctrl in seccion.Controls)
            {
                if (ctrl is TextEdit)
                {
                    ((TextEdit)ctrl).Text = "";
                }
            }
        }
        public void restaurarComboBoxEdit(GroupControl seccion)
        {
            foreach (Control ctrl in seccion.Controls)
            {
                if (ctrl is ComboBoxEdit)
                {
                    ((ComboBoxEdit)ctrl).SelectedIndex = 0;
                }
            }

        }
        public void restaurarPictureEdit(GroupControl seccion)
        {
            foreach (Control ctrl in seccion.Controls)
            {
                if (ctrl is PictureEdit)
                {
                    ((PictureEdit)ctrl).Image = null;
                }
            }

        }
        public void restaurarCalcEdit(GroupControl seccion)
        {
            foreach (Control ctrl in seccion.Controls)
            {
                if (ctrl is CalcEdit)
                {
                    ((CalcEdit)ctrl).Value = 0;
                }
            }

        }
    }
}

