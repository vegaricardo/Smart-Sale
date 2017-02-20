using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using Smart_Sale.Model;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace Smart_Sale.Controller// 58:38:56
{
    class MainBridge
    {
        CRUDM llamarCRUDM = new CRUDM();

        private Image RehacerImagen( byte[] datos)
        {
            MemoryStream ms = new MemoryStream(datos);

            Image imagen = Image.FromStream(ms);

            return imagen;

        }

        private byte[] ConvertirFoto(Image foto)
        {
            MemoryStream ms = new MemoryStream();

            foto.Save(ms, ImageFormat.Png);

            byte[] datos = ms.GetBuffer();

            return datos;
        }

        #region CRUD Productos

        public void leerProductos(GridControl aRellenar)
        {
            llamarCRUDM.leerProductos(aRellenar);
        }

        public void leerProveedores(ComboBoxEdit aRellenar)
        {
            llamarCRUDM.leerProveedores(aRellenar);
        }

        public void leerDepartamentos(ComboBoxEdit aRellenar)
        {
            llamarCRUDM.leerDepartamentos(aRellenar);
        }

        public bool altaProducto(long codigobarra, string descripcion, string departamento, string proveedor, int existencia, decimal preciocompra, decimal precioventa)
        {
            return llamarCRUDM.altaProducto(codigobarra, descripcion, departamento, proveedor, existencia, preciocompra, precioventa);
        }

        #endregion Productos

        #region CRUD Ajustes

        public void leerProveedoresListBox(ListBoxControl aRellenar)
        {
            llamarCRUDM.leerProveedoresListBox(aRellenar);
        }

        public bool altaProveedores(string descripcion)
        {
            return llamarCRUDM.altaProveedores(descripcion);
        }

        public void leerDepartamentosListBox(ListBoxControl aRellenar)
        {
            llamarCRUDM.leerDepartamentosListBox(aRellenar);
        }

        public bool altaDepartamentos(string descripcion)
        {
            return llamarCRUDM.altaDepartamentos(descripcion);
        }

        #endregion

        #region CRUD Usuarios
        public void leerUsuarios(GridControl aRellenar)
        {
            llamarCRUDM.leerUsuarios(aRellenar);
        }


        public bool altaUsuario(string usuario, string contrasena, string correo, string pregunta, string respuesta, string privilegio, Image foto)
        {
            byte[] datos = null;

            if (foto != null)
            {
                datos = ConvertirFoto(foto);
            }
            return llamarCRUDM.altaUsuario(usuario, contrasena, correo, pregunta, respuesta, privilegio, datos);
        }
        #endregion

    }
}
