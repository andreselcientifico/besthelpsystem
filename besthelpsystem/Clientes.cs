using besthelpsystem.Conexion;
using besthelpsystem.Models;
using besthelpsystem.ModelsClass;
using MySql.Data.MySqlClient;

namespace besthelpsystem
{
    public partial class Clientes : Form
    {
        private struct ColorRGB
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(249, 161, 251);
            public static Color color8 = Color.FromArgb(0, 0, 64);
            public static Color color9 = Color.Cyan;
            public static Color color10 = Color.Red;
        }
        eventoTextbox ev = new eventoTextbox();
        public Clientes()
        {
            InitializeComponent();
            Ingresarcliente.Checked = true;
            Ingresarcliente.ForeColor = Color.DarkCyan;
            cargarTabla(null);
        }

        private void Ingresarcliente_CheckedChanged(object sender, EventArgs e)
        {
            Pagosdeuda.ForeColor = Color.Black;
            Ingresarcliente.ForeColor = Color.DarkCyan;
            id.ReadOnly = false;
            nmbcompleto.ReadOnly = false;
            apellido.ReadOnly = false;
            direccion.ReadOnly = false;
            telefono.ReadOnly = false;
            pgdeuda.ReadOnly = true;
            labelPgdeuda.ForeColor = Color.DarkCyan;
        }

        private void Pagosdeuda_CheckedChanged(object sender, EventArgs e)
        {
            Pagosdeuda.ForeColor = Color.DarkCyan;
            Ingresarcliente.ForeColor = Color.Black;
            id.ReadOnly = true;
            nmbcompleto.ReadOnly = true;
            apellido.ReadOnly = true;
            direccion.ReadOnly = true;
            telefono.ReadOnly = true;
            pgdeuda.ReadOnly = false;


        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                labelid.ForeColor = ColorRGB.color8;
            }
            else
            {

                labelid.ForeColor = ColorRGB.color9;
            }
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.numberkeypress(e);
        }

        private void nmbcompleto_TextChanged(object sender, EventArgs e)
        {
            if (nmbcompleto.Text == "")
            {
                labelnmbcompleto.ForeColor = ColorRGB.color8;
            }
            else
            {

                labelnmbcompleto.ForeColor = ColorRGB.color9;
            }
        }

        private void nmbcompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.textkeyPress(e);
        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {
            if (apellido.Text == "")
            {
                labelapellido.ForeColor = ColorRGB.color8;
            }
            else
            {

                labelapellido.ForeColor = ColorRGB.color9;
            }
        }

        private void apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.textkeyPress(e);
        }

        private void direccion_TextChanged(object sender, EventArgs e)
        {
            if (direccion.Text == "")
            {
                labeldireccion.ForeColor = ColorRGB.color8;
            }
            else
            {

                labeldireccion.ForeColor = ColorRGB.color9;
            }
        }

        private void direccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void telefono_TextChanged(object sender, EventArgs e)
        {
            if (telefono.Text == "")
            {
                labeltelefono.ForeColor = ColorRGB.color8;
            }
            else
            {

                labeltelefono.ForeColor = ColorRGB.color9;
            }
        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            telefono.MaxLength = 10;
            ev.numberkeypress(e);
        }

        private void pgdeuda_TextChanged(object sender, EventArgs e)
        {
            if (pgdeuda.Text == "")
            {
                labelPgdeuda.ForeColor = ColorRGB.color8;
            }
            else
            {

                labelPgdeuda.ForeColor = ColorRGB.color9;
            }
        }

        private void pgdeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.numberdecimal(pgdeuda, e);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (Ingresarcliente.Checked)
            {
                GuardarCliente();

            }

        }
        private void GuardarCliente()
        {
            if (id.Text == "")
            {
                labelid.ForeColor = ColorRGB.color10;
                id.Focus();
            }
            else if (nmbcompleto.Text == "") { labelnmbcompleto.ForeColor = ColorRGB.color10; nmbcompleto.Focus(); }
            else if (apellido.Text == "") { labelapellido.ForeColor = ColorRGB.color10; apellido.Focus(); }
            else if (direccion.Text == "") { labeldireccion.ForeColor = ColorRGB.color10; direccion.Focus(); }
            else if (telefono.Text == "") { labeltelefono.ForeColor = ColorRGB.color10; telefono.Focus(); }
            else
            {
                int codigo = int.Parse(id.Text);
                string nombre = nmbcompleto.Text;
                string ape = apellido.Text;
                string direc = direccion.Text;
                double telef = double.Parse(telefono.Text);

                string sql = "INSERT INTO Clientes (Id, Nombre, Apellido, Direccion,Telefono) VALUES ('" + codigo + "','" + nombre + "','" + ape + "','" + direc + "','" + telef + "')";

                MySqlConnection connex = conexion.connection();
                connex.Open();
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, connex);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al guardar" + ex.Message);
                }
                finally
                {
                    connex.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dato = Buscar.Text;
            cargarTabla(dato);

        }
        private void cargarTabla(string dato)
        {
            List<Clientes> lista = new List<Clientes>();
            CtrlClientes ctrlClientes = new CtrlClientes();
            tabladedatos.DataSource = ctrlClientes.consulta(dato);
        }
    }
}
