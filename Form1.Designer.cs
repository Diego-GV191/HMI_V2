namespace HMI_V2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraHerramientas = new System.Windows.Forms.Panel();
            this.btnConfigVar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrarPrograma = new System.Windows.Forms.Button();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.btnConfig = new HMI_V2.Controles.EllipseButton();
            this.ControlConfiguracion = new HMI_V2.Controles.EllipseControls();
            this.ellipseControls6 = new HMI_V2.Controles.EllipseControls();
            this.ellipseControls7 = new HMI_V2.Controles.EllipseControls();
            this.ellipseControls8 = new HMI_V2.Controles.EllipseControls();
            this.ellipseControls3 = new HMI_V2.Controles.EllipseControls();
            this.ellipseControls4 = new HMI_V2.Controles.EllipseControls();
            this.ellipseControls2 = new HMI_V2.Controles.EllipseControls();
            this.ellipseControls1 = new HMI_V2.Controles.EllipseControls();
            this.PanelOpciones = new HMI_V2.Controles.EllipseControls();
            this.ellipseComponents1 = new HMI_V2.Componentes.EllipseComponents();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort4 = new System.IO.Ports.SerialPort(this.components);
            this.BarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.BarraHerramientas.Controls.Add(this.btnConfigVar);
            this.BarraHerramientas.Controls.Add(this.label1);
            this.BarraHerramientas.Controls.Add(this.pictureBox1);
            this.BarraHerramientas.Controls.Add(this.btnMinimizar);
            this.BarraHerramientas.Controls.Add(this.btnCerrarPrograma);
            this.BarraHerramientas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(800, 40);
            this.BarraHerramientas.TabIndex = 0;
            this.BarraHerramientas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnConfigVar
            // 
            this.btnConfigVar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfigVar.FlatAppearance.BorderSize = 0;
            this.btnConfigVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigVar.Image = global::HMI_V2.Properties.Resources.ajustes_de_engranajes;
            this.btnConfigVar.Location = new System.Drawing.Point(680, 0);
            this.btnConfigVar.Name = "btnConfigVar";
            this.btnConfigVar.Size = new System.Drawing.Size(40, 40);
            this.btnConfigVar.TabIndex = 4;
            this.btnConfigVar.UseVisualStyleBackColor = true;
            this.btnConfigVar.Click += new System.EventHandler(this.btnConfigVar_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
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
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(720, 0);
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
            this.btnCerrarPrograma.Location = new System.Drawing.Point(760, 0);
            this.btnCerrarPrograma.Name = "btnCerrarPrograma";
            this.btnCerrarPrograma.Size = new System.Drawing.Size(40, 40);
            this.btnCerrarPrograma.TabIndex = 0;
            this.btnCerrarPrograma.Text = "X";
            this.btnCerrarPrograma.UseVisualStyleBackColor = true;
            this.btnCerrarPrograma.Click += new System.EventHandler(this.btnCerrarPrograma_Click);
            // 
            // panelInicio
            // 
            this.panelInicio.Controls.Add(this.btnConfig);
            this.panelInicio.Controls.Add(this.ControlConfiguracion);
            this.panelInicio.Controls.Add(this.ellipseControls6);
            this.panelInicio.Controls.Add(this.ellipseControls7);
            this.panelInicio.Controls.Add(this.ellipseControls8);
            this.panelInicio.Controls.Add(this.ellipseControls3);
            this.panelInicio.Controls.Add(this.ellipseControls4);
            this.panelInicio.Controls.Add(this.ellipseControls2);
            this.panelInicio.Controls.Add(this.ellipseControls1);
            this.panelInicio.Controls.Add(this.PanelOpciones);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicio.Location = new System.Drawing.Point(0, 40);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Padding = new System.Windows.Forms.Padding(30);
            this.panelInicio.Size = new System.Drawing.Size(800, 443);
            this.panelInicio.TabIndex = 2;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnConfig.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnConfig.BorderRadius1 = 10;
            this.btnConfig.BorderSize1 = 0;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Image = global::HMI_V2.Properties.Resources.ajustes_de_engranajes__2_;
            this.btnConfig.Location = new System.Drawing.Point(577, 228);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(150, 150);
            this.btnConfig.TabIndex = 12;
            this.btnConfig.TextColor = System.Drawing.Color.White;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // ControlConfiguracion
            // 
            this.ControlConfiguracion.CornerRadius = 30;
            this.ControlConfiguracion.Location = new System.Drawing.Point(577, 228);
            this.ControlConfiguracion.Margin = new System.Windows.Forms.Padding(10);
            this.ControlConfiguracion.Name = "ControlConfiguracion";
            this.ControlConfiguracion.Size = new System.Drawing.Size(150, 150);
            this.ControlConfiguracion.TabIndex = 9;
            this.ControlConfiguracion.Text = "ellipseControls5";
            // 
            // ellipseControls6
            // 
            this.ellipseControls6.CornerRadius = 30;
            this.ellipseControls6.Location = new System.Drawing.Point(407, 228);
            this.ellipseControls6.Margin = new System.Windows.Forms.Padding(10);
            this.ellipseControls6.Name = "ellipseControls6";
            this.ellipseControls6.Size = new System.Drawing.Size(150, 150);
            this.ellipseControls6.TabIndex = 8;
            this.ellipseControls6.Text = "ellipseControls6";
            // 
            // ellipseControls7
            // 
            this.ellipseControls7.CornerRadius = 30;
            this.ellipseControls7.Location = new System.Drawing.Point(237, 228);
            this.ellipseControls7.Margin = new System.Windows.Forms.Padding(10);
            this.ellipseControls7.Name = "ellipseControls7";
            this.ellipseControls7.Size = new System.Drawing.Size(150, 150);
            this.ellipseControls7.TabIndex = 7;
            this.ellipseControls7.Text = "ellipseControls7";
            // 
            // ellipseControls8
            // 
            this.ellipseControls8.CornerRadius = 30;
            this.ellipseControls8.Location = new System.Drawing.Point(67, 228);
            this.ellipseControls8.Margin = new System.Windows.Forms.Padding(10);
            this.ellipseControls8.Name = "ellipseControls8";
            this.ellipseControls8.Size = new System.Drawing.Size(150, 150);
            this.ellipseControls8.TabIndex = 6;
            this.ellipseControls8.Text = "ellipseControls8";
            // 
            // ellipseControls3
            // 
            this.ellipseControls3.CornerRadius = 30;
            this.ellipseControls3.Location = new System.Drawing.Point(577, 58);
            this.ellipseControls3.Margin = new System.Windows.Forms.Padding(10);
            this.ellipseControls3.Name = "ellipseControls3";
            this.ellipseControls3.Size = new System.Drawing.Size(150, 150);
            this.ellipseControls3.TabIndex = 5;
            this.ellipseControls3.Text = "ellipseControls3";
            // 
            // ellipseControls4
            // 
            this.ellipseControls4.CornerRadius = 30;
            this.ellipseControls4.Location = new System.Drawing.Point(407, 58);
            this.ellipseControls4.Margin = new System.Windows.Forms.Padding(10);
            this.ellipseControls4.Name = "ellipseControls4";
            this.ellipseControls4.Size = new System.Drawing.Size(150, 150);
            this.ellipseControls4.TabIndex = 4;
            this.ellipseControls4.Text = "ellipseControls4";
            // 
            // ellipseControls2
            // 
            this.ellipseControls2.CornerRadius = 30;
            this.ellipseControls2.Location = new System.Drawing.Point(237, 58);
            this.ellipseControls2.Margin = new System.Windows.Forms.Padding(10);
            this.ellipseControls2.Name = "ellipseControls2";
            this.ellipseControls2.Size = new System.Drawing.Size(150, 150);
            this.ellipseControls2.TabIndex = 3;
            this.ellipseControls2.Text = "ellipseControls2";
            // 
            // ellipseControls1
            // 
            this.ellipseControls1.CornerRadius = 30;
            this.ellipseControls1.Location = new System.Drawing.Point(67, 58);
            this.ellipseControls1.Margin = new System.Windows.Forms.Padding(10);
            this.ellipseControls1.Name = "ellipseControls1";
            this.ellipseControls1.Size = new System.Drawing.Size(150, 150);
            this.ellipseControls1.TabIndex = 2;
            this.ellipseControls1.Text = "ellipseControls1";
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.PanelOpciones.CornerRadius = 90;
            this.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelOpciones.Location = new System.Drawing.Point(30, 30);
            this.PanelOpciones.Margin = new System.Windows.Forms.Padding(50);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Size = new System.Drawing.Size(740, 383);
            this.PanelOpciones.TabIndex = 1;
            this.PanelOpciones.Text = "ellipseControls1";
            // 
            // ellipseComponents1
            // 
            this.ellipseComponents1.CornerRadius = 60;
            this.ellipseComponents1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.BarraHerramientas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.BarraHerramientas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInicio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.EllipseComponents ellipseComponents1;
        private System.Windows.Forms.Panel BarraHerramientas;
        private System.Windows.Forms.Button btnCerrarPrograma;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controles.EllipseControls PanelOpciones;
        private System.Windows.Forms.Panel panelInicio;
        private Controles.EllipseControls ControlConfiguracion;
        private Controles.EllipseControls ellipseControls7;
        private Controles.EllipseControls ellipseControls8;
        private Controles.EllipseControls ellipseControls3;
        private Controles.EllipseControls ellipseControls4;
        private Controles.EllipseControls ellipseControls2;
        private Controles.EllipseControls ellipseControls1;
        private Controles.EllipseControls ellipseControls6;
        private Controles.EllipseButton btnConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfigVar;
        internal System.IO.Ports.SerialPort serialPort1;
        internal System.IO.Ports.SerialPort serialPort2;
        internal System.IO.Ports.SerialPort serialPort3;
        internal System.IO.Ports.SerialPort serialPort4;
    }
}

