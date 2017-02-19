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

namespace Smart_Sale.Controller// 58:38:56
{
    class MainBridge
    {
        CRUDM llamarCRUDM = new CRUDM();

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
    }
}
