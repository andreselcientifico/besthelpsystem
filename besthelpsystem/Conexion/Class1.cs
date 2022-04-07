using MySql.Data.MySqlClient;

namespace besthelpsystem.Conexion
{

    class conexion
    {
        public static MySqlConnection connection()
        {
            try
            {

                MySqlConnection connex = new MySqlConnection("server=localhost;database=besthelp;Uid=root;pwd=");
                return connex;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }

        }
    }
}
