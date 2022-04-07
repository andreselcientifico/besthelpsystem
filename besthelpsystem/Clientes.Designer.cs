namespace besthelpsystem
{
    partial class Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pgdeuda = new System.Windows.Forms.TextBox();
            this.labelPgdeuda = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.labeltelefono = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.labeldireccion = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nmbcompleto = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.Pagosdeuda = new System.Windows.Forms.RadioButton();
            this.Ingresarcliente = new System.Windows.Forms.RadioButton();
            this.labelapellido = new System.Windows.Forms.Label();
            this.labelnmbcompleto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabladedatos = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.telefono1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabladedatos)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Buscar.Location = new System.Drawing.Point(351, 9);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(286, 21);
            this.Buscar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Buscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 40);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(643, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(299, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.iconButton3);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.pgdeuda);
            this.panel2.Controls.Add(this.labelPgdeuda);
            this.panel2.Controls.Add(this.telefono);
            this.panel2.Controls.Add(this.labeltelefono);
            this.panel2.Controls.Add(this.direccion);
            this.panel2.Controls.Add(this.labeldireccion);
            this.panel2.Controls.Add(this.apellido);
            this.panel2.Controls.Add(this.nmbcompleto);
            this.panel2.Controls.Add(this.id);
            this.panel2.Controls.Add(this.Pagosdeuda);
            this.panel2.Controls.Add(this.Ingresarcliente);
            this.panel2.Controls.Add(this.labelapellido);
            this.panel2.Controls.Add(this.labelnmbcompleto);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.labelid);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 575);
            this.panel2.TabIndex = 3;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton3.IconColor = System.Drawing.Color.Red;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 24;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(88, 493);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(80, 40);
            this.iconButton3.TabIndex = 24;
            this.iconButton3.Text = "Eliminar";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton2.IconColor = System.Drawing.Color.Red;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(172, 493);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(80, 40);
            this.iconButton2.TabIndex = 23;
            this.iconButton2.Text = "Cancelar";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButton1.IconColor = System.Drawing.Color.Lime;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(4, 493);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(80, 40);
            this.iconButton1.TabIndex = 22;
            this.iconButton1.Text = "Guardar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pgdeuda
            // 
            this.pgdeuda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pgdeuda.Location = new System.Drawing.Point(11, 428);
            this.pgdeuda.Name = "pgdeuda";
            this.pgdeuda.Size = new System.Drawing.Size(220, 26);
            this.pgdeuda.TabIndex = 21;
            this.pgdeuda.TextChanged += new System.EventHandler(this.pgdeuda_TextChanged);
            this.pgdeuda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pgdeuda_KeyPress);
            // 
            // labelPgdeuda
            // 
            this.labelPgdeuda.AutoSize = true;
            this.labelPgdeuda.BackColor = System.Drawing.Color.Transparent;
            this.labelPgdeuda.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPgdeuda.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelPgdeuda.Location = new System.Drawing.Point(12, 407);
            this.labelPgdeuda.Name = "labelPgdeuda";
            this.labelPgdeuda.Size = new System.Drawing.Size(131, 18);
            this.labelPgdeuda.TabIndex = 20;
            this.labelPgdeuda.Text = "Pagos de deudas";
            // 
            // telefono
            // 
            this.telefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.telefono.Location = new System.Drawing.Point(11, 378);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(220, 26);
            this.telefono.TabIndex = 19;
            this.telefono.TextChanged += new System.EventHandler(this.telefono_TextChanged);
            this.telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefono_KeyPress);
            // 
            // labeltelefono
            // 
            this.labeltelefono.AutoSize = true;
            this.labeltelefono.BackColor = System.Drawing.Color.Transparent;
            this.labeltelefono.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeltelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labeltelefono.Location = new System.Drawing.Point(12, 357);
            this.labeltelefono.Name = "labeltelefono";
            this.labeltelefono.Size = new System.Drawing.Size(70, 18);
            this.labeltelefono.TabIndex = 18;
            this.labeltelefono.Text = "Telefono";
            // 
            // direccion
            // 
            this.direccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.direccion.Location = new System.Drawing.Point(11, 328);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(220, 26);
            this.direccion.TabIndex = 17;
            this.direccion.TextChanged += new System.EventHandler(this.direccion_TextChanged);
            this.direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.direccion_KeyPress);
            // 
            // labeldireccion
            // 
            this.labeldireccion.AutoSize = true;
            this.labeldireccion.BackColor = System.Drawing.Color.Transparent;
            this.labeldireccion.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeldireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labeldireccion.Location = new System.Drawing.Point(11, 307);
            this.labeldireccion.Name = "labeldireccion";
            this.labeldireccion.Size = new System.Drawing.Size(77, 18);
            this.labeldireccion.TabIndex = 16;
            this.labeldireccion.Text = "Direccion";
            // 
            // apellido
            // 
            this.apellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apellido.Location = new System.Drawing.Point(11, 278);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(220, 26);
            this.apellido.TabIndex = 15;
            this.apellido.TextChanged += new System.EventHandler(this.apellido_TextChanged);
            this.apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellido_KeyPress);
            // 
            // nmbcompleto
            // 
            this.nmbcompleto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmbcompleto.Location = new System.Drawing.Point(12, 228);
            this.nmbcompleto.Name = "nmbcompleto";
            this.nmbcompleto.Size = new System.Drawing.Size(220, 26);
            this.nmbcompleto.TabIndex = 14;
            this.nmbcompleto.TextChanged += new System.EventHandler(this.nmbcompleto_TextChanged);
            this.nmbcompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmbcompleto_KeyPress);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id.Location = new System.Drawing.Point(12, 178);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(220, 26);
            this.id.TabIndex = 13;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // Pagosdeuda
            // 
            this.Pagosdeuda.AutoSize = true;
            this.Pagosdeuda.Location = new System.Drawing.Point(129, 65);
            this.Pagosdeuda.Name = "Pagosdeuda";
            this.Pagosdeuda.Size = new System.Drawing.Size(123, 19);
            this.Pagosdeuda.TabIndex = 12;
            this.Pagosdeuda.TabStop = true;
            this.Pagosdeuda.Text = "Pagos de deudas";
            this.Pagosdeuda.UseVisualStyleBackColor = true;
            this.Pagosdeuda.CheckedChanged += new System.EventHandler(this.Pagosdeuda_CheckedChanged);
            // 
            // Ingresarcliente
            // 
            this.Ingresarcliente.AutoSize = true;
            this.Ingresarcliente.Location = new System.Drawing.Point(11, 65);
            this.Ingresarcliente.Name = "Ingresarcliente";
            this.Ingresarcliente.Size = new System.Drawing.Size(113, 19);
            this.Ingresarcliente.TabIndex = 11;
            this.Ingresarcliente.TabStop = true;
            this.Ingresarcliente.Text = "Ingresar Cliente";
            this.Ingresarcliente.UseVisualStyleBackColor = true;
            this.Ingresarcliente.CheckedChanged += new System.EventHandler(this.Ingresarcliente_CheckedChanged);
            // 
            // labelapellido
            // 
            this.labelapellido.AutoSize = true;
            this.labelapellido.BackColor = System.Drawing.Color.Transparent;
            this.labelapellido.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelapellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelapellido.Location = new System.Drawing.Point(11, 257);
            this.labelapellido.Name = "labelapellido";
            this.labelapellido.Size = new System.Drawing.Size(66, 18);
            this.labelapellido.TabIndex = 7;
            this.labelapellido.Text = "Apellido";
            // 
            // labelnmbcompleto
            // 
            this.labelnmbcompleto.AutoSize = true;
            this.labelnmbcompleto.BackColor = System.Drawing.Color.Transparent;
            this.labelnmbcompleto.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelnmbcompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelnmbcompleto.Location = new System.Drawing.Point(12, 207);
            this.labelnmbcompleto.Name = "labelnmbcompleto";
            this.labelnmbcompleto.Size = new System.Drawing.Size(138, 18);
            this.labelnmbcompleto.TabIndex = 5;
            this.labelnmbcompleto.Text = "Nombre Completo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Informacion del nuevo Cliente";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.BackColor = System.Drawing.Color.Transparent;
            this.labelid.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelid.Location = new System.Drawing.Point(12, 157);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(23, 18);
            this.labelid.TabIndex = 1;
            this.labelid.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Configuraciones de Cliente";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tabladedatos);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(259, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(821, 575);
            this.panel3.TabIndex = 4;
            // 
            // tabladedatos
            // 
            this.tabladedatos.AllowUserToAddRows = false;
            this.tabladedatos.AllowUserToDeleteRows = false;
            this.tabladedatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabladedatos.AutoGenerateColumns = false;
            this.tabladedatos.BackgroundColor = System.Drawing.Color.White;
            this.tabladedatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabladedatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1DataGridViewTextBoxColumn,
            this.nombre1DataGridViewTextBoxColumn,
            this.apellido1DataGridViewTextBoxColumn,
            this.direccion1DataGridViewTextBoxColumn,
            this.telefono1DataGridViewTextBoxColumn});
            this.tabladedatos.DataSource = this.clientesBindingSource;
            this.tabladedatos.Location = new System.Drawing.Point(0, 0);
            this.tabladedatos.Name = "tabladedatos";
            this.tabladedatos.ReadOnly = true;
            this.tabladedatos.RowTemplate.Height = 25;
            this.tabladedatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabladedatos.Size = new System.Drawing.Size(820, 315);
            this.tabladedatos.TabIndex = 17;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(615, 329);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 60);
            this.button8.TabIndex = 15;
            this.button8.Text = "Imprimir";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(469, 339);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 50);
            this.button7.TabIndex = 14;
            this.button7.Text = "Ultimo";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(383, 339);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 50);
            this.button6.TabIndex = 13;
            this.button6.Text = "Siguiente";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(352, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Paginas";
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(296, 339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 50);
            this.button5.TabIndex = 12;
            this.button5.Text = "Anterior";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(210, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 50);
            this.button4.TabIndex = 11;
            this.button4.Text = "Primero";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.listView2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 395);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(819, 178);
            this.panel4.TabIndex = 0;
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView2.Location = new System.Drawing.Point(0, 39);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(495, 137);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(495, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(322, 176);
            this.panel5.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(171, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 19);
            this.label13.TabIndex = 4;
            this.label13.Text = "Reportes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::besthelpsystem.Properties.Resources.Sin_título_31;
            this.pictureBox1.Location = new System.Drawing.Point(255, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // telefono1DataGridViewTextBoxColumn
            // 
            this.telefono1DataGridViewTextBoxColumn.DataPropertyName = "Telefono1";
            this.telefono1DataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefono1DataGridViewTextBoxColumn.Name = "telefono1DataGridViewTextBoxColumn";
            this.telefono1DataGridViewTextBoxColumn.ReadOnly = true;
            this.telefono1DataGridViewTextBoxColumn.Width = 200;
            // 
            // direccion1DataGridViewTextBoxColumn
            // 
            this.direccion1DataGridViewTextBoxColumn.DataPropertyName = "Direccion1";
            this.direccion1DataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccion1DataGridViewTextBoxColumn.Name = "direccion1DataGridViewTextBoxColumn";
            this.direccion1DataGridViewTextBoxColumn.ReadOnly = true;
            this.direccion1DataGridViewTextBoxColumn.Width = 200;
            // 
            // apellido1DataGridViewTextBoxColumn
            // 
            this.apellido1DataGridViewTextBoxColumn.DataPropertyName = "Apellido1";
            this.apellido1DataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellido1DataGridViewTextBoxColumn.Name = "apellido1DataGridViewTextBoxColumn";
            this.apellido1DataGridViewTextBoxColumn.ReadOnly = true;
            this.apellido1DataGridViewTextBoxColumn.Width = 200;
            // 
            // nombre1DataGridViewTextBoxColumn
            // 
            this.nombre1DataGridViewTextBoxColumn.DataPropertyName = "Nombre1";
            this.nombre1DataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombre1DataGridViewTextBoxColumn.Name = "nombre1DataGridViewTextBoxColumn";
            this.nombre1DataGridViewTextBoxColumn.ReadOnly = true;
            this.nombre1DataGridViewTextBoxColumn.Width = 200;
            // 
            // id1DataGridViewTextBoxColumn
            // 
            this.id1DataGridViewTextBoxColumn.DataPropertyName = "Id1";
            this.id1DataGridViewTextBoxColumn.HeaderText = "Id1";
            this.id1DataGridViewTextBoxColumn.Name = "id1DataGridViewTextBoxColumn";
            this.id1DataGridViewTextBoxColumn.ReadOnly = true;
            this.id1DataGridViewTextBoxColumn.Visible = false;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(besthelpsystem.Models.Clientes);
            // 
            // Clientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Clientes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ventas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabladedatos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox Buscar;
        private Panel panel1;
        private Button button1;
        private Label label2;
        private Panel panel2;
        private Label labelapellido;
        private Label labelnmbcompleto;
        private Label label5;
        private Label labelid;
        private Label label3;
        private Panel panel3;
        private Button button8;
        private Button button7;
        private Button button6;
        private Label label11;
        private Button button5;
        private Button button4;
        private Panel panel4;
        private ListView listView2;
        private Panel panel5;
        private Label label13;
        private PictureBox pictureBox1;
        private RadioButton Pagosdeuda;
        private RadioButton Ingresarcliente;
        private Label labelPgdeuda;
        private TextBox telefono;
        private Label labeltelefono;
        private TextBox direccion;
        private Label labeldireccion;
        private TextBox apellido;
        private TextBox nmbcompleto;
        private TextBox id;
        private TextBox pgdeuda;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridView tabladedatos;
        private DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn id1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombre1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellido1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccion1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefono1DataGridViewTextBoxColumn;
        private BindingSource clientesBindingSource;
    }
}