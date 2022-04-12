namespace HMI_V2.Formularios
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.BarraHerramientas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrarPrograma = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PortSerial4 = new System.Windows.Forms.ComboBox();
            this.PortSerial3 = new System.Windows.Forms.ComboBox();
            this.PortSerial2 = new System.Windows.Forms.ComboBox();
            this.PortSerial1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Conect4 = new HMI_V2.Controles.EllipseButton();
            this.BaudRate4 = new System.Windows.Forms.ComboBox();
            this.ellipseControls4 = new HMI_V2.Controles.EllipseControls();
            this.label5 = new System.Windows.Forms.Label();
            this.Conect3 = new HMI_V2.Controles.EllipseButton();
            this.BaudRate3 = new System.Windows.Forms.ComboBox();
            this.ellipseControls5 = new HMI_V2.Controles.EllipseControls();
            this.label1 = new System.Windows.Forms.Label();
            this.Conect2 = new HMI_V2.Controles.EllipseButton();
            this.BaudRate2 = new System.Windows.Forms.ComboBox();
            this.ellipseControls3 = new HMI_V2.Controles.EllipseControls();
            this.label3 = new System.Windows.Forms.Label();
            this.Conect1 = new HMI_V2.Controles.EllipseButton();
            this.BaudRate1 = new System.Windows.Forms.ComboBox();
            this.ellipseControls1 = new HMI_V2.Controles.EllipseControls();
            this.ellipseControls2 = new HMI_V2.Controles.EllipseControls();
            this.ellipseComponents1 = new HMI_V2.Componentes.EllipseComponents();
            this.BarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.BarraHerramientas.Controls.Add(this.label2);
            this.BarraHerramientas.Controls.Add(this.pictureBox1);
            this.BarraHerramientas.Controls.Add(this.btnMinimizar);
            this.BarraHerramientas.Controls.Add(this.btnCerrarPrograma);
            this.BarraHerramientas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(900, 40);
            this.BarraHerramientas.TabIndex = 1;
            this.BarraHerramientas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraHerramientas_MouseDown);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(731, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Configuración";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraHerramientas_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraHerramientas_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(820, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.Text = "__";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrarPrograma
            // 
            this.btnCerrarPrograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarPrograma.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarPrograma.FlatAppearance.BorderSize = 0;
            this.btnCerrarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPrograma.Location = new System.Drawing.Point(860, 0);
            this.btnCerrarPrograma.Name = "btnCerrarPrograma";
            this.btnCerrarPrograma.Size = new System.Drawing.Size(40, 40);
            this.btnCerrarPrograma.TabIndex = 0;
            this.btnCerrarPrograma.Text = "X";
            this.btnCerrarPrograma.UseVisualStyleBackColor = true;
            this.btnCerrarPrograma.Click += new System.EventHandler(this.btnCerrarPrograma_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PortSerial4);
            this.panel1.Controls.Add(this.PortSerial3);
            this.panel1.Controls.Add(this.PortSerial2);
            this.panel1.Controls.Add(this.PortSerial1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Conect4);
            this.panel1.Controls.Add(this.BaudRate4);
            this.panel1.Controls.Add(this.ellipseControls4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Conect3);
            this.panel1.Controls.Add(this.BaudRate3);
            this.panel1.Controls.Add(this.ellipseControls5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Conect2);
            this.panel1.Controls.Add(this.BaudRate2);
            this.panel1.Controls.Add(this.ellipseControls3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Conect1);
            this.panel1.Controls.Add(this.BaudRate1);
            this.panel1.Controls.Add(this.ellipseControls1);
            this.panel1.Controls.Add(this.ellipseControls2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30);
            this.panel1.Size = new System.Drawing.Size(900, 329);
            this.panel1.TabIndex = 3;
            // 
            // PortSerial4
            // 
            this.PortSerial4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PortSerial4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortSerial4.FormattingEnabled = true;
            this.PortSerial4.Location = new System.Drawing.Point(681, 111);
            this.PortSerial4.Margin = new System.Windows.Forms.Padding(5);
            this.PortSerial4.Name = "PortSerial4";
            this.PortSerial4.Size = new System.Drawing.Size(139, 33);
            this.PortSerial4.TabIndex = 30;
            this.PortSerial4.Text = "No Serial";
            // 
            // PortSerial3
            // 
            this.PortSerial3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PortSerial3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortSerial3.FormattingEnabled = true;
            this.PortSerial3.Location = new System.Drawing.Point(478, 111);
            this.PortSerial3.Margin = new System.Windows.Forms.Padding(5);
            this.PortSerial3.Name = "PortSerial3";
            this.PortSerial3.Size = new System.Drawing.Size(139, 33);
            this.PortSerial3.TabIndex = 29;
            this.PortSerial3.Text = "No Serial";
            // 
            // PortSerial2
            // 
            this.PortSerial2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PortSerial2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortSerial2.FormattingEnabled = true;
            this.PortSerial2.Location = new System.Drawing.Point(275, 111);
            this.PortSerial2.Margin = new System.Windows.Forms.Padding(5);
            this.PortSerial2.Name = "PortSerial2";
            this.PortSerial2.Size = new System.Drawing.Size(139, 33);
            this.PortSerial2.TabIndex = 28;
            this.PortSerial2.Text = "No Serial";
            // 
            // PortSerial1
            // 
            this.PortSerial1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PortSerial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortSerial1.FormattingEnabled = true;
            this.PortSerial1.Location = new System.Drawing.Point(72, 111);
            this.PortSerial1.Margin = new System.Windows.Forms.Padding(5);
            this.PortSerial1.Name = "PortSerial1";
            this.PortSerial1.Size = new System.Drawing.Size(139, 33);
            this.PortSerial1.TabIndex = 27;
            this.PortSerial1.Text = "No Serial";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(682, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 36);
            this.label4.TabIndex = 26;
            this.label4.Text = "Serial Port 4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Conect4
            // 
            this.Conect4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Conect4.BackColor = System.Drawing.Color.Yellow;
            this.Conect4.BackgroundColor = System.Drawing.Color.Yellow;
            this.Conect4.BorderColor1 = System.Drawing.Color.Black;
            this.Conect4.BorderRadius1 = 20;
            this.Conect4.BorderSize1 = 0;
            this.Conect4.FlatAppearance.BorderSize = 0;
            this.Conect4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Conect4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conect4.ForeColor = System.Drawing.Color.Black;
            this.Conect4.Location = new System.Drawing.Point(682, 207);
            this.Conect4.Margin = new System.Windows.Forms.Padding(20);
            this.Conect4.Name = "Conect4";
            this.Conect4.Size = new System.Drawing.Size(139, 49);
            this.Conect4.TabIndex = 25;
            this.Conect4.Text = "Refrescar";
            this.Conect4.TextColor = System.Drawing.Color.Black;
            this.Conect4.UseVisualStyleBackColor = false;
            this.Conect4.Click += new System.EventHandler(this.Conect4_Click);
            // 
            // BaudRate4
            // 
            this.BaudRate4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BaudRate4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRate4.FormattingEnabled = true;
            this.BaudRate4.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "28800",
            "57600",
            "115200"});
            this.BaudRate4.Location = new System.Drawing.Point(682, 158);
            this.BaudRate4.Margin = new System.Windows.Forms.Padding(20);
            this.BaudRate4.Name = "BaudRate4";
            this.BaudRate4.Size = new System.Drawing.Size(139, 33);
            this.BaudRate4.TabIndex = 24;
            this.BaudRate4.Text = "115200";
            // 
            // ellipseControls4
            // 
            this.ellipseControls4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ellipseControls4.BackColor = System.Drawing.SystemColors.Control;
            this.ellipseControls4.CornerRadius = 70;
            this.ellipseControls4.Location = new System.Drawing.Point(668, 53);
            this.ellipseControls4.Margin = new System.Windows.Forms.Padding(30, 50, 50, 50);
            this.ellipseControls4.Name = "ellipseControls4";
            this.ellipseControls4.Size = new System.Drawing.Size(173, 217);
            this.ellipseControls4.TabIndex = 23;
            this.ellipseControls4.Text = "ellipseControls4";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(479, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 36);
            this.label5.TabIndex = 22;
            this.label5.Text = "Serial Port 3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Conect3
            // 
            this.Conect3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Conect3.BackColor = System.Drawing.Color.Yellow;
            this.Conect3.BackgroundColor = System.Drawing.Color.Yellow;
            this.Conect3.BorderColor1 = System.Drawing.Color.Black;
            this.Conect3.BorderRadius1 = 20;
            this.Conect3.BorderSize1 = 0;
            this.Conect3.FlatAppearance.BorderSize = 0;
            this.Conect3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Conect3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conect3.ForeColor = System.Drawing.Color.Black;
            this.Conect3.Location = new System.Drawing.Point(479, 207);
            this.Conect3.Margin = new System.Windows.Forms.Padding(20);
            this.Conect3.Name = "Conect3";
            this.Conect3.Size = new System.Drawing.Size(139, 49);
            this.Conect3.TabIndex = 21;
            this.Conect3.Text = "Refrescar";
            this.Conect3.TextColor = System.Drawing.Color.Black;
            this.Conect3.UseVisualStyleBackColor = false;
            this.Conect3.Click += new System.EventHandler(this.Conect3_Click);
            // 
            // BaudRate3
            // 
            this.BaudRate3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BaudRate3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRate3.FormattingEnabled = true;
            this.BaudRate3.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "28800",
            "57600",
            "115200"});
            this.BaudRate3.Location = new System.Drawing.Point(479, 158);
            this.BaudRate3.Margin = new System.Windows.Forms.Padding(20);
            this.BaudRate3.Name = "BaudRate3";
            this.BaudRate3.Size = new System.Drawing.Size(139, 33);
            this.BaudRate3.TabIndex = 20;
            this.BaudRate3.Text = "115200";
            // 
            // ellipseControls5
            // 
            this.ellipseControls5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ellipseControls5.BackColor = System.Drawing.SystemColors.Control;
            this.ellipseControls5.CornerRadius = 70;
            this.ellipseControls5.Location = new System.Drawing.Point(465, 53);
            this.ellipseControls5.Margin = new System.Windows.Forms.Padding(30, 50, 50, 50);
            this.ellipseControls5.Name = "ellipseControls5";
            this.ellipseControls5.Size = new System.Drawing.Size(173, 217);
            this.ellipseControls5.TabIndex = 19;
            this.ellipseControls5.Text = "ellipseControls5";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Serial Port 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Conect2
            // 
            this.Conect2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Conect2.BackColor = System.Drawing.Color.Yellow;
            this.Conect2.BackgroundColor = System.Drawing.Color.Yellow;
            this.Conect2.BorderColor1 = System.Drawing.Color.Black;
            this.Conect2.BorderRadius1 = 20;
            this.Conect2.BorderSize1 = 0;
            this.Conect2.FlatAppearance.BorderSize = 0;
            this.Conect2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Conect2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conect2.ForeColor = System.Drawing.Color.Black;
            this.Conect2.Location = new System.Drawing.Point(276, 207);
            this.Conect2.Margin = new System.Windows.Forms.Padding(20);
            this.Conect2.Name = "Conect2";
            this.Conect2.Size = new System.Drawing.Size(139, 49);
            this.Conect2.TabIndex = 17;
            this.Conect2.Text = "Refrescar";
            this.Conect2.TextColor = System.Drawing.Color.Black;
            this.Conect2.UseVisualStyleBackColor = false;
            this.Conect2.Click += new System.EventHandler(this.Conect2_Click);
            // 
            // BaudRate2
            // 
            this.BaudRate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BaudRate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRate2.FormattingEnabled = true;
            this.BaudRate2.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "28800",
            "57600",
            "115200"});
            this.BaudRate2.Location = new System.Drawing.Point(276, 158);
            this.BaudRate2.Margin = new System.Windows.Forms.Padding(20);
            this.BaudRate2.Name = "BaudRate2";
            this.BaudRate2.Size = new System.Drawing.Size(139, 33);
            this.BaudRate2.TabIndex = 16;
            this.BaudRate2.Text = "115200";
            // 
            // ellipseControls3
            // 
            this.ellipseControls3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ellipseControls3.BackColor = System.Drawing.SystemColors.Control;
            this.ellipseControls3.CornerRadius = 70;
            this.ellipseControls3.Location = new System.Drawing.Point(262, 53);
            this.ellipseControls3.Margin = new System.Windows.Forms.Padding(30, 50, 50, 50);
            this.ellipseControls3.Name = "ellipseControls3";
            this.ellipseControls3.Size = new System.Drawing.Size(173, 217);
            this.ellipseControls3.TabIndex = 15;
            this.ellipseControls3.Text = "ellipseControls3";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "Serial Port 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Conect1
            // 
            this.Conect1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Conect1.BackColor = System.Drawing.Color.Yellow;
            this.Conect1.BackgroundColor = System.Drawing.Color.Yellow;
            this.Conect1.BorderColor1 = System.Drawing.Color.Black;
            this.Conect1.BorderRadius1 = 20;
            this.Conect1.BorderSize1 = 0;
            this.Conect1.FlatAppearance.BorderSize = 0;
            this.Conect1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Conect1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conect1.ForeColor = System.Drawing.Color.Black;
            this.Conect1.Location = new System.Drawing.Point(73, 207);
            this.Conect1.Margin = new System.Windows.Forms.Padding(20);
            this.Conect1.Name = "Conect1";
            this.Conect1.Size = new System.Drawing.Size(139, 49);
            this.Conect1.TabIndex = 13;
            this.Conect1.Text = "Refrescar";
            this.Conect1.TextColor = System.Drawing.Color.Black;
            this.Conect1.UseVisualStyleBackColor = false;
            this.Conect1.Click += new System.EventHandler(this.Conect1_Click);
            // 
            // BaudRate1
            // 
            this.BaudRate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BaudRate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRate1.FormattingEnabled = true;
            this.BaudRate1.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "28800",
            "57600",
            "115200"});
            this.BaudRate1.Location = new System.Drawing.Point(73, 158);
            this.BaudRate1.Margin = new System.Windows.Forms.Padding(20);
            this.BaudRate1.Name = "BaudRate1";
            this.BaudRate1.Size = new System.Drawing.Size(139, 33);
            this.BaudRate1.TabIndex = 12;
            this.BaudRate1.Text = "115200";
            // 
            // ellipseControls1
            // 
            this.ellipseControls1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ellipseControls1.BackColor = System.Drawing.SystemColors.Control;
            this.ellipseControls1.CornerRadius = 70;
            this.ellipseControls1.Location = new System.Drawing.Point(59, 53);
            this.ellipseControls1.Margin = new System.Windows.Forms.Padding(50);
            this.ellipseControls1.Name = "ellipseControls1";
            this.ellipseControls1.Size = new System.Drawing.Size(173, 217);
            this.ellipseControls1.TabIndex = 11;
            this.ellipseControls1.Text = "ellipseControls1";
            // 
            // ellipseControls2
            // 
            this.ellipseControls2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.ellipseControls2.CornerRadius = 70;
            this.ellipseControls2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ellipseControls2.Location = new System.Drawing.Point(30, 30);
            this.ellipseControls2.Name = "ellipseControls2";
            this.ellipseControls2.Size = new System.Drawing.Size(840, 269);
            this.ellipseControls2.TabIndex = 10;
            this.ellipseControls2.Text = "ellipseControls2";
            // 
            // ellipseComponents1
            // 
            this.ellipseComponents1.CornerRadius = 60;
            this.ellipseComponents1.TargetControl = this;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraHerramientas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Config_MouseDown);
            this.BarraHerramientas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Componentes.EllipseComponents ellipseComponents1;
        private System.Windows.Forms.Panel BarraHerramientas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrarPrograma;
        private System.Windows.Forms.Panel panel1;
        private Controles.EllipseControls ellipseControls2;
        private System.Windows.Forms.Label label4;
        private Controles.EllipseButton Conect4;
        private System.Windows.Forms.ComboBox BaudRate4;
        private Controles.EllipseControls ellipseControls4;
        private System.Windows.Forms.Label label5;
        private Controles.EllipseButton Conect3;
        private System.Windows.Forms.ComboBox BaudRate3;
        private Controles.EllipseControls ellipseControls5;
        private System.Windows.Forms.Label label1;
        private Controles.EllipseButton Conect2;
        private System.Windows.Forms.ComboBox BaudRate2;
        private Controles.EllipseControls ellipseControls3;
        private System.Windows.Forms.Label label3;
        private Controles.EllipseButton Conect1;
        private System.Windows.Forms.ComboBox BaudRate1;
        private Controles.EllipseControls ellipseControls1;
        private System.Windows.Forms.ComboBox PortSerial4;
        private System.Windows.Forms.ComboBox PortSerial3;
        private System.Windows.Forms.ComboBox PortSerial2;
        private System.Windows.Forms.ComboBox PortSerial1;
    }
}