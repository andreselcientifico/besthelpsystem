using FontAwesome.Sharp;
using System.Runtime.InteropServices;


namespace besthelpsystem
{
    public partial class A1 : Form
    {
        // para arrastrar desde el panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private IconButton currentBtn;
        public Panel leftBorderBtn;
        private Form formulariohijo;

        public A1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 32);
            Menuvertical.Controls.Add(leftBorderBtn);
            // formulario
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        // estructura para almacenar colores rgb
        private struct ColorRGB
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(249, 161, 251);
        }

        //metodo para los botones
        private void Activarboton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                Deshabilitarboton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // borde izquierdo del boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // icono del formulario
                iconodeformulario.IconChar = currentBtn.IconChar;
                iconodeformulario.IconColor = color;
            }
        }
        private void Deshabilitarboton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void Btncerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnmaximizar_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void Btnminimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }
        private void abrirformulario(Form hijo)
        {
            if (formulariohijo != null)
            {
                formulariohijo.Close();
            }
            formulariohijo = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            Panelcontenedor.Controls.Add(hijo);
            Panelcontenedor.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
            titulodeformulario.Text = hijo.Text;
        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            abrirformulario(new Ventas());
            Activarboton(sender, ColorRGB.color2);
        }

        private void Reportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
            Activarboton(sender, ColorRGB.color7);
        }

        private void Reporteventas_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void Reportecompras_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void Reportepagos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Activarboton(sender, ColorRGB.color1);
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            abrirformulario(new Clientes());
            Activarboton(sender, ColorRGB.color3);
        }

        private void Compras_Click(object sender, EventArgs e)
        {
            Activarboton(sender, ColorRGB.color4);
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            Activarboton(sender, ColorRGB.color5);
        }

        private void Pagos_Click(object sender, EventArgs e)
        {
            Activarboton(sender, ColorRGB.color6);
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            formulariohijo.Close();
            Reset();
        }
        private void Reset()
        {
            Deshabilitarboton();
            leftBorderBtn.Visible = false;
            iconodeformulario.IconChar = IconChar.Home;
            iconodeformulario.IconColor = Color.CornflowerBlue;
            titulodeformulario.Text = "Home";
        }
    }
}