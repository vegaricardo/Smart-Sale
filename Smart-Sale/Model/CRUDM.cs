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
using System.Security.Cryptography;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

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
        DataTable datos;
        private string Encriptar(string aEncriptar, HashAlgorithm algoritmo)
        {
            try
            {
                byte[] convertir = Encoding.UTF8.GetBytes(aEncriptar);

                byte[] convertido = algoritmo.ComputeHash(convertir);

                StringBuilder forzar = new StringBuilder();

                for (int i = 0; i < convertido.Length; i++)
                {
                    forzar.Append(convertido[i].ToString("x2").ToLower());
                }
                return forzar.ToString();
            }
            catch (Exception)
            {

                //falta mensaje
                return null;
            }
        }

        // objetos con que realizamos la conecxion a la bd
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
                using (cnn = new FbConnection(cadenaConexion))
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

        #endregion//No haremos el codigo de smartclean porque vitor lo elimino se hizo mole
        //Tampoco haremos el boton de eliminar el departamentos y proveedores
        //haremos el metodo crud directamente en el model por que vitor se equivoca a cada rato.
        #region Ajustes
        public void leerProveedoresListBox(ListBoxControl aRellenar)
        {
            try
            {
                using (cnn = new FbConnection(cadenaConexion))
                {
                    string query = " SELECT * FROM Proveedores";

                    cnn.Open();

                    cmd = new FbCommand(query, cnn);

                    lector = cmd.ExecuteReader();

                    aRellenar.Items.Clear();

                    while (lector.Read())
                    {
                        aRellenar.Items.Add(lector[0].ToString());
                    }
                    lector.Close();
                }
            }
            catch (Exception)
            {
                //falta por terminar                
            }
        }

        public bool altaProveedores(string descripcion)
        {
            try
            {
                using (cnn = new FbConnection(cadenaConexion))
                {
                    string query = "INSERT INTO Proveedores VALUES( @descripcion)";

                    cnn.Open();

                    cmd = new FbCommand(query, cnn);

                    cmd.Parameters.AddWithValue("@descripcion", descripcion);


                    int respuesta = cmd.ExecuteNonQuery();

                    if (respuesta > 0)
                    {
                        return true;
                    }
                    else
                    {
                        /// midifcar el mensaje
                        DialogResult resul = llamarErrors.errorAltaProducto();

                        if (resul == DialogResult.Retry)
                        {
                            altaProveedores(descripcion);
                        }

                        return false;
                    }
                }
            }
            catch (Exception)
            {
                //modificar el mensaje
                DialogResult resul = llamarErrors.errorAltaProductoCritico();

                if (resul == DialogResult.Retry)
                {
                    altaProveedores(descripcion);
                }

                return false;

            }
        }

        public void leerDepartamentosListBox(ListBoxControl aRellenar)
        {
            try
            {
                using (cnn = new FbConnection(cadenaConexion))
                {
                    string query = " SELECT * FROM Departamentos";

                    cnn.Open();

                    cmd = new FbCommand(query, cnn);

                    lector = cmd.ExecuteReader();

                    aRellenar.Items.Clear();

                    while (lector.Read())
                    {
                        aRellenar.Items.Add(lector[0].ToString());
                    }
                    lector.Close();
                }
            }
            catch (Exception)
            {
                //falta por terminar                
            }
        }

        public bool altaDepartamentos(string descripcion)
        {
            try
            {
                using (cnn = new FbConnection(cadenaConexion))
                {
                    string query = "INSERT INTO Departamentos VALUES( @descripcion)";

                    cnn.Open();

                    cmd = new FbCommand(query, cnn);

                    cmd.Parameters.AddWithValue("@descripcion", descripcion);


                    int respuesta = cmd.ExecuteNonQuery();

                    if (respuesta > 0)
                    {
                        return true;
                    }
                    else
                    {
                        /// midifcar el mensaje
                        DialogResult resul = llamarErrors.errorAltaProducto();

                        if (resul == DialogResult.Retry)
                        {
                            altaDepartamentos(descripcion);
                        }

                        return false;
                    }
                }
            }
            catch (Exception)
            {
                //modificar el mensaje
                DialogResult resul = llamarErrors.errorAltaProductoCritico();

                if (resul == DialogResult.Retry)
                {
                    altaDepartamentos(descripcion);
                }

                return false;

            }
        }


        #endregion

        #region CRUD Usuarios
        public void leerUsuarios(GridControl aRellenar)
        {
            try
            {
                using (cnn = new FbConnection(cadenaConexion))
                {
                    string query = "SELECT IDU, Correo, Privilegio FROM Usuarios ";

                    cnn.Open();

                    cmd = new FbCommand(query, cnn);

                    datos = new DataTable();

                    adaptador = new FbDataAdapter(cmd);

                    adaptador.Fill(datos);

                    aRellenar.DataSource = datos;

                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {

                //falta mensaje
                MessageBox.Show(ex.ToString());
            }
        }

        public bool altaUsuario( string usuario, string contrasena, string correo, string pregunta, string respuesta, string privilegio, byte [] foto) // variables de la bd
        {
            try
            {
                using (cnn = new FbConnection(cadenaConexion))
                {
                    string query = "INSERT INTO Usuarios VALUES(@id, @usuario, @contrasena, @correo, @pregunta, @respuesta, @privilegio, @foto)";

                    int id = obtenerUltimoUsuario();

                    cnn.Open();

                    cmd = new FbCommand(query, cnn);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@usuario", Encriptar(usuario, new SHA512CryptoServiceProvider()));
                    cmd.Parameters.AddWithValue("@contrasena", Encriptar(contrasena, new SHA512CryptoServiceProvider()));
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@pregunta", Encriptar(pregunta, new SHA512CryptoServiceProvider()));
                    cmd.Parameters.AddWithValue("@respuesta", Encriptar(respuesta, new SHA512CryptoServiceProvider()));
                    cmd.Parameters.AddWithValue("@privilegio", privilegio);
                    cmd.Parameters.AddWithValue("@foto", foto);


                    int respuesta2 = cmd.ExecuteNonQuery();

                    if (respuesta2 > 0)
                    {
                        return true;
                    }
                    else
                    {
                        //falta mensaje
                        DialogResult resul = llamarErrors.errorAltaProducto();

                        if (resul == DialogResult.Retry)
                        {
                            altaUsuario( usuario, contrasena, correo, pregunta, respuesta, privilegio, foto);
                        }

                        return false;
                    }
                }
            }
            catch (Exception)
            {
                //falta mensaje
                DialogResult resul = llamarErrors.errorAltaProductoCritico();

                if (resul == DialogResult.Retry)
                {
                    altaUsuario( usuario, contrasena, correo, pregunta, respuesta, privilegio, foto);
                }

                return false;
            }

        }

        private int obtenerUltimoUsuario()
        {
            try
            {
                using (cnn = new FbConnection(cadenaConexion))
                {
                    string query = "SELECT MAX(IDU) FROM Usuarios";

                    cnn.Open();

                    cmd = new FbCommand(query, cnn);

                    lector = cmd.ExecuteReader();

                    string codigo = null;

                    int ncodigo = 0;

                    while (lector.Read())
                    {
                        codigo = lector[0].ToString();
                    }
                    lector.Close();

                    if (codigo == null || codigo == "")
                    {
                        ncodigo = 1;
                    }
                    else
                    {
                        ncodigo = Convert.ToInt32(codigo) + 1;
                    }
                    return ncodigo;
                }
            }
            catch (Exception ex)
            {

                //falta mensaje
                MessageBox.Show(ex.ToString());

                return 0;
            }
          
        }
  

        #endregion
    }
}
