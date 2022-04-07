using besthelpsystem.Conexion;
using MySql.Data.MySqlClient;

namespace besthelpsystem.Models
{
    class CtrlClientes
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;
            if (dato == null)
            {
                sql = "SELECT Id, Nombre,Apellido, Direccion,Telefono FROM Clientes ORDER BY Nombre ASC";

            }
            else
            {
                sql = "SELECT Id, Nombre,Apellido, Direccion,Telefono FROM Clientes WHERE Id LIKE '%" + dato + "%' OR Nombre LIKE '%" + dato + "%' OR Apellido LIKE '%" + dato + "%' OR Direccion LIKE '%" + dato + "%' OR Telefono LIKE '%" + dato + "%' ORDER BY Nombre ASC";

            }
            try
            {
                MySqlConnection connex = conexion.connection();
                connex.Open();
                MySqlCommand comando = new MySqlCommand(sql, connex);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Clientes clientes = new Clientes();
                    clientes.Id1 = int.Parse(reader.GetString(0));
                    clientes.Nombre1 = reader.GetString(1);
                    clientes.Apellido1 = reader.GetString(2);
                    clientes.Direccion1 = reader.GetString(3);
                    clientes.Telefono1 = double.Parse(reader.GetString(4));
                    lista.Add(clientes);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }


    }

}
