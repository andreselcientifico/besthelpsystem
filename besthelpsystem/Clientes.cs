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
            cargarTabla(null);
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

        private void inscribirbtn_Click(object sender, EventArgs e)
        {
            formularioapertura pRUEBA_DE_APERTURA = new formularioapertura();
            pRUEBA_DE_APERTURA.abrirformulario(new añadiroeditarcliente());
            pRUEBA_DE_APERTURA.Text = "Inscribir Cliente";
            pRUEBA_DE_APERTURA.Show();
        }
    }
}
