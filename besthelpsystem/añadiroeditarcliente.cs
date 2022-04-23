using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using besthelpsystem.Conexion;
using besthelpsystem.Models;
using besthelpsystem.ModelsClass;
using MySql.Data.MySqlClient;

namespace besthelpsystem
{
    public partial class añadiroeditarcliente : Form
    {
        eventoTextbox ev = new eventoTextbox();

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

        public añadiroeditarcliente()
        {
            InitializeComponent();
            //Ingresarcliente.Checked = true;
            //Ingresarcliente.ForeColor = Color.DarkCyan;
        }


        private void id_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.numberkeypress(e);
        }


        private void nmbcompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.textkeyPress(e);
        }


        private void apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.textkeyPress(e);
        }

        private void direccion_TextChanged(object sender, EventArgs e)
        {
            //if (direccion.Text == "")
            //{
            //    labeldireccion.ForeColor = ColorRGB.color8;
            //}
            //else
            //{

            //    labeldireccion.ForeColor = ColorRGB.color9;
            //}
        }

        private void direccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //telefono.MaxLength = 10;
            ev.numberkeypress(e);
        }

        private void pgdeuda_TextChanged(object sender, EventArgs e)
        {
            //if (pgdeuda.Text == "")
            //{
            //    labelPgdeuda.ForeColor = ColorRGB.color8;
            //}
            //else
            //{

            //    labelPgdeuda.ForeColor = ColorRGB.color9;
            //}
        }

        private void pgdeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ev.numberdecimal(pgdeuda, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
                GuardarCliente();
        }

        private void GuardarCliente()
        {
            if (Identificacion.Text == "")
            {
                labelid.ForeColor = ColorRGB.color10;
                Identificacion.Focus();
            }
            else if (Nombres.Text == "") { labelnombre.ForeColor = ColorRGB.color10; Nombres.Focus(); }
            else if (Prmapellido.Text == "") { labelprmapellido.ForeColor = ColorRGB.color10; Prmapellido.Focus(); }
            else if (sgdapellido.Text == "") { labelprmapellido.ForeColor = ColorRGB.color10; sgdapellido.Focus(); }
            else if (genero.Text == "") { labelprmapellido.ForeColor = ColorRGB.color10; genero.Focus(); }
            else if (Telefono.Text == "") { labelprmapellido.ForeColor = ColorRGB.color10; Telefono.Focus(); }
            else if (Celular.Text == "") { labelprmapellido.ForeColor = ColorRGB.color10; Celular.Focus(); }
            else if (Correo.Text == "") { labelprmapellido.ForeColor = ColorRGB.color10; Correo.Focus(); }
            else if (Nhijo.Text == "") { labelprmapellido.ForeColor = ColorRGB.color10; Nhijo.Focus(); }
            else if (RUC.Text == "") { labelprmapellido.ForeColor = ColorRGB.color10; RUC.Focus(); }
            else
            {
                int codigo = int.Parse(Identificacion.Text);
                string nombre = Nombres.Text;
                string prmape = Prmapellido.Text;
                string correo = Correo.Text;
                double telef = double.Parse(Telefono.Text);

                string sql = "INSERT INTO Clientes (Id, Nombre, Apellido, Direccion,Telefono) VALUES ('" + codigo + "','" + nombre + "','" + prmape + "', '"+ correo +"','" + telef + "')";

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
                    MessageBox.Show("Error al guardar " + ex.Message);
                }
                finally
                {
                    connex.Close();
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void Identificacion_TextChanged(object sender, EventArgs e)
        {
            if (Identificacion.Text == "")
            {
                labelid.ForeColor = ColorRGB.color8;
            }
            else
            {

                labelid.ForeColor = ColorRGB.color9;
            }
        }

        private void Nombres_TextChanged(object sender, EventArgs e)
        {
            if (Nombres.Text == "")
            {
                labelnombre.ForeColor = ColorRGB.color8;
            }
            else
            {

                labelnombre.ForeColor = ColorRGB.color9;
            }
        }

        private void Prmapellido_TextChanged(object sender, EventArgs e)
        {
            if (Prmapellido.Text == "")
            {
                labelprmapellido.ForeColor = ColorRGB.color8;
            }
            else
            {

                labelprmapellido.ForeColor = ColorRGB.color9;
            }
        }

        private void sgdapellido_TextChanged(object sender, EventArgs e)
        {
            if (sgdapellido.Text == "")
            {
                labelsgdapellido.ForeColor = ColorRGB.color8;
            }
            else
            {

                labelsgdapellido.ForeColor = ColorRGB.color9;
            }
        }

        private void Telefono_TextChanged_1(object sender, EventArgs e)
        {
            if (Telefono.Text == "")
            {
                labeltelefono.ForeColor = ColorRGB.color8;
            }
            else
            {

                labeltelefono.ForeColor = ColorRGB.color9;
            }
        }

        private void Celular_TextChanged(object sender, EventArgs e)
        {
            if (Celular.Text == "")
            {
                labelcelular.ForeColor = ColorRGB.color8;
            }
            else
            {

                labelcelular.ForeColor = ColorRGB.color9;
            }
        }

        private void Correo_TextChanged(object sender, EventArgs e)
        {
            if (Correo.Text == "")
            {
                labelcorreo.ForeColor = ColorRGB.color8;
            }
            else
            {

                labelcorreo.ForeColor = ColorRGB.color9;
            }
        }

        private void Nhijo_TextChanged(object sender, EventArgs e)
        {
            if (Nhijo.Text == "")
            {
                labelhijos.ForeColor = ColorRGB.color8;
            }
            else
            {

                labelhijos.ForeColor = ColorRGB.color9;
            }
        }

        private void RUC_TextChanged(object sender, EventArgs e)
        {
            if (RUC.Text == "")
            {
                labelruc.ForeColor = ColorRGB.color8;
            }
            else
            {

                labelruc.ForeColor = ColorRGB.color9;
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
