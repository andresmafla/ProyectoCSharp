namespace ProyectoC_.Presentacion
{
    partial class Personal
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnagregar = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            txtBuscador = new TextBox();
            datalistadocargos = new DataGridView();
            EditarC = new DataGridViewImageColumn();
            datalistadoPersonal = new DataGridView();
            Eliminar = new DataGridViewImageColumn();
            Editar = new DataGridViewImageColumn();
            panelPaginado = new Panel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            btnUltimapag = new Button();
            btnPrimerapag = new Button();
            lbltotalpag = new Label();
            label8 = new Label();
            lblpagina = new Label();
            label6 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnPagsig = new Button();
            btnPagatra = new Button();
            panelRegistros = new Panel();
            panelCargos = new Panel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            btnguardarc = new Button();
            btnguardarcambiosc = new Button();
            btnVolverCargos = new Button();
            panel11 = new Panel();
            txtSueldo2 = new TextBox();
            label11 = new Label();
            panel10 = new Panel();
            txtcargo2 = new TextBox();
            label10 = new Label();
            panelbtnGuardarPersonal = new FlowLayoutPanel();
            btnGuardarPersonal = new Button();
            btnGuardarCambiosPersonal = new Button();
            btnAgregarCargo = new Button();
            btnVolverPersonal = new Button();
            cmbPais = new ComboBox();
            panel9 = new Panel();
            txtSueldo = new TextBox();
            panel8 = new Panel();
            txtCargo = new TextBox();
            panel6 = new Panel();
            txtIdentificacion = new TextBox();
            panel5 = new Panel();
            txtNombres = new TextBox();
            label5 = new Label();
            lblSueldo = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnMosTodos = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datalistadocargos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datalistadoPersonal).BeginInit();
            panelPaginado.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panelRegistros.SuspendLayout();
            panelCargos.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            panelbtnGuardarPersonal.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 29, 29);
            panel1.Controls.Add(btnMosTodos);
            panel1.Controls.Add(btnagregar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtBuscador);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 64);
            panel1.TabIndex = 0;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.FromArgb(29, 29, 29);
            btnagregar.BackgroundImage = Properties.Resources.add;
            btnagregar.BackgroundImageLayout = ImageLayout.Zoom;
            btnagregar.Dock = DockStyle.Right;
            btnagregar.FlatAppearance.BorderSize = 0;
            btnagregar.FlatStyle = FlatStyle.Flat;
            btnagregar.Location = new Point(747, 0);
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
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // datalistadocargos
            // 
            datalistadocargos.AllowUserToAddRows = false;
            datalistadocargos.AllowUserToDeleteRows = false;
            datalistadocargos.AllowUserToResizeRows = false;
            datalistadocargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datalistadocargos.ColumnHeadersVisible = false;
            datalistadocargos.Columns.AddRange(new DataGridViewColumn[] { EditarC });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(29, 29, 29);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            datalistadocargos.DefaultCellStyle = dataGridViewCellStyle1;
            datalistadocargos.Location = new Point(257, 86);
            datalistadocargos.Name = "datalistadocargos";
            datalistadocargos.ReadOnly = true;
            datalistadocargos.RowHeadersVisible = false;
            datalistadocargos.RowTemplate.Height = 40;
            datalistadocargos.ScrollBars = ScrollBars.None;
            datalistadocargos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datalistadocargos.Size = new Size(305, 125);
            datalistadocargos.TabIndex = 19;
            datalistadocargos.CellClick += datalistadocargos_CellClick;
            // 
            // EditarC
            // 
            EditarC.HeaderText = "";
            EditarC.Image = Properties.Resources.lapiz;
            EditarC.ImageLayout = DataGridViewImageCellLayout.Zoom;
            EditarC.Name = "EditarC";
            EditarC.ReadOnly = true;
            // 
            // datalistadoPersonal
            // 
            datalistadoPersonal.AllowUserToAddRows = false;
            datalistadoPersonal.AllowUserToDeleteRows = false;
            datalistadoPersonal.BackgroundColor = Color.FromArgb(29, 29, 29);
            datalistadoPersonal.BorderStyle = BorderStyle.None;
            datalistadoPersonal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datalistadoPersonal.Columns.AddRange(new DataGridViewColumn[] { Eliminar, Editar });
            datalistadoPersonal.Dock = DockStyle.Fill;
            datalistadoPersonal.Location = new Point(0, 64);
            datalistadoPersonal.Name = "datalistadoPersonal";
            datalistadoPersonal.ReadOnly = true;
            datalistadoPersonal.RowHeadersVisible = false;
            datalistadoPersonal.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(29, 29, 29);
            datalistadoPersonal.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datalistadoPersonal.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            datalistadoPersonal.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(64, 64, 64);
            datalistadoPersonal.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            datalistadoPersonal.RowTemplate.Height = 40;
            datalistadoPersonal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datalistadoPersonal.Size = new Size(822, 295);
            datalistadoPersonal.TabIndex = 1;
            datalistadoPersonal.CellClick += datalistadoPersonal_CellClick;
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
            // panelPaginado
            // 
            panelPaginado.BackColor = Color.FromArgb(39, 39, 39);
            panelPaginado.Controls.Add(flowLayoutPanel3);
            panelPaginado.Controls.Add(lbltotalpag);
            panelPaginado.Controls.Add(label8);
            panelPaginado.Controls.Add(lblpagina);
            panelPaginado.Controls.Add(label6);
            panelPaginado.Controls.Add(flowLayoutPanel2);
            panelPaginado.Dock = DockStyle.Bottom;
            panelPaginado.Location = new Point(0, 359);
            panelPaginado.Name = "panelPaginado";
            panelPaginado.Size = new Size(822, 76);
            panelPaginado.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(btnUltimapag);
            flowLayoutPanel3.Controls.Add(btnPrimerapag);
            flowLayoutPanel3.Location = new Point(470, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(348, 44);
            flowLayoutPanel3.TabIndex = 23;
            // 
            // btnUltimapag
            // 
            btnUltimapag.BackColor = Color.FromArgb(8, 198, 91);
            btnUltimapag.FlatAppearance.BorderSize = 0;
            btnUltimapag.FlatStyle = FlatStyle.Flat;
            btnUltimapag.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUltimapag.ForeColor = SystemColors.ActiveCaptionText;
            btnUltimapag.Location = new Point(3, 3);
            btnUltimapag.Name = "btnUltimapag";
            btnUltimapag.Size = new Size(165, 34);
            btnUltimapag.TabIndex = 0;
            btnUltimapag.Text = "Ultima Pagina";
            btnUltimapag.UseVisualStyleBackColor = false;
            btnUltimapag.Click += btnUltimapag_Click;
            // 
            // btnPrimerapag
            // 
            btnPrimerapag.BackColor = Color.FromArgb(8, 198, 91);
            btnPrimerapag.FlatAppearance.BorderSize = 0;
            btnPrimerapag.FlatStyle = FlatStyle.Flat;
            btnPrimerapag.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPrimerapag.ForeColor = SystemColors.ActiveCaptionText;
            btnPrimerapag.Location = new Point(174, 3);
            btnPrimerapag.Name = "btnPrimerapag";
            btnPrimerapag.Size = new Size(163, 34);
            btnPrimerapag.TabIndex = 1;
            btnPrimerapag.Text = "Primera Pagina";
            btnPrimerapag.UseVisualStyleBackColor = false;
            btnPrimerapag.Click += btnPrimerapag_Click;
            // 
            // lbltotalpag
            // 
            lbltotalpag.AutoSize = true;
            lbltotalpag.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltotalpag.ForeColor = SystemColors.ControlDark;
            lbltotalpag.Location = new Point(450, 15);
            lbltotalpag.Name = "lbltotalpag";
            lbltotalpag.Size = new Size(14, 15);
            lbltotalpag.TabIndex = 22;
            lbltotalpag.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(423, 15);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 21;
            label8.Text = "de";
            // 
            // lblpagina
            // 
            lblpagina.AutoSize = true;
            lblpagina.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblpagina.ForeColor = SystemColors.ControlDark;
            lblpagina.Location = new Point(403, 15);
            lblpagina.Name = "lblpagina";
            lblpagina.Size = new Size(14, 15);
            lblpagina.TabIndex = 20;
            lblpagina.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(354, 15);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 19;
            label6.Text = "Pagina";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnPagsig);
            flowLayoutPanel2.Controls.Add(btnPagatra);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(348, 76);
            flowLayoutPanel2.TabIndex = 18;
            // 
            // btnPagsig
            // 
            btnPagsig.BackColor = Color.FromArgb(8, 198, 91);
            btnPagsig.FlatAppearance.BorderSize = 0;
            btnPagsig.FlatStyle = FlatStyle.Flat;
            btnPagsig.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPagsig.ForeColor = SystemColors.ActiveCaptionText;
            btnPagsig.Location = new Point(3, 3);
            btnPagsig.Name = "btnPagsig";
            btnPagsig.Size = new Size(165, 34);
            btnPagsig.TabIndex = 0;
            btnPagsig.Text = "Pagina siguiente";
            btnPagsig.UseVisualStyleBackColor = false;
            btnPagsig.Click += btnPagsig_Click;
            // 
            // btnPagatra
            // 
            btnPagatra.BackColor = Color.FromArgb(8, 198, 91);
            btnPagatra.FlatAppearance.BorderSize = 0;
            btnPagatra.FlatStyle = FlatStyle.Flat;
            btnPagatra.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPagatra.ForeColor = SystemColors.ActiveCaptionText;
            btnPagatra.Location = new Point(174, 3);
            btnPagatra.Name = "btnPagatra";
            btnPagatra.Size = new Size(163, 34);
            btnPagatra.TabIndex = 1;
            btnPagatra.Text = "Pagina Anterior";
            btnPagatra.UseVisualStyleBackColor = false;
            btnPagatra.Click += btnPagatra_Click;
            // 
            // panelRegistros
            // 
            panelRegistros.BackColor = Color.FromArgb(29, 29, 29);
            panelRegistros.Controls.Add(datalistadocargos);
            panelRegistros.Controls.Add(panelCargos);
            panelRegistros.Controls.Add(panelbtnGuardarPersonal);
            panelRegistros.Controls.Add(btnAgregarCargo);
            panelRegistros.Controls.Add(btnVolverPersonal);
            panelRegistros.Controls.Add(cmbPais);
            panelRegistros.Controls.Add(panel9);
            panelRegistros.Controls.Add(txtSueldo);
            panelRegistros.Controls.Add(panel8);
            panelRegistros.Controls.Add(txtCargo);
            panelRegistros.Controls.Add(panel6);
            panelRegistros.Controls.Add(txtIdentificacion);
            panelRegistros.Controls.Add(panel5);
            panelRegistros.Controls.Add(txtNombres);
            panelRegistros.Controls.Add(label5);
            panelRegistros.Controls.Add(lblSueldo);
            panelRegistros.Controls.Add(label3);
            panelRegistros.Controls.Add(label2);
            panelRegistros.Controls.Add(label1);
            panelRegistros.Font = new Font("Segoe UI", 12F);
            panelRegistros.Location = new Point(0, 80);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(818, 273);
            panelRegistros.TabIndex = 3;
            panelRegistros.Visible = false;
            // 
            // panelCargos
            // 
            panelCargos.Controls.Add(flowLayoutPanel4);
            panelCargos.Controls.Add(panel11);
            panelCargos.Controls.Add(txtSueldo2);
            panelCargos.Controls.Add(label11);
            panelCargos.Controls.Add(panel10);
            panelCargos.Controls.Add(txtcargo2);
            panelCargos.Controls.Add(label10);
            panelCargos.Location = new Point(504, 93);
            panelCargos.Name = "panelCargos";
            panelCargos.Size = new Size(303, 149);
            panelCargos.TabIndex = 18;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(btnguardarc);
            flowLayoutPanel4.Controls.Add(btnguardarcambiosc);
            flowLayoutPanel4.Controls.Add(btnVolverCargos);
            flowLayoutPanel4.Location = new Point(9, 96);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(278, 50);
            flowLayoutPanel4.TabIndex = 19;
            // 
            // btnguardarc
            // 
            btnguardarc.BackColor = Color.LimeGreen;
            btnguardarc.FlatAppearance.BorderSize = 0;
            btnguardarc.FlatStyle = FlatStyle.Flat;
            btnguardarc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnguardarc.ForeColor = SystemColors.ControlLightLight;
            btnguardarc.Location = new Point(3, 3);
            btnguardarc.Name = "btnguardarc";
            btnguardarc.Size = new Size(95, 34);
            btnguardarc.TabIndex = 0;
            btnguardarc.Text = "Guardar";
            btnguardarc.UseVisualStyleBackColor = false;
            btnguardarc.Click += btnguardarc_Click;
            // 
            // btnguardarcambiosc
            // 
            btnguardarcambiosc.BackColor = Color.LimeGreen;
            btnguardarcambiosc.FlatAppearance.BorderSize = 0;
            btnguardarcambiosc.FlatStyle = FlatStyle.Flat;
            btnguardarcambiosc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnguardarcambiosc.ForeColor = SystemColors.ControlLightLight;
            btnguardarcambiosc.Location = new Point(104, 3);
            btnguardarcambiosc.Name = "btnguardarcambiosc";
            btnguardarcambiosc.Size = new Size(95, 34);
            btnguardarcambiosc.TabIndex = 1;
            btnguardarcambiosc.Text = "Guardar*";
            btnguardarcambiosc.UseVisualStyleBackColor = false;
            btnguardarcambiosc.Click += btnguardarcambiosc_Click;
            // 
            // btnVolverCargos
            // 
            btnVolverCargos.BackgroundImage = Properties.Resources.back;
            btnVolverCargos.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverCargos.FlatAppearance.BorderSize = 0;
            btnVolverCargos.FlatStyle = FlatStyle.Flat;
            btnVolverCargos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVolverCargos.ForeColor = SystemColors.ControlLightLight;
            btnVolverCargos.Location = new Point(205, 3);
            btnVolverCargos.Name = "btnVolverCargos";
            btnVolverCargos.Size = new Size(52, 29);
            btnVolverCargos.TabIndex = 3;
            btnVolverCargos.UseVisualStyleBackColor = true;
            btnVolverCargos.Click += btnVolverCargos_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(224, 224, 224);
            panel11.Location = new Point(140, 77);
            panel11.Name = "panel11";
            panel11.Size = new Size(147, 1);
            panel11.TabIndex = 18;
            // 
            // txtSueldo2
            // 
            txtSueldo2.BackColor = Color.FromArgb(29, 29, 29);
            txtSueldo2.BorderStyle = BorderStyle.None;
            txtSueldo2.Font = new Font("Segoe UI", 12F);
            txtSueldo2.ForeColor = SystemColors.Window;
            txtSueldo2.Location = new Point(140, 49);
            txtSueldo2.Name = "txtSueldo2";
            txtSueldo2.Size = new Size(147, 22);
            txtSueldo2.TabIndex = 17;
            txtSueldo2.KeyPress += txtSueldo2_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ControlLight;
            label11.Location = new Point(9, 50);
            label11.Name = "label11";
            label11.Size = new Size(125, 21);
            label11.TabIndex = 16;
            label11.Text = "Sueldo por hora:";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(224, 224, 224);
            panel10.Location = new Point(140, 43);
            panel10.Name = "panel10";
            panel10.Size = new Size(147, 1);
            panel10.TabIndex = 15;
            // 
            // txtcargo2
            // 
            txtcargo2.BackColor = Color.FromArgb(29, 29, 29);
            txtcargo2.BorderStyle = BorderStyle.None;
            txtcargo2.Font = new Font("Segoe UI", 12F);
            txtcargo2.ForeColor = SystemColors.Window;
            txtcargo2.Location = new Point(140, 15);
            txtcargo2.Name = "txtcargo2";
            txtcargo2.Size = new Size(147, 22);
            txtcargo2.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlLight;
            label10.Location = new Point(82, 15);
            label10.Name = "label10";
            label10.Size = new Size(52, 21);
            label10.TabIndex = 13;
            label10.Text = "cargo:";
            // 
            // panelbtnGuardarPersonal
            // 
            panelbtnGuardarPersonal.Controls.Add(btnGuardarPersonal);
            panelbtnGuardarPersonal.Controls.Add(btnGuardarCambiosPersonal);
            panelbtnGuardarPersonal.Location = new Point(141, 205);
            panelbtnGuardarPersonal.Name = "panelbtnGuardarPersonal";
            panelbtnGuardarPersonal.Size = new Size(207, 50);
            panelbtnGuardarPersonal.TabIndex = 17;
            // 
            // btnGuardarPersonal
            // 
            btnGuardarPersonal.BackColor = Color.LimeGreen;
            btnGuardarPersonal.FlatAppearance.BorderSize = 0;
            btnGuardarPersonal.FlatStyle = FlatStyle.Flat;
            btnGuardarPersonal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardarPersonal.ForeColor = SystemColors.ControlLightLight;
            btnGuardarPersonal.Location = new Point(3, 3);
            btnGuardarPersonal.Name = "btnGuardarPersonal";
            btnGuardarPersonal.Size = new Size(95, 34);
            btnGuardarPersonal.TabIndex = 0;
            btnGuardarPersonal.Text = "Guardar";
            btnGuardarPersonal.UseVisualStyleBackColor = false;
            btnGuardarPersonal.Click += btnGuardarPersonal_Click;
            // 
            // btnGuardarCambiosPersonal
            // 
            btnGuardarCambiosPersonal.BackColor = Color.LimeGreen;
            btnGuardarCambiosPersonal.FlatAppearance.BorderSize = 0;
            btnGuardarCambiosPersonal.FlatStyle = FlatStyle.Flat;
            btnGuardarCambiosPersonal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardarCambiosPersonal.ForeColor = SystemColors.ControlLightLight;
            btnGuardarCambiosPersonal.Location = new Point(104, 3);
            btnGuardarCambiosPersonal.Name = "btnGuardarCambiosPersonal";
            btnGuardarCambiosPersonal.Size = new Size(95, 34);
            btnGuardarCambiosPersonal.TabIndex = 1;
            btnGuardarCambiosPersonal.Text = "Guardar*";
            btnGuardarCambiosPersonal.UseVisualStyleBackColor = false;
            btnGuardarCambiosPersonal.Click += btnGuardarCambiosPersonal_Click;
            // 
            // btnAgregarCargo
            // 
            btnAgregarCargo.FlatAppearance.BorderSize = 0;
            btnAgregarCargo.FlatStyle = FlatStyle.Flat;
            btnAgregarCargo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregarCargo.ForeColor = SystemColors.AppWorkspace;
            btnAgregarCargo.Location = new Point(355, 123);
            btnAgregarCargo.Name = "btnAgregarCargo";
            btnAgregarCargo.Size = new Size(151, 30);
            btnAgregarCargo.TabIndex = 16;
            btnAgregarCargo.Text = "+ Agregar cargo";
            btnAgregarCargo.UseVisualStyleBackColor = true;
            btnAgregarCargo.Click += btnAgregarCargo_Click;
            // 
            // btnVolverPersonal
            // 
            btnVolverPersonal.BackgroundImage = Properties.Resources.back;
            btnVolverPersonal.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverPersonal.FlatAppearance.BorderSize = 0;
            btnVolverPersonal.FlatStyle = FlatStyle.Flat;
            btnVolverPersonal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVolverPersonal.ForeColor = SystemColors.ControlLightLight;
            btnVolverPersonal.Location = new Point(524, 13);
            btnVolverPersonal.Name = "btnVolverPersonal";
            btnVolverPersonal.Size = new Size(52, 29);
            btnVolverPersonal.TabIndex = 2;
            btnVolverPersonal.UseVisualStyleBackColor = true;
            btnVolverPersonal.Click += btnVolverPersonal_Click;
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Items.AddRange(new object[] { "Afganistán", "Albania", "Alemania", "Andorra", "Angola", "Antigua y Barbuda", "Arabia Saudita", "Argelia", "Argentina", "Armenia", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bangladés", "Barbados", "Baréin", "Bélgica", "Belice", "Benín", "Bielorrusia", "Birmania", "Bolivia", "Bosnia y Herzegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Catar", "Chad", "Chile", "China", "Chipre", "Colombia", "Comoras", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Georgia", "Ghana", "Granada", "Grecia", "Guatemala", "Guyana", "Guinea", "Guinea-Bisáu", "Guinea Ecuatorial", "Haití", "Honduras", "Hungría", "India", "Indonesia", "Irak", "Irán", "Irlanda", "Islandia", "Islas Marshall", "Islas Salomón", "Israel", "Italia", "Jamaica", "Japón", "Jordania", "Kazajistán", "Kenia", "Kirguistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Marruecos", "Mauricio", "Mauritania", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Mozambique", "Namibia", "Nauru", "Nepal", "Nicaragua", "Níger", "Nigeria", "Noruega", "Nueva Zelanda", "Omán", "Países Bajos", "Pakistán", "Palaos", "Panamá", "Papúa Nueva Guinea", "Paraguay", "Perú", "Polonia", "Portugal", "Reino Unido", "República Centroafricana", "República Checa", "República Democrática del Congo", "República Dominicana", "República Sudafricana", "Ruanda", "Rumanía", "Rusia", "Samoa", "San Cristóbal y Nieves", "San Marino", "San Vicente y las Granadinas", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Serbia", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Sri Lanka", "Suazilandia", "Sudán", "Sudán del Sur", "Suecia", "Suiza", "Surinam", "Tailandia", "Taiwán", "Tanzania", "Tayikistán", "Timor Oriental", "Togo", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Uruguay", "Uzbekistán", "Vanuatu", "Vaticano", "Venezuela", "Vietnam", "Yemen", "Yibuti", "Zambia", "Zimbabue" });
            cmbPais.Location = new Point(190, 90);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(147, 29);
            cmbPais.TabIndex = 15;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(224, 224, 224);
            panel9.Location = new Point(190, 191);
            panel9.Name = "panel9";
            panel9.Size = new Size(147, 1);
            panel9.TabIndex = 14;
            // 
            // txtSueldo
            // 
            txtSueldo.BackColor = Color.FromArgb(29, 29, 29);
            txtSueldo.BorderStyle = BorderStyle.None;
            txtSueldo.Font = new Font("Segoe UI", 12F);
            txtSueldo.ForeColor = SystemColors.Window;
            txtSueldo.Location = new Point(190, 163);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(147, 22);
            txtSueldo.TabIndex = 13;
            txtSueldo.KeyPress += txtSueldo_KeyPress;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(224, 224, 224);
            panel8.Location = new Point(190, 155);
            panel8.Name = "panel8";
            panel8.Size = new Size(147, 1);
            panel8.TabIndex = 12;
            // 
            // txtCargo
            // 
            txtCargo.BackColor = Color.FromArgb(29, 29, 29);
            txtCargo.BorderStyle = BorderStyle.None;
            txtCargo.Font = new Font("Segoe UI", 12F);
            txtCargo.ForeColor = SystemColors.Window;
            txtCargo.Location = new Point(190, 127);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(147, 22);
            txtCargo.TabIndex = 11;
            txtCargo.TextChanged += txtCargo_TextChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(224, 224, 224);
            panel6.Location = new Point(190, 83);
            panel6.Name = "panel6";
            panel6.Size = new Size(147, 1);
            panel6.TabIndex = 8;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.BackColor = Color.FromArgb(29, 29, 29);
            txtIdentificacion.BorderStyle = BorderStyle.None;
            txtIdentificacion.Font = new Font("Segoe UI", 12F);
            txtIdentificacion.ForeColor = SystemColors.Window;
            txtIdentificacion.Location = new Point(190, 55);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(147, 22);
            txtIdentificacion.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(224, 224, 224);
            panel5.Location = new Point(190, 44);
            panel5.Name = "panel5";
            panel5.Size = new Size(304, 1);
            panel5.TabIndex = 6;
            // 
            // txtNombres
            // 
            txtNombres.BackColor = Color.FromArgb(29, 29, 29);
            txtNombres.BorderStyle = BorderStyle.None;
            txtNombres.Font = new Font("Segoe UI", 12F);
            txtNombres.ForeColor = SystemColors.Window;
            txtNombres.Location = new Point(190, 16);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(304, 22);
            txtNombres.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(132, 128);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 4;
            label5.Text = "Cargo:";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.ForeColor = SystemColors.ControlLight;
            lblSueldo.Location = new Point(59, 163);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(125, 21);
            lblSueldo.TabIndex = 3;
            lblSueldo.Text = "Sueldo por hora:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(144, 93);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 2;
            label3.Text = "Pais:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(79, 56);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 1;
            label2.Text = "Identificacion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(28, 17);
            label1.Name = "label1";
            label1.Size = new Size(156, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombres y apellidos:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // btnMosTodos
            // 
            btnMosTodos.BackColor = Color.LimeGreen;
            btnMosTodos.FlatAppearance.BorderSize = 0;
            btnMosTodos.FlatStyle = FlatStyle.Flat;
            btnMosTodos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMosTodos.ForeColor = SystemColors.ControlLightLight;
            btnMosTodos.Location = new Point(296, 20);
            btnMosTodos.Name = "btnMosTodos";
            btnMosTodos.Size = new Size(168, 34);
            btnMosTodos.TabIndex = 4;
            btnMosTodos.Text = "Mostrar Todos";
            btnMosTodos.UseVisualStyleBackColor = false;
            btnMosTodos.Click += btnMosTodos_Click;
            // 
            // Personal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelRegistros);
            Controls.Add(datalistadoPersonal);
            Controls.Add(panelPaginado);
            Controls.Add(panel1);
            Name = "Personal";
            Size = new Size(822, 435);
            Load += Personal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)datalistadocargos).EndInit();
            ((System.ComponentModel.ISupportInitialize)datalistadoPersonal).EndInit();
            panelPaginado.ResumeLayout(false);
            panelPaginado.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panelRegistros.ResumeLayout(false);
            panelRegistros.PerformLayout();
            panelCargos.ResumeLayout(false);
            panelCargos.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            panelbtnGuardarPersonal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView datalistadoPersonal;
        private Panel panelPaginado;
        private Panel panel3;
        private TextBox txtBuscador;
        private PictureBox pictureBox1;
        private Panel panelRegistros;
        private Label label5;
        private Label lblSueldo;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel9;
        private TextBox txtSueldo;
        private Panel panel8;
        private TextBox txtCargo;
        private Panel panel6;
        private TextBox txtIdentificacion;
        private Panel panel5;
        private TextBox txtNombres;
        private ComboBox cmbPais;
        private Button btnagregar;
        private Button btnAgregarCargo;
        private Button btnVolverPersonal;
        private Button btnMostrarTodos;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnPagsig;
        private Button btnPagatra;
        private FlowLayoutPanel panelbtnGuardarPersonal;
        private Button btnGuardarPersonal;
        private Button btnGuardarCambiosPersonal;
        private Label label6;
        private Label label8;
        private Label lblpagina;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btnUltimapag;
        private Button btnPrimerapag;
        private Label lbltotalpag;
        private Panel panelCargos;
        private Panel panel11;
        private TextBox txtSueldo2;
        private Label label11;
        private Panel panel10;
        private TextBox txtcargo2;
        private Label label10;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button btnguardarc;
        private Button btnguardarcambiosc;
        private DataGridView datalistadocargos;
        private DataGridViewImageColumn EditarC;
        private Button btnVolverCargos;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewImageColumn Editar;
        private System.Windows.Forms.Timer timer1;
        private Button btnMosTodos;
    }
}
