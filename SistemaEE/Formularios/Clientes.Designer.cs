namespace SistemaEE.Formularios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            dgvCliente = new DataGridView();
            btn_seleccionar = new DataGridViewButtonColumn();
            Column0 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            pnl_detalle = new Panel();
            cmb_condicion = new MaterialSkin.Controls.MaterialComboBox();
            txt_cuit = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            iconPictureBox10 = new FontAwesome.Sharp.IconPictureBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            iconPictureBox11 = new FontAwesome.Sharp.IconPictureBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            iconPictureBox12 = new FontAwesome.Sharp.IconPictureBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            iconPictureBox13 = new FontAwesome.Sharp.IconPictureBox();
            txt_mail = new MaterialSkin.Controls.MaterialTextBox();
            txt_direccion = new MaterialSkin.Controls.MaterialTextBox();
            txt_nombre = new MaterialSkin.Controls.MaterialTextBox();
            btn_editar = new MaterialSkin.Controls.MaterialButton();
            btn_eliminar = new MaterialSkin.Controls.MaterialButton();
            btn_agregar = new MaterialSkin.Controls.MaterialButton();
            panel1 = new Panel();
            txt_filtrar = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btn_cargaMasiva = new MaterialSkin.Controls.MaterialButton();
            btn_descargaPlantilla = new MaterialSkin.Controls.MaterialButton();
            btn_limpiar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            pnl_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox13).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToResizeColumns = false;
            dgvCliente.AllowUserToResizeRows = false;
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvCliente.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { btn_seleccionar, Column0, Column1, Column2, Column3, Column4 });
            dgvCliente.Location = new Point(370, 128);
            dgvCliente.Margin = new Padding(4);
            dgvCliente.MultiSelect = false;
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.Size = new Size(669, 405);
            dgvCliente.TabIndex = 124;
            dgvCliente.CellClick += Cell_Click;
            // 
            // btn_seleccionar
            // 
            btn_seleccionar.HeaderText = "";
            btn_seleccionar.Name = "btn_seleccionar";
            btn_seleccionar.ReadOnly = true;
            btn_seleccionar.Resizable = DataGridViewTriState.False;
            btn_seleccionar.Width = 25;
            // 
            // Column0
            // 
            Column0.HeaderText = "Cuit";
            Column0.Name = "Column0";
            Column0.ReadOnly = true;
            Column0.Width = 66;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 95;
            // 
            // Column2
            // 
            Column2.HeaderText = "Dirección";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 103;
            // 
            // Column3
            // 
            Column3.HeaderText = "Mail";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 66;
            // 
            // Column4
            // 
            Column4.HeaderText = "Condición";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 108;
            // 
            // pnl_detalle
            // 
            pnl_detalle.Controls.Add(cmb_condicion);
            pnl_detalle.Controls.Add(txt_cuit);
            pnl_detalle.Controls.Add(materialLabel7);
            pnl_detalle.Controls.Add(iconPictureBox4);
            pnl_detalle.Controls.Add(materialLabel6);
            pnl_detalle.Controls.Add(iconPictureBox10);
            pnl_detalle.Controls.Add(materialLabel5);
            pnl_detalle.Controls.Add(iconPictureBox11);
            pnl_detalle.Controls.Add(materialLabel4);
            pnl_detalle.Controls.Add(iconPictureBox12);
            pnl_detalle.Controls.Add(materialLabel3);
            pnl_detalle.Controls.Add(iconPictureBox13);
            pnl_detalle.Controls.Add(txt_mail);
            pnl_detalle.Controls.Add(txt_direccion);
            pnl_detalle.Controls.Add(txt_nombre);
            pnl_detalle.Location = new Point(10, 119);
            pnl_detalle.Name = "pnl_detalle";
            pnl_detalle.Size = new Size(353, 414);
            pnl_detalle.TabIndex = 165;
            // 
            // cmb_condicion
            // 
            cmb_condicion.AutoResize = false;
            cmb_condicion.BackColor = Color.FromArgb(255, 255, 255);
            cmb_condicion.Depth = 0;
            cmb_condicion.DrawMode = DrawMode.OwnerDrawVariable;
            cmb_condicion.DropDownHeight = 174;
            cmb_condicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_condicion.DropDownWidth = 121;
            cmb_condicion.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmb_condicion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmb_condicion.FormattingEnabled = true;
            cmb_condicion.IntegralHeight = false;
            cmb_condicion.ItemHeight = 43;
            cmb_condicion.Items.AddRange(new object[] { "Responsable Inscripto", "Monotributista ", "Consumidor final" });
            cmb_condicion.Location = new Point(58, 358);
            cmb_condicion.MaxDropDownItems = 4;
            cmb_condicion.MouseState = MaterialSkin.MouseState.OUT;
            cmb_condicion.Name = "cmb_condicion";
            cmb_condicion.Size = new Size(292, 49);
            cmb_condicion.StartIndex = 0;
            cmb_condicion.TabIndex = 153;
            // 
            // txt_cuit
            // 
            txt_cuit.AnimateReadOnly = false;
            txt_cuit.BorderStyle = BorderStyle.None;
            txt_cuit.Depth = 0;
            txt_cuit.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_cuit.LeadingIcon = null;
            txt_cuit.Location = new Point(59, 27);
            txt_cuit.MaxLength = 50;
            txt_cuit.MouseState = MaterialSkin.MouseState.OUT;
            txt_cuit.Multiline = false;
            txt_cuit.Name = "txt_cuit";
            txt_cuit.Size = new Size(291, 50);
            txt_cuit.TabIndex = 145;
            txt_cuit.Text = "";
            txt_cuit.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(58, 326);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(88, 19);
            materialLabel7.TabIndex = 163;
            materialLabel7.Text = "CONDICIÓN:";
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.WhiteSmoke;
            iconPictureBox4.ForeColor = Color.SteelBlue;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.EnvelopeSquare;
            iconPictureBox4.IconColor = Color.SteelBlue;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 47;
            iconPictureBox4.Location = new Point(8, 275);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(47, 50);
            iconPictureBox4.TabIndex = 135;
            iconPictureBox4.TabStop = false;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(58, 245);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(42, 19);
            materialLabel6.TabIndex = 162;
            materialLabel6.Text = "MAIL:";
            // 
            // iconPictureBox10
            // 
            iconPictureBox10.BackColor = Color.WhiteSmoke;
            iconPictureBox10.ForeColor = Color.SteelBlue;
            iconPictureBox10.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconPictureBox10.IconColor = Color.SteelBlue;
            iconPictureBox10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox10.IconSize = 50;
            iconPictureBox10.Location = new Point(5, 193);
            iconPictureBox10.Name = "iconPictureBox10";
            iconPictureBox10.Size = new Size(50, 50);
            iconPictureBox10.TabIndex = 136;
            iconPictureBox10.TabStop = false;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(59, 166);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(83, 19);
            materialLabel5.TabIndex = 161;
            materialLabel5.Text = "DOMICILIO:";
            // 
            // iconPictureBox11
            // 
            iconPictureBox11.BackColor = Color.WhiteSmoke;
            iconPictureBox11.ForeColor = Color.SteelBlue;
            iconPictureBox11.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconPictureBox11.IconColor = Color.SteelBlue;
            iconPictureBox11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox11.IconSize = 48;
            iconPictureBox11.Location = new Point(10, 35);
            iconPictureBox11.Name = "iconPictureBox11";
            iconPictureBox11.Size = new Size(48, 52);
            iconPictureBox11.TabIndex = 137;
            iconPictureBox11.TabStop = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(64, 85);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(70, 19);
            materialLabel4.TabIndex = 160;
            materialLabel4.Text = "NOMBRE:";
            // 
            // iconPictureBox12
            // 
            iconPictureBox12.BackColor = Color.WhiteSmoke;
            iconPictureBox12.ForeColor = Color.SteelBlue;
            iconPictureBox12.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            iconPictureBox12.IconColor = Color.SteelBlue;
            iconPictureBox12.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox12.IconSize = 47;
            iconPictureBox12.Location = new Point(9, 357);
            iconPictureBox12.Name = "iconPictureBox12";
            iconPictureBox12.Size = new Size(47, 50);
            iconPictureBox12.TabIndex = 139;
            iconPictureBox12.TabStop = false;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(59, 5);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(39, 19);
            materialLabel3.TabIndex = 159;
            materialLabel3.Text = "CUIT:";
            // 
            // iconPictureBox13
            // 
            iconPictureBox13.BackColor = Color.WhiteSmoke;
            iconPictureBox13.ForeColor = Color.SteelBlue;
            iconPictureBox13.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox13.IconColor = Color.SteelBlue;
            iconPictureBox13.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox13.IconSize = 48;
            iconPictureBox13.Location = new Point(9, 113);
            iconPictureBox13.Name = "iconPictureBox13";
            iconPictureBox13.Size = new Size(48, 50);
            iconPictureBox13.TabIndex = 140;
            iconPictureBox13.TabStop = false;
            // 
            // txt_mail
            // 
            txt_mail.AnimateReadOnly = false;
            txt_mail.BorderStyle = BorderStyle.None;
            txt_mail.Depth = 0;
            txt_mail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_mail.LeadingIcon = null;
            txt_mail.Location = new Point(59, 267);
            txt_mail.MaxLength = 50;
            txt_mail.MouseState = MaterialSkin.MouseState.OUT;
            txt_mail.Multiline = false;
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(291, 50);
            txt_mail.TabIndex = 147;
            txt_mail.Text = "";
            txt_mail.TrailingIcon = null;
            // 
            // txt_direccion
            // 
            txt_direccion.AnimateReadOnly = false;
            txt_direccion.BorderStyle = BorderStyle.None;
            txt_direccion.Depth = 0;
            txt_direccion.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_direccion.LeadingIcon = null;
            txt_direccion.Location = new Point(59, 188);
            txt_direccion.MaxLength = 50;
            txt_direccion.MouseState = MaterialSkin.MouseState.OUT;
            txt_direccion.Multiline = false;
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(292, 50);
            txt_direccion.TabIndex = 148;
            txt_direccion.Text = "";
            txt_direccion.TrailingIcon = null;
            // 
            // txt_nombre
            // 
            txt_nombre.AnimateReadOnly = false;
            txt_nombre.BorderStyle = BorderStyle.None;
            txt_nombre.Depth = 0;
            txt_nombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_nombre.LeadingIcon = null;
            txt_nombre.Location = new Point(58, 107);
            txt_nombre.MaxLength = 50;
            txt_nombre.MouseState = MaterialSkin.MouseState.OUT;
            txt_nombre.Multiline = false;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(292, 50);
            txt_nombre.TabIndex = 149;
            txt_nombre.Text = "";
            txt_nombre.TrailingIcon = null;
            // 
            // btn_editar
            // 
            btn_editar.AutoSize = false;
            btn_editar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_editar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_editar.Depth = 0;
            btn_editar.HighEmphasis = true;
            btn_editar.Icon = (Image)resources.GetObject("btn_editar.Icon");
            btn_editar.Location = new Point(131, 575);
            btn_editar.Margin = new Padding(4, 6, 4, 6);
            btn_editar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_editar.Name = "btn_editar";
            btn_editar.NoAccentTextColor = Color.Empty;
            btn_editar.Size = new Size(113, 36);
            btn_editar.TabIndex = 158;
            btn_editar.Text = "Editar";
            btn_editar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_editar.UseAccentColor = false;
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.AutoSize = false;
            btn_eliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_eliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_eliminar.Depth = 0;
            btn_eliminar.HighEmphasis = true;
            btn_eliminar.Icon = (Image)resources.GetObject("btn_eliminar.Icon");
            btn_eliminar.Location = new Point(253, 575);
            btn_eliminar.Margin = new Padding(4, 6, 4, 6);
            btn_eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.NoAccentTextColor = Color.Empty;
            btn_eliminar.Size = new Size(113, 36);
            btn_eliminar.TabIndex = 154;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_eliminar.UseAccentColor = false;
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.AutoSize = false;
            btn_agregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_agregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_agregar.Depth = 0;
            btn_agregar.HighEmphasis = true;
            btn_agregar.Icon = (Image)resources.GetObject("btn_agregar.Icon");
            btn_agregar.Location = new Point(10, 575);
            btn_agregar.Margin = new Padding(4, 6, 4, 6);
            btn_agregar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_agregar.Name = "btn_agregar";
            btn_agregar.NoAccentTextColor = Color.Empty;
            btn_agregar.Size = new Size(113, 36);
            btn_agregar.TabIndex = 152;
            btn_agregar.Text = "Agregar";
            btn_agregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_agregar.UseAccentColor = false;
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_filtrar);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(10, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 54);
            panel1.TabIndex = 166;
            // 
            // txt_filtrar
            // 
            txt_filtrar.AnimateReadOnly = false;
            txt_filtrar.BorderStyle = BorderStyle.None;
            txt_filtrar.Depth = 0;
            txt_filtrar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_filtrar.LeadingIcon = null;
            txt_filtrar.Location = new Point(645, 3);
            txt_filtrar.MaxLength = 50;
            txt_filtrar.MouseState = MaterialSkin.MouseState.OUT;
            txt_filtrar.Multiline = false;
            txt_filtrar.Name = "txt_filtrar";
            txt_filtrar.Size = new Size(316, 50);
            txt_filtrar.TabIndex = 152;
            txt_filtrar.Text = "";
            txt_filtrar.TrailingIcon = null;
            txt_filtrar.TextChanged += txt_filtrar_TextChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 5);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(158, 19);
            materialLabel1.TabIndex = 150;
            materialLabel1.Text = "DETALLE DE CLIENTE";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(375, 5);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(144, 19);
            materialLabel2.TabIndex = 151;
            materialLabel2.Text = "LISTA DE CLIENTES";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox1.IconColor = Color.SteelBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 48;
            iconPictureBox1.Location = new Point(967, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(53, 48);
            iconPictureBox1.TabIndex = 141;
            iconPictureBox1.TabStop = false;
            // 
            // btn_cargaMasiva
            // 
            btn_cargaMasiva.AutoSize = false;
            btn_cargaMasiva.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_cargaMasiva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_cargaMasiva.Depth = 0;
            btn_cargaMasiva.Enabled = false;
            btn_cargaMasiva.HighEmphasis = true;
            btn_cargaMasiva.Icon = (Image)resources.GetObject("btn_cargaMasiva.Icon");
            btn_cargaMasiva.Location = new Point(892, 575);
            btn_cargaMasiva.Margin = new Padding(4, 6, 4, 6);
            btn_cargaMasiva.MouseState = MaterialSkin.MouseState.HOVER;
            btn_cargaMasiva.Name = "btn_cargaMasiva";
            btn_cargaMasiva.NoAccentTextColor = Color.Empty;
            btn_cargaMasiva.Size = new Size(147, 36);
            btn_cargaMasiva.TabIndex = 170;
            btn_cargaMasiva.Text = "Carga masiva";
            btn_cargaMasiva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_cargaMasiva.UseAccentColor = false;
            btn_cargaMasiva.UseVisualStyleBackColor = true;
            // 
            // btn_descargaPlantilla
            // 
            btn_descargaPlantilla.AutoSize = false;
            btn_descargaPlantilla.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_descargaPlantilla.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_descargaPlantilla.Depth = 0;
            btn_descargaPlantilla.HighEmphasis = true;
            btn_descargaPlantilla.Icon = (Image)resources.GetObject("btn_descargaPlantilla.Icon");
            btn_descargaPlantilla.Location = new Point(668, 575);
            btn_descargaPlantilla.Margin = new Padding(4, 6, 4, 6);
            btn_descargaPlantilla.MouseState = MaterialSkin.MouseState.HOVER;
            btn_descargaPlantilla.Name = "btn_descargaPlantilla";
            btn_descargaPlantilla.NoAccentTextColor = Color.Empty;
            btn_descargaPlantilla.Size = new Size(211, 36);
            btn_descargaPlantilla.TabIndex = 172;
            btn_descargaPlantilla.Text = "Descargar plantilla";
            btn_descargaPlantilla.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_descargaPlantilla.UseAccentColor = false;
            btn_descargaPlantilla.UseVisualStyleBackColor = true;
            btn_descargaPlantilla.Click += btn_descargaPlantilla_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.AutoSize = false;
            btn_limpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_limpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_limpiar.Depth = 0;
            btn_limpiar.HighEmphasis = true;
            btn_limpiar.Icon = (Image)resources.GetObject("btn_limpiar.Icon");
            btn_limpiar.Location = new Point(370, 575);
            btn_limpiar.Margin = new Padding(4, 6, 4, 6);
            btn_limpiar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.NoAccentTextColor = Color.Empty;
            btn_limpiar.Size = new Size(113, 36);
            btn_limpiar.TabIndex = 178;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_limpiar.UseAccentColor = false;
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 620);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_cargaMasiva);
            Controls.Add(panel1);
            Controls.Add(pnl_detalle);
            Controls.Add(dgvCliente);
            Controls.Add(btn_editar);
            Controls.Add(btn_descargaPlantilla);
            Controls.Add(btn_agregar);
            Controls.Add(btn_eliminar);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Clientes :.";
            FormClosed += Clientes_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            pnl_detalle.ResumeLayout(false);
            pnl_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox13).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvCliente;
        private DataGridViewButtonColumn btn_seleccionar;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Panel pnl_detalle;
        private MaterialSkin.Controls.MaterialTextBox txt_cuit;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private MaterialSkin.Controls.MaterialButton btn_editar;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton btn_eliminar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox10;
        private MaterialSkin.Controls.MaterialButton btn_agregar;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox11;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox12;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox13;
        private MaterialSkin.Controls.MaterialTextBox txt_mail;
        private MaterialSkin.Controls.MaterialTextBox txt_direccion;
        private MaterialSkin.Controls.MaterialTextBox txt_nombre;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txt_filtrar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MaterialSkin.Controls.MaterialComboBox cmb_condicion;
        private MaterialSkin.Controls.MaterialButton btn_cargaMasiva;
        private MaterialSkin.Controls.MaterialButton btn_descargaPlantilla;
        private MaterialSkin.Controls.MaterialButton btn_limpiar;
    }
}