namespace Presentation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DgvDatos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtArtista = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Artista = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlbum = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDuracion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCancion = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboArtista = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboAlbum = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboPais = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGenero = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_anoLanzamiento = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_crearArtista = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_verArtista = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_actualizarArtista = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_eliminarArtista = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_elminarAlbum = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_actualizarAlbum = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_verAlbumes = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_crearAlbum = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_eliminarCancion = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_actualizarCancion = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_verCanciones = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_crearCancion = new Guna.UI2.WinForms.Guna2TileButton();
            this.Id_Artista = new Guna.UI2.WinForms.Guna2TextBox();
            this.Id_Album = new Guna.UI2.WinForms.Guna2TextBox();
            this.Id_Cancion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.PanelTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelTop.BackgroundImage")));
            this.PanelTop.Controls.Add(this.btnMaximize);
            this.PanelTop.Controls.Add(this.btnMinimize);
            this.PanelTop.Controls.Add(this.btnClose);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1551, 112);
            this.PanelTop.TabIndex = 0;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1460, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(32, 32);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1412, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1507, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.PanelTop;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // DgvDatos
            // 
            this.DgvDatos.AllowUserToAddRows = false;
            this.DgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.DgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDatos.ColumnHeadersHeight = 30;
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.DgvDatos.Location = new System.Drawing.Point(47, 565);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDatos.RowHeadersVisible = false;
            this.DgvDatos.RowHeadersWidth = 51;
            this.DgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvDatos.RowTemplate.Height = 24;
            this.DgvDatos.RowTemplate.ReadOnly = true;
            this.DgvDatos.Size = new System.Drawing.Size(1185, 134);
            this.DgvDatos.TabIndex = 1;
            this.DgvDatos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.DgvDatos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.DgvDatos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvDatos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvDatos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvDatos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvDatos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvDatos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.DgvDatos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.DgvDatos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvDatos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDatos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvDatos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvDatos.ThemeStyle.HeaderStyle.Height = 30;
            this.DgvDatos.ThemeStyle.ReadOnly = false;
            this.DgvDatos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.DgvDatos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvDatos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDatos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvDatos.ThemeStyle.RowsStyle.Height = 24;
            this.DgvDatos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.DgvDatos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatos_CellClick);
            // 
            // txtArtista
            // 
            this.txtArtista.Animated = true;
            this.txtArtista.BorderRadius = 13;
            this.txtArtista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArtista.DefaultText = "";
            this.txtArtista.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtArtista.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtArtista.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArtista.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArtista.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArtista.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtArtista.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArtista.Location = new System.Drawing.Point(58, 222);
            this.txtArtista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.PasswordChar = '\0';
            this.txtArtista.PlaceholderText = "";
            this.txtArtista.SelectedText = "";
            this.txtArtista.Size = new System.Drawing.Size(373, 37);
            this.txtArtista.TabIndex = 2;
            this.txtArtista.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(67)))), ((int)(((byte)(123)))));
            this.label1.Location = new System.Drawing.Point(58, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Artístico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(67)))), ((int)(((byte)(123)))));
            this.label2.Location = new System.Drawing.Point(461, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Género Musical";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(67)))), ((int)(((byte)(123)))));
            this.label4.Location = new System.Drawing.Point(756, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "País de Origen";
            // 
            // Artista
            // 
            this.Artista.AutoSize = true;
            this.Artista.BackColor = System.Drawing.Color.Transparent;
            this.Artista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(67)))), ((int)(((byte)(123)))));
            this.Artista.Location = new System.Drawing.Point(39, 168);
            this.Artista.Name = "Artista";
            this.Artista.Size = new System.Drawing.Size(232, 23);
            this.Artista.TabIndex = 10;
            this.Artista.Text = "Información del Artista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(67)))), ((int)(((byte)(123)))));
            this.label3.Location = new System.Drawing.Point(43, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Información del Albúm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(67)))), ((int)(((byte)(123)))));
            this.label5.Location = new System.Drawing.Point(756, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Artista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(67)))), ((int)(((byte)(123)))));
            this.label6.Location = new System.Drawing.Point(465, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Año de Lanzamiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(67)))), ((int)(((byte)(123)))));
            this.label7.Location = new System.Drawing.Point(62, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre del Albúm";
            // 
            // txtAlbum
            // 
            this.txtAlbum.BorderRadius = 13;
            this.txtAlbum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlbum.DefaultText = "";
            this.txtAlbum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAlbum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAlbum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlbum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlbum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlbum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAlbum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlbum.Location = new System.Drawing.Point(62, 333);
            this.txtAlbum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.PasswordChar = '\0';
            this.txtAlbum.PlaceholderText = "";
            this.txtAlbum.SelectedText = "";
            this.txtAlbum.Size = new System.Drawing.Size(373, 37);
            this.txtAlbum.TabIndex = 11;
            this.txtAlbum.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(67)))), ((int)(((byte)(123)))));
            this.label8.Location = new System.Drawing.Point(39, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Detalles de Canción";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(67)))), ((int)(((byte)(123)))));
            this.label9.Location = new System.Drawing.Point(678, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Albúm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(67)))), ((int)(((byte)(123)))));
            this.label10.Location = new System.Drawing.Point(461, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Duración (MM:SS)";
            // 
            // txtDuracion
            // 
            this.txtDuracion.BorderRadius = 13;
            this.txtDuracion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDuracion.DefaultText = "";
            this.txtDuracion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDuracion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDuracion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDuracion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDuracion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDuracion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDuracion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDuracion.Location = new System.Drawing.Point(465, 440);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.PasswordChar = '\0';
            this.txtDuracion.PlaceholderText = "";
            this.txtDuracion.SelectedText = "";
            this.txtDuracion.Size = new System.Drawing.Size(169, 37);
            this.txtDuracion.TabIndex = 20;
            this.txtDuracion.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(67)))), ((int)(((byte)(123)))));
            this.label11.Location = new System.Drawing.Point(58, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Canción";
            // 
            // txtCancion
            // 
            this.txtCancion.BorderRadius = 13;
            this.txtCancion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCancion.DefaultText = "";
            this.txtCancion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCancion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCancion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCancion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCancion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCancion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCancion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCancion.Location = new System.Drawing.Point(58, 440);
            this.txtCancion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCancion.Name = "txtCancion";
            this.txtCancion.PasswordChar = '\0';
            this.txtCancion.PlaceholderText = "";
            this.txtCancion.SelectedText = "";
            this.txtCancion.Size = new System.Drawing.Size(373, 37);
            this.txtCancion.TabIndex = 18;
            this.txtCancion.TabStop = false;
            // 
            // comboArtista
            // 
            this.comboArtista.BackColor = System.Drawing.Color.Transparent;
            this.comboArtista.BorderRadius = 13;
            this.comboArtista.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboArtista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboArtista.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboArtista.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboArtista.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboArtista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboArtista.ItemHeight = 30;
            this.comboArtista.Location = new System.Drawing.Point(750, 332);
            this.comboArtista.Name = "comboArtista";
            this.comboArtista.Size = new System.Drawing.Size(225, 36);
            this.comboArtista.TabIndex = 25;
            this.comboArtista.TabStop = false;
            this.comboArtista.SelectedIndexChanged += new System.EventHandler(this.comboArtista_SelectedIndexChanged);
            // 
            // comboAlbum
            // 
            this.comboAlbum.BackColor = System.Drawing.Color.Transparent;
            this.comboAlbum.BorderRadius = 13;
            this.comboAlbum.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlbum.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboAlbum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboAlbum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboAlbum.ItemHeight = 30;
            this.comboAlbum.Location = new System.Drawing.Point(670, 441);
            this.comboAlbum.Name = "comboAlbum";
            this.comboAlbum.Size = new System.Drawing.Size(305, 36);
            this.comboAlbum.TabIndex = 26;
            this.comboAlbum.TabStop = false;
            // 
            // comboPais
            // 
            this.comboPais.BackColor = System.Drawing.Color.Transparent;
            this.comboPais.BorderRadius = 13;
            this.comboPais.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPais.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboPais.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboPais.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboPais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboPais.ItemHeight = 30;
            this.comboPais.ItemsAppearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPais.Location = new System.Drawing.Point(750, 220);
            this.comboPais.Name = "comboPais";
            this.comboPais.Size = new System.Drawing.Size(225, 36);
            this.comboPais.TabIndex = 27;
            this.comboPais.TabStop = false;
            this.comboPais.SelectedIndexChanged += new System.EventHandler(this.comboPais_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(67)))), ((int)(((byte)(123)))));
            this.label12.Location = new System.Drawing.Point(39, 509);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 23);
            this.label12.TabIndex = 29;
            this.label12.Text = "Registros";
            // 
            // txtGenero
            // 
            this.txtGenero.Animated = true;
            this.txtGenero.BorderRadius = 13;
            this.txtGenero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGenero.DefaultText = "";
            this.txtGenero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGenero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGenero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGenero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenero.Location = new System.Drawing.Point(465, 222);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.PasswordChar = '\0';
            this.txtGenero.PlaceholderText = "";
            this.txtGenero.SelectedText = "";
            this.txtGenero.Size = new System.Drawing.Size(266, 37);
            this.txtGenero.TabIndex = 34;
            this.txtGenero.TabStop = false;
            // 
            // txt_anoLanzamiento
            // 
            this.txt_anoLanzamiento.BorderRadius = 13;
            this.txt_anoLanzamiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_anoLanzamiento.DefaultText = "";
            this.txt_anoLanzamiento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_anoLanzamiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_anoLanzamiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_anoLanzamiento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_anoLanzamiento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_anoLanzamiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_anoLanzamiento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_anoLanzamiento.Location = new System.Drawing.Point(465, 333);
            this.txt_anoLanzamiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_anoLanzamiento.Name = "txt_anoLanzamiento";
            this.txt_anoLanzamiento.PasswordChar = '\0';
            this.txt_anoLanzamiento.PlaceholderText = "";
            this.txt_anoLanzamiento.SelectedText = "";
            this.txt_anoLanzamiento.Size = new System.Drawing.Size(266, 37);
            this.txt_anoLanzamiento.TabIndex = 35;
            this.txt_anoLanzamiento.TabStop = false;
            // 
            // btn_crearArtista
            // 
            this.btn_crearArtista.BorderRadius = 13;
            this.btn_crearArtista.DefaultAutoSize = true;
            this.btn_crearArtista.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_crearArtista.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_crearArtista.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_crearArtista.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_crearArtista.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(191)))), ((int)(((byte)(137)))));
            this.btn_crearArtista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearArtista.ForeColor = System.Drawing.Color.White;
            this.btn_crearArtista.Location = new System.Drawing.Point(995, 224);
            this.btn_crearArtista.Name = "btn_crearArtista";
            this.btn_crearArtista.Size = new System.Drawing.Size(90, 35);
            this.btn_crearArtista.TabIndex = 36;
            this.btn_crearArtista.Text = "Crear";
            this.btn_crearArtista.Click += new System.EventHandler(this.btn_crearArtista_Click);
            // 
            // btn_verArtista
            // 
            this.btn_verArtista.BorderColor = System.Drawing.Color.Empty;
            this.btn_verArtista.BorderRadius = 13;
            this.btn_verArtista.DefaultAutoSize = true;
            this.btn_verArtista.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_verArtista.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_verArtista.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_verArtista.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_verArtista.FillColor = System.Drawing.Color.Goldenrod;
            this.btn_verArtista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verArtista.ForeColor = System.Drawing.Color.White;
            this.btn_verArtista.Location = new System.Drawing.Point(1100, 224);
            this.btn_verArtista.Name = "btn_verArtista";
            this.btn_verArtista.Size = new System.Drawing.Size(121, 35);
            this.btn_verArtista.TabIndex = 37;
            this.btn_verArtista.Text = "Ver Lista";
            this.btn_verArtista.Click += new System.EventHandler(this.btn_verArtista_Click);
            // 
            // btn_actualizarArtista
            // 
            this.btn_actualizarArtista.BorderRadius = 13;
            this.btn_actualizarArtista.DefaultAutoSize = true;
            this.btn_actualizarArtista.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_actualizarArtista.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_actualizarArtista.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_actualizarArtista.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_actualizarArtista.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.btn_actualizarArtista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizarArtista.ForeColor = System.Drawing.Color.White;
            this.btn_actualizarArtista.Location = new System.Drawing.Point(1235, 224);
            this.btn_actualizarArtista.Name = "btn_actualizarArtista";
            this.btn_actualizarArtista.Size = new System.Drawing.Size(134, 35);
            this.btn_actualizarArtista.TabIndex = 38;
            this.btn_actualizarArtista.Text = "Actualizar";
            this.btn_actualizarArtista.Click += new System.EventHandler(this.btn_actualizarArtista_Click);
            // 
            // btn_eliminarArtista
            // 
            this.btn_eliminarArtista.BorderRadius = 13;
            this.btn_eliminarArtista.DefaultAutoSize = true;
            this.btn_eliminarArtista.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminarArtista.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminarArtista.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_eliminarArtista.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_eliminarArtista.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btn_eliminarArtista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarArtista.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarArtista.Location = new System.Drawing.Point(1384, 224);
            this.btn_eliminarArtista.Name = "btn_eliminarArtista";
            this.btn_eliminarArtista.Size = new System.Drawing.Size(115, 35);
            this.btn_eliminarArtista.TabIndex = 39;
            this.btn_eliminarArtista.Text = "Eliminar";
            this.btn_eliminarArtista.Click += new System.EventHandler(this.btn_eliminarArtista_Click);
            // 
            // btn_elminarAlbum
            // 
            this.btn_elminarAlbum.BorderRadius = 13;
            this.btn_elminarAlbum.DefaultAutoSize = true;
            this.btn_elminarAlbum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_elminarAlbum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_elminarAlbum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_elminarAlbum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_elminarAlbum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btn_elminarAlbum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elminarAlbum.ForeColor = System.Drawing.Color.White;
            this.btn_elminarAlbum.Location = new System.Drawing.Point(1384, 333);
            this.btn_elminarAlbum.Name = "btn_elminarAlbum";
            this.btn_elminarAlbum.Size = new System.Drawing.Size(115, 35);
            this.btn_elminarAlbum.TabIndex = 43;
            this.btn_elminarAlbum.Text = "Eliminar";
            this.btn_elminarAlbum.Click += new System.EventHandler(this.btn_elminarAlbum_Click);
            // 
            // btn_actualizarAlbum
            // 
            this.btn_actualizarAlbum.BorderRadius = 13;
            this.btn_actualizarAlbum.DefaultAutoSize = true;
            this.btn_actualizarAlbum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_actualizarAlbum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_actualizarAlbum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_actualizarAlbum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_actualizarAlbum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.btn_actualizarAlbum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizarAlbum.ForeColor = System.Drawing.Color.White;
            this.btn_actualizarAlbum.Location = new System.Drawing.Point(1235, 333);
            this.btn_actualizarAlbum.Name = "btn_actualizarAlbum";
            this.btn_actualizarAlbum.Size = new System.Drawing.Size(134, 35);
            this.btn_actualizarAlbum.TabIndex = 42;
            this.btn_actualizarAlbum.Text = "Actualizar";
            this.btn_actualizarAlbum.Click += new System.EventHandler(this.btn_actualizarAlbum_Click);
            // 
            // btn_verAlbumes
            // 
            this.btn_verAlbumes.BorderColor = System.Drawing.Color.Empty;
            this.btn_verAlbumes.BorderRadius = 13;
            this.btn_verAlbumes.DefaultAutoSize = true;
            this.btn_verAlbumes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_verAlbumes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_verAlbumes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_verAlbumes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_verAlbumes.FillColor = System.Drawing.Color.Goldenrod;
            this.btn_verAlbumes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verAlbumes.ForeColor = System.Drawing.Color.White;
            this.btn_verAlbumes.Location = new System.Drawing.Point(1100, 333);
            this.btn_verAlbumes.Name = "btn_verAlbumes";
            this.btn_verAlbumes.Size = new System.Drawing.Size(121, 35);
            this.btn_verAlbumes.TabIndex = 41;
            this.btn_verAlbumes.Text = "Ver Lista";
            this.btn_verAlbumes.Click += new System.EventHandler(this.btn_verAlbumes_Click);
            // 
            // btn_crearAlbum
            // 
            this.btn_crearAlbum.BorderRadius = 13;
            this.btn_crearAlbum.DefaultAutoSize = true;
            this.btn_crearAlbum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_crearAlbum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_crearAlbum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_crearAlbum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_crearAlbum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(191)))), ((int)(((byte)(137)))));
            this.btn_crearAlbum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearAlbum.ForeColor = System.Drawing.Color.White;
            this.btn_crearAlbum.Location = new System.Drawing.Point(995, 333);
            this.btn_crearAlbum.Name = "btn_crearAlbum";
            this.btn_crearAlbum.Size = new System.Drawing.Size(90, 35);
            this.btn_crearAlbum.TabIndex = 40;
            this.btn_crearAlbum.Text = "Crear";
            this.btn_crearAlbum.Click += new System.EventHandler(this.btn_crearAlbum_Click);
            // 
            // btn_eliminarCancion
            // 
            this.btn_eliminarCancion.BorderRadius = 13;
            this.btn_eliminarCancion.DefaultAutoSize = true;
            this.btn_eliminarCancion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminarCancion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminarCancion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_eliminarCancion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_eliminarCancion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btn_eliminarCancion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarCancion.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarCancion.Location = new System.Drawing.Point(1384, 442);
            this.btn_eliminarCancion.Name = "btn_eliminarCancion";
            this.btn_eliminarCancion.Size = new System.Drawing.Size(115, 35);
            this.btn_eliminarCancion.TabIndex = 47;
            this.btn_eliminarCancion.Text = "Eliminar";
            this.btn_eliminarCancion.Click += new System.EventHandler(this.btn_eliminarCancion_Click);
            // 
            // btn_actualizarCancion
            // 
            this.btn_actualizarCancion.BorderRadius = 13;
            this.btn_actualizarCancion.DefaultAutoSize = true;
            this.btn_actualizarCancion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_actualizarCancion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_actualizarCancion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_actualizarCancion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_actualizarCancion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.btn_actualizarCancion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizarCancion.ForeColor = System.Drawing.Color.White;
            this.btn_actualizarCancion.Location = new System.Drawing.Point(1235, 442);
            this.btn_actualizarCancion.Name = "btn_actualizarCancion";
            this.btn_actualizarCancion.Size = new System.Drawing.Size(134, 35);
            this.btn_actualizarCancion.TabIndex = 46;
            this.btn_actualizarCancion.Text = "Actualizar";
            this.btn_actualizarCancion.Click += new System.EventHandler(this.btn_actualizarCancion_Click);
            // 
            // btn_verCanciones
            // 
            this.btn_verCanciones.BorderColor = System.Drawing.Color.Empty;
            this.btn_verCanciones.BorderRadius = 13;
            this.btn_verCanciones.DefaultAutoSize = true;
            this.btn_verCanciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_verCanciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_verCanciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_verCanciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_verCanciones.FillColor = System.Drawing.Color.Goldenrod;
            this.btn_verCanciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verCanciones.ForeColor = System.Drawing.Color.White;
            this.btn_verCanciones.Location = new System.Drawing.Point(1100, 442);
            this.btn_verCanciones.Name = "btn_verCanciones";
            this.btn_verCanciones.Size = new System.Drawing.Size(121, 35);
            this.btn_verCanciones.TabIndex = 45;
            this.btn_verCanciones.Text = "Ver Lista";
            this.btn_verCanciones.Click += new System.EventHandler(this.btn_verCanciones_Click);
            // 
            // btn_crearCancion
            // 
            this.btn_crearCancion.BorderRadius = 13;
            this.btn_crearCancion.DefaultAutoSize = true;
            this.btn_crearCancion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_crearCancion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_crearCancion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_crearCancion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_crearCancion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(191)))), ((int)(((byte)(137)))));
            this.btn_crearCancion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearCancion.ForeColor = System.Drawing.Color.White;
            this.btn_crearCancion.Location = new System.Drawing.Point(995, 442);
            this.btn_crearCancion.Name = "btn_crearCancion";
            this.btn_crearCancion.Size = new System.Drawing.Size(90, 35);
            this.btn_crearCancion.TabIndex = 44;
            this.btn_crearCancion.Text = "Crear";
            this.btn_crearCancion.Click += new System.EventHandler(this.btn_crearCancion_Click);
            // 
            // Id_Artista
            // 
            this.Id_Artista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Id_Artista.DefaultText = "";
            this.Id_Artista.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Id_Artista.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Id_Artista.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Id_Artista.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Id_Artista.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Id_Artista.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Id_Artista.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Id_Artista.Location = new System.Drawing.Point(290, 168);
            this.Id_Artista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Id_Artista.Name = "Id_Artista";
            this.Id_Artista.PasswordChar = '\0';
            this.Id_Artista.PlaceholderText = "";
            this.Id_Artista.SelectedText = "";
            this.Id_Artista.Size = new System.Drawing.Size(111, 27);
            this.Id_Artista.TabIndex = 48;
            this.Id_Artista.Visible = false;
            // 
            // Id_Album
            // 
            this.Id_Album.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Id_Album.DefaultText = "";
            this.Id_Album.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Id_Album.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Id_Album.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Id_Album.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Id_Album.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Id_Album.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Id_Album.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Id_Album.Location = new System.Drawing.Point(290, 278);
            this.Id_Album.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Id_Album.Name = "Id_Album";
            this.Id_Album.PasswordChar = '\0';
            this.Id_Album.PlaceholderText = "";
            this.Id_Album.SelectedText = "";
            this.Id_Album.Size = new System.Drawing.Size(32, 31);
            this.Id_Album.TabIndex = 49;
            this.Id_Album.Visible = false;
            // 
            // Id_Cancion
            // 
            this.Id_Cancion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Id_Cancion.DefaultText = "";
            this.Id_Cancion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Id_Cancion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Id_Cancion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Id_Cancion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Id_Cancion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Id_Cancion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Id_Cancion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Id_Cancion.Location = new System.Drawing.Point(290, 385);
            this.Id_Cancion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Id_Cancion.Name = "Id_Cancion";
            this.Id_Cancion.PasswordChar = '\0';
            this.Id_Cancion.PlaceholderText = "";
            this.Id_Cancion.SelectedText = "";
            this.Id_Cancion.Size = new System.Drawing.Size(32, 31);
            this.Id_Cancion.TabIndex = 50;
            this.Id_Cancion.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(67)))), ((int)(((byte)(123)))));
            this.label13.Location = new System.Drawing.Point(1269, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(256, 23);
            this.label13.TabIndex = 51;
            this.label13.Text = "M Michelle Salinas Tirado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1551, 668);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Id_Cancion);
            this.Controls.Add(this.Id_Album);
            this.Controls.Add(this.Id_Artista);
            this.Controls.Add(this.btn_eliminarCancion);
            this.Controls.Add(this.btn_actualizarCancion);
            this.Controls.Add(this.btn_verCanciones);
            this.Controls.Add(this.btn_crearCancion);
            this.Controls.Add(this.btn_elminarAlbum);
            this.Controls.Add(this.btn_actualizarAlbum);
            this.Controls.Add(this.btn_verAlbumes);
            this.Controls.Add(this.btn_crearAlbum);
            this.Controls.Add(this.btn_eliminarArtista);
            this.Controls.Add(this.btn_actualizarArtista);
            this.Controls.Add(this.btn_verArtista);
            this.Controls.Add(this.btn_crearArtista);
            this.Controls.Add(this.txt_anoLanzamiento);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboPais);
            this.Controls.Add(this.comboAlbum);
            this.Controls.Add(this.comboArtista);
            this.Controls.Add(this.DgvDatos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCancion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.Artista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArtista);
            this.Controls.Add(this.PanelTop);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelTop;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMaximize;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DataGridView DgvDatos;
        private Guna.UI2.WinForms.Guna2TextBox txtArtista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Artista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtAlbum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtDuracion;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtCancion;
        private Guna.UI2.WinForms.Guna2ComboBox comboArtista;
        private Guna.UI2.WinForms.Guna2ComboBox comboAlbum;
        private Guna.UI2.WinForms.Guna2ComboBox comboPais;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtGenero;
        private Guna.UI2.WinForms.Guna2TextBox txt_anoLanzamiento;
        private Guna.UI2.WinForms.Guna2TileButton btn_crearArtista;
        private Guna.UI2.WinForms.Guna2TileButton btn_verArtista;
        private Guna.UI2.WinForms.Guna2TileButton btn_actualizarArtista;
        private Guna.UI2.WinForms.Guna2TileButton btn_eliminarArtista;
        private Guna.UI2.WinForms.Guna2TileButton btn_elminarAlbum;
        private Guna.UI2.WinForms.Guna2TileButton btn_actualizarAlbum;
        private Guna.UI2.WinForms.Guna2TileButton btn_verAlbumes;
        private Guna.UI2.WinForms.Guna2TileButton btn_crearAlbum;
        private Guna.UI2.WinForms.Guna2TileButton btn_eliminarCancion;
        private Guna.UI2.WinForms.Guna2TileButton btn_actualizarCancion;
        private Guna.UI2.WinForms.Guna2TileButton btn_verCanciones;
        private Guna.UI2.WinForms.Guna2TileButton btn_crearCancion;
        private Guna.UI2.WinForms.Guna2TextBox Id_Artista;
        private Guna.UI2.WinForms.Guna2TextBox Id_Album;
        private Guna.UI2.WinForms.Guna2TextBox Id_Cancion;
        private System.Windows.Forms.Label label13;
    }
}

