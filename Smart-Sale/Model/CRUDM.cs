using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using Smart_Sale.Errors;
using System.Windows.Forms;
using Smart_Sale.Messages;
using DevExpress.XtraGrid;

namespace Smart_Sale.Model
{
   
    class CRUDM
    {
        Errores llamarErrors = new Errores();// aki llamamos el metodo de errores
        Mensajes llmarMensajes = new Mensajes();

        private static string cadenaConexion = "User = SYSDBA; Password = masterkey; Database= " + Environment.CurrentDirectory + @"\SMARTDB.FDB;"; // es la conecion a la base de datos
        FbConnection cnn;
        FbCommand cmd;
        FbDataAdapter adaptador;
        FbDataReader lector;
        DataTable datos;      // objetos con que realizamos la conecxion a la bd
        #region CRUD Productos

        public void leerProductos(GridControl aRellenar)
        {
            try
            {
                using (cnn = new FbConnection(cadenaConexion)) 
                {
                    string query = "SELECT * FROM Productos ";

                    cnn.Open();

                    cmd = new FbCommand(query, cnn);

                    datos = new DataTable();

                    adaptador = new FbDataAdapter(cmd);

                    adaptador.Fill(datos);

                    aRellenar.DataSource = datos;

                    cmd.Dispose();
                }
            }
            catch (Exception)
            {

                //falta mensaje
            }
        }

        public void leerProveedores(ComboBoxEdit aRellenar)
        {
            try
            {
                using ( cnn = new FbConnection(cadenaConexion))
                {
                    string query = " SELECT * FROM Proveedores";

                    cnn.Open();

                    cmd = new FbCommand(query, cnn);

                    lector = cmd.ExecuteReader();

                    aRellenar.Properties.Items.Clear();

                    while (lector.Read())
                    {
                        aRellenar.Properties.Items.Add(lector[0].ToString());
                    }
                    lector.Close();
                }
            }
            catch (Exception)
            {
                //falta por terminar                
            }
        }

        public void leerDepartamentos(ComboBoxEdit aRellenar)
        {
            try
            {
                using (cnn = new FbConnection(cadenaConexion))
                {
                    string query = " SELECT * FROM Departamentos";

                    cnn.Open();

                    cmd = new FbCommand(query, cnn);

                    lector = cmd.ExecuteReader();

                    aRellenar.Properties.Items.Clear();

                    while (lector.Read())
                    {
                        aRellenar.Properties.Items.Add(lector[0].ToString());
                    }
                    lector.Close();
                }
            }
            catch (Exception)
            {
                //falta por terminar                
            }
        }

        public bool altaProducto(long codigobarra, string descripcion, string departamento, string proveedor, int existencia, decimal preciocompra, decimal precioventa) // variables de la bd
        {
            try
            {
                using (cnn = new FbConnection(cadenaConexion))
                {
                    string query = "INSERT INTO Productos VALUES(@codigobarra, @descripcion, @departamento, @proveedor, @existencia, @preciocompra, @precioventa)";

                    cnn.Open();

                    cmd = new FbCommand(query, cnn);

                    cmd.Parameters.AddWithValue("@codigobarra", codigobarra);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@departamento", departamento);
                    cmd.Parameters.AddWithValue("@proveedor", proveedor);
                    cmd.Parameters.AddWithValue("@existencia", existencia);
                    cmd.Parameters.AddWithValue("@preciocompra", preciocompra);
                    cmd.Parameters.AddWithValue("@precioventa", precioventa);

                    int respuesta = cmd.ExecuteNonQuery();

                    if (respuesta > 0)
                    {
                        return true;
                    }
                    else
                    {

                        DialogResult resul = llamarErrors.errorAltaProducto();

                        if (resul == DialogResult.Retry)
                        {
                            altaProducto(codigobarra, descripcion, departamento, proveedor, existencia, preciocompra, precioventa);
                        }

                        return false;
                    }
                }
            }
            catch (Exception)
            {

                DialogResult resul = llamarErrors.errorAltaProductoCritico();

                if (resul == DialogResult.Retry)
                {
                    altaProducto(codigobarra, descripcion, departamento, proveedor, existencia, preciocompra, precioventa);
                }

                return false;
            }
           
        }
        
        #endregion
    }
}
