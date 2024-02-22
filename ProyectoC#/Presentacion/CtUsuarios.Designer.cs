namespace ProyectoC_.Presentacion
{
    partial class CtUsuarios
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnagregar = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            txtBuscador = new TextBox();
            datalistadoUsuarios = new DataGridView();
            Eliminar = new DataGridViewImageColumn();
            Editar = new DataGridViewImageColumn();
            panelRegistro = new Panel();
            panelIcono = new Panel();
            btnVolver = new Button();
            pictureBox11 = new PictureBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            lblanuncioicono = new Label();
            icono = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnguardar = new Button();
            btnactualizar = new Button();
            btnvolver2 = new Button();
            panel4 = new Panel();
            dataListadoModulos = new DataGridView();
            Marcar = new DataGridViewCheckBoxColumn();
            txtcontraseña = new TextBox();
            txtusuario = new TextBox();
            txtnombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datalistadoUsuarios).BeginInit();
            panelRegistro.SuspendLayout();
            panelIcono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icono).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataListadoModulos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 29, 29);
            panel1.Controls.Add(btnagregar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtBuscador);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 64);
            panel1.TabIndex = 1;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.FromArgb(29, 29, 29);
            btnagregar.BackgroundImage = Properties.Resources.add;
            btnagregar.BackgroundImageLayout = ImageLayout.Zoom;
            btnagregar.Dock = DockStyle.Right;
            btnagregar.FlatAppearance.BorderSize = 0;
            btnagregar.FlatStyle = FlatStyle.Flat;
            btnagregar.Location = new Point(740, 0);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(75, 64);
            btnagregar.TabIndex = 3;
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.loupe;
            pictureBox1.Location = new Point(228, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(8, 198, 91);
            panel3.Location = new Point(22, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 2);
            panel3.TabIndex = 1;
            // 
            // txtBuscador
            // 
            txtBuscador.BackColor = Color.FromArgb(29, 29, 29);
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 12F);
            txtBuscador.ForeColor = SystemColors.Window;
            txtBuscador.Location = new Point(22, 20);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(200, 22);
            txtBuscador.TabIndex = 0;
            // 
            // datalistadoUsuarios
            // 
            datalistadoUsuarios.AllowUserToAddRows = false;
            datalistadoUsuarios.AllowUserToDeleteRows = false;
            datalistadoUsuarios.BackgroundColor = Color.FromArgb(29, 29, 29);
            datalistadoUsuarios.BorderStyle = BorderStyle.None;
            datalistadoUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datalistadoUsuarios.Columns.AddRange(new DataGridViewColumn[] { Eliminar, Editar });
            datalistadoUsuarios.Dock = DockStyle.Fill;
            datalistadoUsuarios.Location = new Point(0, 64);
            datalistadoUsuarios.Name = "datalistadoUsuarios";
            datalistadoUsuarios.ReadOnly = true;
            datalistadoUsuarios.RowHeadersVisible = false;
            datalistadoUsuarios.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(29, 29, 29);
            datalistadoUsuarios.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datalistadoUsuarios.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            datalistadoUsuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(64, 64, 64);
            datalistadoUsuarios.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            datalistadoUsuarios.RowTemplate.Height = 40;
            datalistadoUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datalistadoUsuarios.Size = new Size(815, 646);
            datalistadoUsuarios.TabIndex = 2;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "";
            Eliminar.Image = Properties.Resources.basura;
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.HeaderText = "";
            Editar.Image = Properties.Resources.editar;
            Editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            // 
            // panelRegistro
            // 
            panelRegistro.BorderStyle = BorderStyle.Fixed3D;
            panelRegistro.Controls.Add(panelIcono);
            panelRegistro.Controls.Add(lblanuncioicono);
            panelRegistro.Controls.Add(icono);
            panelRegistro.Controls.Add(flowLayoutPanel1);
            panelRegistro.Controls.Add(panel4);
            panelRegistro.Controls.Add(txtcontraseña);
            panelRegistro.Controls.Add(txtusuario);
            panelRegistro.Controls.Add(txtnombre);
            panelRegistro.Controls.Add(label6);
            panelRegistro.Controls.Add(label5);
            panelRegistro.Controls.Add(label4);
            panelRegistro.Controls.Add(label3);
            panelRegistro.Controls.Add(label2);
            panelRegistro.Controls.Add(label1);
            panelRegistro.Location = new Point(39, 87);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Size = new Size(734, 452);
            panelRegistro.TabIndex = 5;
            panelRegistro.Visible = false;
            // 
            // panelIcono
            // 
            panelIcono.BackColor = Color.FromArgb(39, 39, 39);
            panelIcono.Controls.Add(btnVolver);
            panelIcono.Controls.Add(pictureBox11);
            panelIcono.Controls.Add(flowLayoutPanel3);
            panelIcono.Controls.Add(flowLayoutPanel2);
            panelIcono.Location = new Point(461, 49);
            panelIcono.Name = "panelIcono";
            panelIcono.Size = new Size(536, 388);
            panelIcono.TabIndex = 26;
            panelIcono.Visible = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(39, 39, 39);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.ForeColor = SystemColors.ControlLightLight;
            btnVolver.Location = new Point(161, 274);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(107, 34);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.add;
            pictureBox11.Location = new Point(24, 261);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(116, 111);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 2;
            pictureBox11.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(pictureBox7);
            flowLayoutPanel3.Controls.Add(pictureBox8);
            flowLayoutPanel3.Controls.Add(pictureBox9);
            flowLayoutPanel3.Controls.Add(pictureBox10);
            flowLayoutPanel3.Location = new Point(24, 141);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(489, 114);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.extraterrestre;
            pictureBox7.Location = new Point(3, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(116, 111);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.fuego__1_;
            pictureBox8.Location = new Point(125, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(116, 111);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.coworking;
            pictureBox9.Location = new Point(247, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(116, 111);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 2;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.MonoOrus;
            pictureBox10.Location = new Point(369, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(116, 111);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 3;
            pictureBox10.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(pictureBox3);
            flowLayoutPanel2.Controls.Add(pictureBox4);
            flowLayoutPanel2.Controls.Add(pictureBox5);
            flowLayoutPanel2.Controls.Add(pictureBox6);
            flowLayoutPanel2.Location = new Point(24, 21);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(489, 114);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.nuclear;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 111);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Trinaranja;
            pictureBox4.Location = new Point(125, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(116, 111);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.animal;
            pictureBox5.Location = new Point(247, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(116, 111);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.comenzar;
            pictureBox6.Location = new Point(369, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(116, 111);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // lblanuncioicono
            // 
            lblanuncioicono.BackColor = SystemColors.ControlDark;
            lblanuncioicono.Location = new Point(410, 14);
            lblanuncioicono.Name = "lblanuncioicono";
            lblanuncioicono.Size = new Size(88, 81);
            lblanuncioicono.TabIndex = 25;
            lblanuncioicono.Text = "Elije un Icono";
            lblanuncioicono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // icono
            // 
            icono.Location = new Point(410, 14);
            icono.Name = "icono";
            icono.Size = new Size(100, 98);
            icono.SizeMode = PictureBoxSizeMode.Zoom;
            icono.TabIndex = 24;
            icono.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnguardar);
            flowLayoutPanel1.Controls.Add(btnactualizar);
            flowLayoutPanel1.Controls.Add(btnvolver2);
            flowLayoutPanel1.Location = new Point(95, 320);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(328, 49);
            flowLayoutPanel1.TabIndex = 23;
            // 
            // btnguardar
            // 
            btnguardar.BackgroundImage = Properties.Resources.verde;
            btnguardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnguardar.FlatAppearance.BorderSize = 0;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnguardar.ForeColor = SystemColors.ControlLightLight;
            btnguardar.Location = new Point(3, 3);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(103, 38);
            btnguardar.TabIndex = 0;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.BackgroundImage = Properties.Resources.verde;
            btnactualizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnactualizar.FlatAppearance.BorderSize = 0;
            btnactualizar.FlatStyle = FlatStyle.Flat;
            btnactualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnactualizar.ForeColor = SystemColors.ControlLightLight;
            btnactualizar.Location = new Point(112, 3);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(103, 38);
            btnactualizar.TabIndex = 1;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btnvolver2
            // 
            btnvolver2.BackgroundImage = Properties.Resources.naranja;
            btnvolver2.BackgroundImageLayout = ImageLayout.Stretch;
            btnvolver2.FlatAppearance.BorderSize = 0;
            btnvolver2.FlatStyle = FlatStyle.Flat;
            btnvolver2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnvolver2.ForeColor = SystemColors.ControlLightLight;
            btnvolver2.Location = new Point(221, 3);
            btnvolver2.Name = "btnvolver2";
            btnvolver2.Size = new Size(103, 38);
            btnvolver2.TabIndex = 2;
            btnvolver2.Text = "Volver";
            btnvolver2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(dataListadoModulos);
            panel4.Location = new Point(98, 158);
            panel4.Name = "panel4";
            panel4.Size = new Size(308, 147);
            panel4.TabIndex = 22;
            // 
            // dataListadoModulos
            // 
            dataListadoModulos.AllowUserToAddRows = false;
            dataListadoModulos.AllowUserToDeleteRows = false;
            dataListadoModulos.BackgroundColor = Color.WhiteSmoke;
            dataListadoModulos.BorderStyle = BorderStyle.None;
            dataListadoModulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataListadoModulos.Columns.AddRange(new DataGridViewColumn[] { Marcar });
            dataListadoModulos.Dock = DockStyle.Fill;
            dataListadoModulos.Location = new Point(0, 0);
            dataListadoModulos.Name = "dataListadoModulos";
            dataListadoModulos.ReadOnly = true;
            dataListadoModulos.RowHeadersVisible = false;
            dataListadoModulos.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataListadoModulos.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataListadoModulos.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataListadoModulos.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataListadoModulos.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataListadoModulos.RowTemplate.Height = 40;
            dataListadoModulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataListadoModulos.Size = new Size(308, 147);
            dataListadoModulos.TabIndex = 3;
            // 
            // Marcar
            // 
            Marcar.HeaderText = "Marcar";
            Marcar.Name = "Marcar";
            Marcar.ReadOnly = true;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(139, 85);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(136, 23);
            txtcontraseña.TabIndex = 21;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(139, 49);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(136, 23);
            txtusuario.TabIndex = 20;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(139, 14);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(169, 23);
            txtnombre.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(139, 127);
            label6.Name = "label6";
            label6.Size = new Size(331, 19);
            label6.TabIndex = 18;
            label6.Text = "(marcar los modulos a los que se tendra acceso)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(67, 127);
            label5.Name = "label5";
            label5.Size = new Size(66, 19);
            label5.TabIndex = 17;
            label5.Text = "Permisos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(281, 82);
            label4.Name = "label4";
            label4.Size = new Size(95, 26);
            label4.TabIndex = 16;
            label4.Text = "Se permite hasta \r\n6 numeros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(51, 89);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 13;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(74, 53);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 10;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(71, 18);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 7;
            label1.Text = "Nombre:";
            // 
            // CtUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panelRegistro);
            Controls.Add(datalistadoUsuarios);
            Controls.Add(panel1);
            Name = "CtUsuarios";
            Size = new Size(815, 710);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)datalistadoUsuarios).EndInit();
            panelRegistro.ResumeLayout(false);
            panelRegistro.PerformLayout();
            panelIcono.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)icono).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataListadoModulos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnagregar;
        private PictureBox pictureBox1;
        private Panel panel3;
        private TextBox txtBuscador;
        private DataGridView datalistadoUsuarios;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewImageColumn Editar;
        private Panel panelRegistro;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel4;
        private DataGridView dataListadoModulos;
        private TextBox txtcontraseña;
        private TextBox txtusuario;
        private TextBox txtnombre;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnguardar;
        private Button btnactualizar;
        private Button btnvolver2;
        private DataGridViewCheckBoxColumn Marcar;
        private Label lblanuncioicono;
        private PictureBox icono;
        private Panel panelIcono;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox11;
        private FlowLayoutPanel flowLayoutPanel3;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button btnVolver;
    }
}
