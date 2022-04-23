namespace besthelpsystem
{
    partial class A1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A1));
            this.Barratitulo = new System.Windows.Forms.Panel();
            this.titulodeformulario = new System.Windows.Forms.Label();
            this.iconodeformulario = new FontAwesome.Sharp.IconPictureBox();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.Btnmaximizar = new System.Windows.Forms.Button();
            this.Btnminimizar = new System.Windows.Forms.Button();
            this.Panelcontenedor = new System.Windows.Forms.Panel();
            this.Pagos = new FontAwesome.Sharp.IconButton();
            this.Empleados = new FontAwesome.Sharp.IconButton();
            this.Compras = new FontAwesome.Sharp.IconButton();
            this.Ventas = new FontAwesome.Sharp.IconButton();
            this.Clientes = new FontAwesome.Sharp.IconButton();
            this.Productos = new FontAwesome.Sharp.IconButton();
            this.Reportes = new FontAwesome.Sharp.IconButton();
            this.SubmenuReportes = new System.Windows.Forms.Panel();
            this.Reportecompras = new FontAwesome.Sharp.IconButton();
            this.Reportepagos = new FontAwesome.Sharp.IconButton();
            this.Reporteventas = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Barratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconodeformulario)).BeginInit();
            this.Panelcontenedor.SuspendLayout();
            this.SubmenuReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barratitulo
            // 
            this.Barratitulo.BackColor = System.Drawing.Color.Red;
            this.Barratitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Barratitulo.Controls.Add(this.titulodeformulario);
            this.Barratitulo.Controls.Add(this.iconodeformulario);
            this.Barratitulo.Controls.Add(this.Btncerrar);
            this.Barratitulo.Controls.Add(this.Btnmaximizar);
            this.Barratitulo.Controls.Add(this.Btnminimizar);
            this.Barratitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barratitulo.Location = new System.Drawing.Point(0, 0);
            this.Barratitulo.Name = "Barratitulo";
            this.Barratitulo.Size = new System.Drawing.Size(1300, 35);
            this.Barratitulo.TabIndex = 0;
            this.Barratitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barratitulo_MouseDown);
            // 
            // titulodeformulario
            // 
            this.titulodeformulario.AutoSize = true;
            this.titulodeformulario.ForeColor = System.Drawing.Color.White;
            this.titulodeformulario.Location = new System.Drawing.Point(44, 10);
            this.titulodeformulario.Name = "titulodeformulario";
            this.titulodeformulario.Size = new System.Drawing.Size(40, 15);
            this.titulodeformulario.TabIndex = 4;
            this.titulodeformulario.Text = "Home";
            // 
            // iconodeformulario
            // 
            this.iconodeformulario.BackColor = System.Drawing.Color.Transparent;
            this.iconodeformulario.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.iconodeformulario.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconodeformulario.IconColor = System.Drawing.Color.CornflowerBlue;
            this.iconodeformulario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconodeformulario.Location = new System.Drawing.Point(6, 0);
            this.iconodeformulario.Name = "iconodeformulario";
            this.iconodeformulario.Size = new System.Drawing.Size(32, 32);
            this.iconodeformulario.TabIndex = 3;
            this.iconodeformulario.TabStop = false;
            this.iconodeformulario.Click += new System.EventHandler(this.iconodeformulario_Click);
            // 
            // Btncerrar
            // 
            this.Btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.Btncerrar.FlatAppearance.BorderSize = 0;
            this.Btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.Btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(3)))));
            this.Btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btncerrar.Image")));
            this.Btncerrar.Location = new System.Drawing.Point(1246, 2);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(50, 30);
            this.Btncerrar.TabIndex = 2;
            this.Btncerrar.Text = "\r\n\r\n";
            this.Btncerrar.UseVisualStyleBackColor = false;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click_1);
            // 
            // Btnmaximizar
            // 
            this.Btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnmaximizar.BackColor = System.Drawing.Color.Transparent;
            this.Btnmaximizar.FlatAppearance.BorderSize = 0;
            this.Btnmaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.Btnmaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.Btnmaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("Btnmaximizar.Image")));
            this.Btnmaximizar.Location = new System.Drawing.Point(1196, 2);
            this.Btnmaximizar.Name = "Btnmaximizar";
            this.Btnmaximizar.Size = new System.Drawing.Size(50, 30);
            this.Btnmaximizar.TabIndex = 1;
            this.Btnmaximizar.Text = "\r\n\r\n";
            this.Btnmaximizar.UseVisualStyleBackColor = false;
            this.Btnmaximizar.Click += new System.EventHandler(this.Btnmaximizar_Click_1);
            // 
            // Btnminimizar
            // 
            this.Btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnminimizar.BackColor = System.Drawing.Color.Transparent;
            this.Btnminimizar.FlatAppearance.BorderSize = 0;
            this.Btnminimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.Btnminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.Btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btnminimizar.Image")));
            this.Btnminimizar.Location = new System.Drawing.Point(1146, 2);
            this.Btnminimizar.Name = "Btnminimizar";
            this.Btnminimizar.Size = new System.Drawing.Size(50, 30);
            this.Btnminimizar.TabIndex = 0;
            this.Btnminimizar.Text = "\r\n\r\n";
            this.Btnminimizar.UseVisualStyleBackColor = false;
            this.Btnminimizar.Click += new System.EventHandler(this.Btnminimizar_Click);
            // 
            // Panelcontenedor
            // 
            this.Panelcontenedor.BackColor = System.Drawing.Color.Black;
            this.Panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panelcontenedor.Controls.Add(this.Pagos);
            this.Panelcontenedor.Controls.Add(this.Empleados);
            this.Panelcontenedor.Controls.Add(this.Compras);
            this.Panelcontenedor.Controls.Add(this.Ventas);
            this.Panelcontenedor.Controls.Add(this.Clientes);
            this.Panelcontenedor.Controls.Add(this.Productos);
            this.Panelcontenedor.Controls.Add(this.Reportes);
            this.Panelcontenedor.Controls.Add(this.SubmenuReportes);
            this.Panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panelcontenedor.Location = new System.Drawing.Point(0, 35);
            this.Panelcontenedor.Name = "Panelcontenedor";
            this.Panelcontenedor.Size = new System.Drawing.Size(1300, 615);
            this.Panelcontenedor.TabIndex = 2;
            // 
            // Pagos
            // 
            this.Pagos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pagos.BackColor = System.Drawing.Color.Red;
            this.Pagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pagos.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Pagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pagos.ForeColor = System.Drawing.Color.White;
            this.Pagos.IconChar = FontAwesome.Sharp.IconChar.Bitcoin;
            this.Pagos.IconColor = System.Drawing.Color.White;
            this.Pagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Pagos.IconSize = 32;
            this.Pagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pagos.Location = new System.Drawing.Point(879, 217);
            this.Pagos.Name = "Pagos";
            this.Pagos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Pagos.Size = new System.Drawing.Size(170, 120);
            this.Pagos.TabIndex = 29;
            this.Pagos.Text = "Pagos";
            this.Pagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Pagos.UseVisualStyleBackColor = false;
            this.Pagos.Click += new System.EventHandler(this.Pagos_Click);
            // 
            // Empleados
            // 
            this.Empleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Empleados.BackColor = System.Drawing.Color.Red;
            this.Empleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Empleados.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Empleados.ForeColor = System.Drawing.Color.White;
            this.Empleados.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.Empleados.IconColor = System.Drawing.Color.White;
            this.Empleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Empleados.IconSize = 32;
            this.Empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Empleados.Location = new System.Drawing.Point(581, 217);
            this.Empleados.Name = "Empleados";
            this.Empleados.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Empleados.Size = new System.Drawing.Size(170, 120);
            this.Empleados.TabIndex = 30;
            this.Empleados.Text = "Empleados";
            this.Empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Empleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Empleados.UseVisualStyleBackColor = false;
            this.Empleados.Click += new System.EventHandler(this.Empleados_Click);
            // 
            // Compras
            // 
            this.Compras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Compras.BackColor = System.Drawing.Color.Red;
            this.Compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Compras.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Compras.ForeColor = System.Drawing.Color.White;
            this.Compras.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.Compras.IconColor = System.Drawing.Color.White;
            this.Compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Compras.IconSize = 32;
            this.Compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Compras.Location = new System.Drawing.Point(581, 30);
            this.Compras.Name = "Compras";
            this.Compras.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Compras.Size = new System.Drawing.Size(170, 120);
            this.Compras.TabIndex = 31;
            this.Compras.Text = "Compras";
            this.Compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Compras.UseVisualStyleBackColor = false;
            this.Compras.Click += new System.EventHandler(this.Compras_Click);
            // 
            // Ventas
            // 
            this.Ventas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ventas.BackColor = System.Drawing.Color.Red;
            this.Ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ventas.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ventas.ForeColor = System.Drawing.Color.White;
            this.Ventas.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.Ventas.IconColor = System.Drawing.Color.White;
            this.Ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ventas.IconSize = 32;
            this.Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ventas.Location = new System.Drawing.Point(289, 30);
            this.Ventas.Name = "Ventas";
            this.Ventas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Ventas.Size = new System.Drawing.Size(170, 120);
            this.Ventas.TabIndex = 33;
            this.Ventas.Text = "Ventas";
            this.Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ventas.UseVisualStyleBackColor = false;
            this.Ventas.Click += new System.EventHandler(this.Ventas_Click);
            // 
            // Clientes
            // 
            this.Clientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clientes.BackColor = System.Drawing.Color.Red;
            this.Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clientes.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clientes.ForeColor = System.Drawing.Color.White;
            this.Clientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.Clientes.IconColor = System.Drawing.Color.White;
            this.Clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Clientes.IconSize = 32;
            this.Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientes.Location = new System.Drawing.Point(289, 217);
            this.Clientes.Name = "Clientes";
            this.Clientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Clientes.Size = new System.Drawing.Size(170, 120);
            this.Clientes.TabIndex = 32;
            this.Clientes.Text = "Clientes";
            this.Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Clientes.UseVisualStyleBackColor = false;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Productos
            // 
            this.Productos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Productos.BackColor = System.Drawing.Color.Red;
            this.Productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Productos.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productos.ForeColor = System.Drawing.Color.White;
            this.Productos.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.Productos.IconColor = System.Drawing.Color.White;
            this.Productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Productos.IconSize = 32;
            this.Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Productos.Location = new System.Drawing.Point(879, 30);
            this.Productos.Name = "Productos";
            this.Productos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Productos.Size = new System.Drawing.Size(170, 120);
            this.Productos.TabIndex = 28;
            this.Productos.Text = "Productos";
            this.Productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Productos.UseVisualStyleBackColor = false;
            this.Productos.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Reportes
            // 
            this.Reportes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Reportes.BackColor = System.Drawing.Color.Red;
            this.Reportes.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportes.ForeColor = System.Drawing.Color.White;
            this.Reportes.IconChar = FontAwesome.Sharp.IconChar.Bullhorn;
            this.Reportes.IconColor = System.Drawing.Color.White;
            this.Reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Reportes.IconSize = 32;
            this.Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportes.Location = new System.Drawing.Point(1117, 433);
            this.Reportes.Name = "Reportes";
            this.Reportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Reportes.Size = new System.Drawing.Size(130, 60);
            this.Reportes.TabIndex = 34;
            this.Reportes.Text = "Reportes";
            this.Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reportes.UseVisualStyleBackColor = false;
            this.Reportes.Click += new System.EventHandler(this.Reportes_Click);
            // 
            // SubmenuReportes
            // 
            this.SubmenuReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmenuReportes.BackColor = System.Drawing.Color.Red;
            this.SubmenuReportes.Controls.Add(this.Reportecompras);
            this.SubmenuReportes.Controls.Add(this.Reportepagos);
            this.SubmenuReportes.Controls.Add(this.Reporteventas);
            this.SubmenuReportes.ForeColor = System.Drawing.Color.White;
            this.SubmenuReportes.Location = new System.Drawing.Point(1117, 499);
            this.SubmenuReportes.Name = "SubmenuReportes";
            this.SubmenuReportes.Size = new System.Drawing.Size(170, 104);
            this.SubmenuReportes.TabIndex = 27;
            this.SubmenuReportes.Visible = false;
            // 
            // Reportecompras
            // 
            this.Reportecompras.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Reportecompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Reportecompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportecompras.ForeColor = System.Drawing.Color.White;
            this.Reportecompras.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.Reportecompras.IconColor = System.Drawing.Color.White;
            this.Reportecompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Reportecompras.IconSize = 32;
            this.Reportecompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportecompras.Location = new System.Drawing.Point(1, 36);
            this.Reportecompras.Name = "Reportecompras";
            this.Reportecompras.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Reportecompras.Size = new System.Drawing.Size(165, 32);
            this.Reportecompras.TabIndex = 24;
            this.Reportecompras.Text = "Reporte de compras";
            this.Reportecompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportecompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reportecompras.UseVisualStyleBackColor = true;
            this.Reportecompras.Click += new System.EventHandler(this.Reportecompras_Click);
            // 
            // Reportepagos
            // 
            this.Reportepagos.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Reportepagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Reportepagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportepagos.ForeColor = System.Drawing.Color.White;
            this.Reportepagos.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.Reportepagos.IconColor = System.Drawing.Color.White;
            this.Reportepagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Reportepagos.IconSize = 32;
            this.Reportepagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportepagos.Location = new System.Drawing.Point(1, 69);
            this.Reportepagos.Name = "Reportepagos";
            this.Reportepagos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Reportepagos.Size = new System.Drawing.Size(165, 32);
            this.Reportepagos.TabIndex = 23;
            this.Reportepagos.Text = "Reporte de Pagos";
            this.Reportepagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportepagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reportepagos.UseVisualStyleBackColor = true;
            this.Reportepagos.Click += new System.EventHandler(this.Reportepagos_Click);
            // 
            // Reporteventas
            // 
            this.Reporteventas.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Reporteventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Reporteventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reporteventas.ForeColor = System.Drawing.Color.White;
            this.Reporteventas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.Reporteventas.IconColor = System.Drawing.Color.White;
            this.Reporteventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Reporteventas.IconSize = 32;
            this.Reporteventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reporteventas.Location = new System.Drawing.Point(1, 3);
            this.Reporteventas.Name = "Reporteventas";
            this.Reporteventas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Reporteventas.Size = new System.Drawing.Size(165, 32);
            this.Reporteventas.TabIndex = 22;
            this.Reporteventas.Text = "Reporte de Ventas";
            this.Reporteventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reporteventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reporteventas.UseVisualStyleBackColor = true;
            this.Reporteventas.Click += new System.EventHandler(this.Reporteventas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::besthelpsystem.Properties.Resources.logoHealth;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 615);
            this.panel1.TabIndex = 36;
            // 
            // A1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panelcontenedor);
            this.Controls.Add(this.Barratitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "A1";
            this.Text = "Besthelp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.A1_Resize);
            this.Barratitulo.ResumeLayout(false);
            this.Barratitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconodeformulario)).EndInit();
            this.Panelcontenedor.ResumeLayout(false);
            this.SubmenuReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Barratitulo;
        private Panel Panelcontenedor;
        private Button Btncerrar;
        private Button Btnmaximizar;
        private Button Btnminimizar;
        private FontAwesome.Sharp.IconPictureBox iconodeformulario;
        private Label titulodeformulario;
        private FontAwesome.Sharp.IconButton Reportes;
        private FontAwesome.Sharp.IconButton Pagos;
        private FontAwesome.Sharp.IconButton Empleados;
        private FontAwesome.Sharp.IconButton Compras;
        private FontAwesome.Sharp.IconButton Ventas;
        private FontAwesome.Sharp.IconButton Clientes;
        private FontAwesome.Sharp.IconButton Productos;
        private Panel SubmenuReportes;
        private FontAwesome.Sharp.IconButton Reportecompras;
        private FontAwesome.Sharp.IconButton Reportepagos;
        private FontAwesome.Sharp.IconButton Reporteventas;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}