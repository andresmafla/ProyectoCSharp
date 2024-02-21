namespace ProyectoC_.Presentacion
{
    partial class TomarAsistencias
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnIniciarSesion = new Button();
            label1 = new Label();
            panel2 = new Panel();
            txtNombre = new Label();
            txtAviso = new Label();
            lblhora2 = new Label();
            lblfecha2 = new Label();
            label5 = new Label();
            panel6 = new Panel();
            label4 = new Label();
            txtIdentificacion2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panelObservacion = new Panel();
            btnConfirmar = new Button();
            txtobservacion = new RichTextBox();
            label8 = new Label();
            timerHora = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelObservacion.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnIniciarSesion);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 41);
            panel1.TabIndex = 0;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.Transparent;
            btnIniciarSesion.BackgroundImage = Properties.Resources.naranja;
            btnIniciarSesion.BackgroundImageLayout = ImageLayout.Stretch;
            btnIniciarSesion.Dock = DockStyle.Right;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 29, 29);
            btnIniciarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 29, 29);
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIniciarSesion.Location = new Point(918, 0);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(159, 41);
            btnIniciarSesion.TabIndex = 1;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 41);
            label1.TabIndex = 0;
            label1.Text = "ASM 1.0";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(txtAviso);
            panel2.Controls.Add(lblhora2);
            panel2.Controls.Add(lblfecha2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtIdentificacion2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(323, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 461);
            panel2.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.ForeColor = SystemColors.ControlDark;
            txtNombre.Location = new Point(36, 341);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(364, 23);
            txtNombre.TabIndex = 17;
            txtNombre.Text = "*******************";
            txtNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtAviso
            // 
            txtAviso.Font = new Font("Segoe UI", 11F);
            txtAviso.ForeColor = Color.FromArgb(255, 128, 0);
            txtAviso.Location = new Point(36, 306);
            txtAviso.Name = "txtAviso";
            txtAviso.Size = new Size(364, 23);
            txtAviso.TabIndex = 16;
            txtAviso.Text = "*******************";
            txtAviso.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblhora2
            // 
            lblhora2.AutoSize = true;
            lblhora2.ForeColor = SystemColors.ControlDark;
            lblhora2.Location = new Point(134, 252);
            lblhora2.Name = "lblhora2";
            lblhora2.Size = new Size(33, 15);
            lblhora2.TabIndex = 15;
            lblhora2.Text = "Hora";
            // 
            // lblfecha2
            // 
            lblfecha2.AutoSize = true;
            lblfecha2.ForeColor = SystemColors.ControlDark;
            lblfecha2.Location = new Point(134, 213);
            lblfecha2.Name = "lblfecha2";
            lblfecha2.Size = new Size(36, 15);
            lblfecha2.TabIndex = 14;
            lblfecha2.Text = "fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(81, 247);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 13;
            label5.Text = "Hora:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 128, 0);
            panel6.Location = new Point(125, 200);
            panel6.Name = "panel6";
            panel6.Size = new Size(169, 1);
            panel6.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(75, 209);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 12;
            label4.Text = "Fecha:";
            // 
            // txtIdentificacion2
            // 
            txtIdentificacion2.BackColor = Color.FromArgb(29, 29, 29);
            txtIdentificacion2.BorderStyle = BorderStyle.None;
            txtIdentificacion2.Font = new Font("Segoe UI", 12F);
            txtIdentificacion2.ForeColor = SystemColors.Window;
            txtIdentificacion2.Location = new Point(125, 172);
            txtIdentificacion2.Name = "txtIdentificacion2";
            txtIdentificacion2.Size = new Size(169, 22);
            txtIdentificacion2.TabIndex = 10;
            txtIdentificacion2.TextChanged += txtIdentificacion2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(20, 174);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 9;
            label3.Text = "Identificacion:";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(0, 141);
            label2.Name = "label2";
            label2.Size = new Size(442, 25);
            label2.TabIndex = 1;
            label2.Text = "REGISTRO DE ASISTENCIA";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(442, 141);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.LOGO1_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(442, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelObservacion
            // 
            panelObservacion.Controls.Add(btnConfirmar);
            panelObservacion.Controls.Add(txtobservacion);
            panelObservacion.Controls.Add(label8);
            panelObservacion.Location = new Point(12, 72);
            panelObservacion.Name = "panelObservacion";
            panelObservacion.Size = new Size(285, 328);
            panelObservacion.TabIndex = 2;
            panelObservacion.Visible = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Transparent;
            btnConfirmar.BackgroundImage = Properties.Resources.azul;
            btnConfirmar.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 29, 29);
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 29, 29);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfirmar.ForeColor = SystemColors.ControlLight;
            btnConfirmar.Location = new Point(62, 170);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(159, 41);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtobservacion
            // 
            txtobservacion.BackColor = Color.FromArgb(29, 29, 29);
            txtobservacion.Dock = DockStyle.Top;
            txtobservacion.Font = new Font("Segoe UI", 11F);
            txtobservacion.ForeColor = SystemColors.ScrollBar;
            txtobservacion.Location = new Point(0, 25);
            txtobservacion.Name = "txtobservacion";
            txtobservacion.Size = new Size(285, 139);
            txtobservacion.TabIndex = 3;
            txtobservacion.Text = "";
            // 
            // label8
            // 
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(285, 25);
            label8.TabIndex = 2;
            label8.Text = "Observación";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // timerHora
            // 
            timerHora.Enabled = true;
            timerHora.Tick += timerHora_Tick;
            // 
            // TomarAsistencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(1077, 531);
            Controls.Add(panelObservacion);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TomarAsistencias";
            Text = "TomarAsistencias";
            WindowState = FormWindowState.Maximized;
            Load += TomarAsistencias_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelObservacion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnIniciarSesion;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel6;
        private TextBox txtIdentificacion2;
        private Label label3;
        private Label lblhora2;
        private Label lblfecha2;
        private Label label5;
        private Label label4;
        private Label txtNombre;
        private Label txtAviso;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panelObservacion;
        private RichTextBox txtobservacion;
        private Label label8;
        private Button btnConfirmar;
        private System.Windows.Forms.Timer timerHora;
    }
}