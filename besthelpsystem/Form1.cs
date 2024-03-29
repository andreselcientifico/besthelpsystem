using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using besthelpsystem;


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
        private int bordeformulario = 2;
        private Size formSize;
        


        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void ajustarformulario()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != bordeformulario)
                        this.Padding = new Padding(bordeformulario);
                    break;
            }
        }

        public A1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 32);
            this.Padding = new Padding(bordeformulario);
            this.BackColor = Color.FromArgb(26, 25, 62);
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
            public static Color color8 = Color.Black;
        }

        //metodo para los botones
        private void Activarboton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                Deshabilitarboton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Red;
                currentBtn.ForeColor = Color.Black;
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
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
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
            formularioapertura pRUEBA_DE_APERTURA = new formularioapertura();
            pRUEBA_DE_APERTURA.abrirformulario(new Clientes());
            pRUEBA_DE_APERTURA.Show();
            pRUEBA_DE_APERTURA.Text = "Clientes";
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

        private void Reset()
        {
            Deshabilitarboton();
            leftBorderBtn.Visible = false;
            iconodeformulario.IconChar = IconChar.Home;
            iconodeformulario.IconColor = Color.CornflowerBlue;
            titulodeformulario.Text = "Home";
        }

        private void A1_Resize(object sender, EventArgs e)
        {
            ajustarformulario();
        }

        private void iconodeformulario_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Ventas_Click(object sender, EventArgs e)
        {
            formularioapertura pRUEBA_DE_APERTURA = new formularioapertura();
            pRUEBA_DE_APERTURA.abrirformulario(new Ventas());
            pRUEBA_DE_APERTURA.Show();
            pRUEBA_DE_APERTURA.Text = "Ventas";
            Activarboton(sender, ColorRGB.color2);
        }
    }
}