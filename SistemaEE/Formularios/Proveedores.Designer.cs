namespace SistemaEE.Formularios
{
    partial class Proveedores
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
            groupBox1 = new GroupBox();
            dgvProveedor = new DataGridView();
            btn_seleccionar = new DataGridViewButtonColumn();
            Column0 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txt_filtrarGrilla = new TextBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            txt_cuit = new MaterialSkin.Controls.MaterialTextBox();
            txt_condicion = new MaterialSkin.Controls.MaterialTextBox();
            txt_mail = new MaterialSkin.Controls.MaterialTextBox();
            txt_domicilio = new MaterialSkin.Controls.MaterialTextBox();
            txt_nombre = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            btn_agregar = new MaterialSkin.Controls.MaterialButton();
            btn_eliminar = new MaterialSkin.Controls.MaterialButton();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            btn_editar = new MaterialSkin.Controls.MaterialButton();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(385, 99);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(15, 514);
            groupBox1.TabIndex = 121;
            groupBox1.TabStop = false;
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToResizeColumns = false;
            dgvProveedor.AllowUserToResizeRows = false;
            dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProveedor.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { btn_seleccionar, Column0, Column1, Column2, Column3, Column4 });
            dgvProveedor.Location = new Point(408, 139);
            dgvProveedor.Margin = new Padding(4);
            dgvProveedor.MultiSelect = false;
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.ReadOnly = true;
            dgvProveedor.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dgvProveedor.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvProveedor.RowTemplate.Height = 25;
            dgvProveedor.Size = new Size(625, 474);
            dgvProveedor.TabIndex = 123;
            dgvProveedor.CellClick += Cell_Click;
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
            Column2.HeaderText = "Domicilio";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 104;
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
            // txt_filtrarGrilla
            // 
            txt_filtrarGrilla.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_filtrarGrilla.Location = new Point(664, 99);
            txt_filtrarGrilla.Margin = new Padding(4);
            txt_filtrarGrilla.Name = "txt_filtrarGrilla";
            txt_filtrarGrilla.Size = new Size(318, 36);
            txt_filtrarGrilla.TabIndex = 134;
            txt_filtrarGrilla.TextChanged += txt_filtrarGrilla_TextChanged;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.WhiteSmoke;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 48;
            iconPictureBox3.Location = new Point(10, 45);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(48, 52);
            iconPictureBox3.TabIndex = 137;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.WhiteSmoke;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 50;
            iconPictureBox2.Location = new Point(5, 203);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(50, 50);
            iconPictureBox2.TabIndex = 136;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.EnvelopeSquare;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 47;
            iconPictureBox1.Location = new Point(8, 285);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(47, 50);
            iconPictureBox1.TabIndex = 135;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.WhiteSmoke;
            iconPictureBox5.ForeColor = SystemColors.ControlText;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            iconPictureBox5.IconColor = SystemColors.ControlText;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 47;
            iconPictureBox5.Location = new Point(9, 367);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(47, 50);
            iconPictureBox5.TabIndex = 139;
            iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.WhiteSmoke;
            iconPictureBox6.ForeColor = SystemColors.ControlText;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox6.IconColor = SystemColors.ControlText;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 48;
            iconPictureBox6.Location = new Point(9, 123);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(48, 50);
            iconPictureBox6.TabIndex = 140;
            iconPictureBox6.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.WhiteSmoke;
            iconPictureBox4.ForeColor = SystemColors.ControlText;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox4.IconColor = SystemColors.ControlText;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 36;
            iconPictureBox4.Location = new Point(989, 99);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(42, 36);
            iconPictureBox4.TabIndex = 141;
            iconPictureBox4.TabStop = false;
            // 
            // txt_cuit
            // 
            txt_cuit.AnimateReadOnly = false;
            txt_cuit.BorderStyle = BorderStyle.None;
            txt_cuit.Depth = 0;
            txt_cuit.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_cuit.LeadingIcon = null;
            txt_cuit.Location = new Point(59, 37);
            txt_cuit.MaxLength = 50;
            txt_cuit.MouseState = MaterialSkin.MouseState.OUT;
            txt_cuit.Multiline = false;
            txt_cuit.Name = "txt_cuit";
            txt_cuit.Size = new Size(295, 50);
            txt_cuit.TabIndex = 145;
            txt_cuit.Text = "";
            txt_cuit.TrailingIcon = null;
            // 
            // txt_condicion
            // 
            txt_condicion.AnimateReadOnly = false;
            txt_condicion.BorderStyle = BorderStyle.None;
            txt_condicion.Depth = 0;
            txt_condicion.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_condicion.LeadingIcon = null;
            txt_condicion.Location = new Point(58, 358);
            txt_condicion.MaxLength = 50;
            txt_condicion.MouseState = MaterialSkin.MouseState.OUT;
            txt_condicion.Multiline = false;
            txt_condicion.Name = "txt_condicion";
            txt_condicion.Size = new Size(295, 50);
            txt_condicion.TabIndex = 146;
            txt_condicion.Text = "";
            txt_condicion.TrailingIcon = null;
            // 
            // txt_mail
            // 
            txt_mail.AnimateReadOnly = false;
            txt_mail.BorderStyle = BorderStyle.None;
            txt_mail.Depth = 0;
            txt_mail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_mail.LeadingIcon = null;
            txt_mail.Location = new Point(59, 277);
            txt_mail.MaxLength = 50;
            txt_mail.MouseState = MaterialSkin.MouseState.OUT;
            txt_mail.Multiline = false;
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(295, 50);
            txt_mail.TabIndex = 147;
            txt_mail.Text = "";
            txt_mail.TrailingIcon = null;
            // 
            // txt_domicilio
            // 
            txt_domicilio.AnimateReadOnly = false;
            txt_domicilio.BorderStyle = BorderStyle.None;
            txt_domicilio.Depth = 0;
            txt_domicilio.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_domicilio.LeadingIcon = null;
            txt_domicilio.Location = new Point(59, 198);
            txt_domicilio.MaxLength = 50;
            txt_domicilio.MouseState = MaterialSkin.MouseState.OUT;
            txt_domicilio.Multiline = false;
            txt_domicilio.Name = "txt_domicilio";
            txt_domicilio.Size = new Size(295, 50);
            txt_domicilio.TabIndex = 148;
            txt_domicilio.Text = "";
            txt_domicilio.TrailingIcon = null;
            // 
            // txt_nombre
            // 
            txt_nombre.AnimateReadOnly = false;
            txt_nombre.BorderStyle = BorderStyle.None;
            txt_nombre.Depth = 0;
            txt_nombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_nombre.LeadingIcon = null;
            txt_nombre.Location = new Point(58, 117);
            txt_nombre.MaxLength = 50;
            txt_nombre.MouseState = MaterialSkin.MouseState.OUT;
            txt_nombre.Multiline = false;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(295, 50);
            txt_nombre.TabIndex = 149;
            txt_nombre.Text = "";
            txt_nombre.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(10, 116);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(196, 19);
            materialLabel1.TabIndex = 150;
            materialLabel1.Text = "DETALLE DEL PROVEEDOR";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(408, 116);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(182, 19);
            materialLabel2.TabIndex = 151;
            materialLabel2.Text = "LISTA DE PROVEEDORES";
            // 
            // btn_agregar
            // 
            btn_agregar.AutoSize = false;
            btn_agregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_agregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_agregar.Depth = 0;
            btn_agregar.HighEmphasis = true;
            btn_agregar.Icon = null;
            btn_agregar.Location = new Point(42, 577);
            btn_agregar.Margin = new Padding(4, 6, 4, 6);
            btn_agregar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_agregar.Name = "btn_agregar";
            btn_agregar.NoAccentTextColor = Color.Empty;
            btn_agregar.Size = new Size(75, 36);
            btn_agregar.TabIndex = 152;
            btn_agregar.Text = "Agregar";
            btn_agregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_agregar.UseAccentColor = false;
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.AutoSize = false;
            btn_eliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_eliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_eliminar.Depth = 0;
            btn_eliminar.HighEmphasis = true;
            btn_eliminar.Icon = null;
            btn_eliminar.Location = new Point(289, 577);
            btn_eliminar.Margin = new Padding(4, 6, 4, 6);
            btn_eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.NoAccentTextColor = Color.Empty;
            btn_eliminar.Size = new Size(75, 36);
            btn_eliminar.TabIndex = 154;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_eliminar.UseAccentColor = false;
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.BackColor = SystemColors.Control;
            iconPictureBox7.ForeColor = SystemColors.ControlText;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            iconPictureBox7.IconColor = SystemColors.ControlText;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox7.IconSize = 36;
            iconPictureBox7.Location = new Point(10, 577);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(36, 36);
            iconPictureBox7.TabIndex = 155;
            iconPictureBox7.TabStop = false;
            // 
            // iconPictureBox8
            // 
            iconPictureBox8.BackColor = SystemColors.Control;
            iconPictureBox8.ForeColor = SystemColors.ControlText;
            iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            iconPictureBox8.IconColor = SystemColors.ControlText;
            iconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox8.IconSize = 36;
            iconPictureBox8.Location = new Point(124, 577);
            iconPictureBox8.Name = "iconPictureBox8";
            iconPictureBox8.Size = new Size(36, 36);
            iconPictureBox8.TabIndex = 156;
            iconPictureBox8.TabStop = false;
            // 
            // iconPictureBox9
            // 
            iconPictureBox9.BackColor = SystemColors.Control;
            iconPictureBox9.ForeColor = SystemColors.ControlText;
            iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            iconPictureBox9.IconColor = SystemColors.ControlText;
            iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox9.IconSize = 36;
            iconPictureBox9.Location = new Point(253, 577);
            iconPictureBox9.Name = "iconPictureBox9";
            iconPictureBox9.Size = new Size(36, 36);
            iconPictureBox9.TabIndex = 157;
            iconPictureBox9.TabStop = false;
            // 
            // btn_editar
            // 
            btn_editar.AutoSize = false;
            btn_editar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_editar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_editar.Depth = 0;
            btn_editar.HighEmphasis = true;
            btn_editar.Icon = null;
            btn_editar.Location = new Point(160, 577);
            btn_editar.Margin = new Padding(4, 6, 4, 6);
            btn_editar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_editar.Name = "btn_editar";
            btn_editar.NoAccentTextColor = Color.Empty;
            btn_editar.Size = new Size(86, 36);
            btn_editar.TabIndex = 158;
            btn_editar.Text = "Editar";
            btn_editar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_editar.UseAccentColor = false;
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(59, 15);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(39, 19);
            materialLabel3.TabIndex = 159;
            materialLabel3.Text = "CUIT:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(64, 95);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(70, 19);
            materialLabel4.TabIndex = 160;
            materialLabel4.Text = "NOMBRE:";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(59, 176);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(83, 19);
            materialLabel5.TabIndex = 161;
            materialLabel5.Text = "DOMICILIO:";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(58, 255);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(42, 19);
            materialLabel6.TabIndex = 162;
            materialLabel6.Text = "MAIL:";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(58, 336);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(88, 19);
            materialLabel7.TabIndex = 163;
            materialLabel7.Text = "CONDICIÓN:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_cuit);
            panel1.Controls.Add(materialLabel7);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(materialLabel6);
            panel1.Controls.Add(iconPictureBox2);
            panel1.Controls.Add(materialLabel5);
            panel1.Controls.Add(iconPictureBox3);
            panel1.Controls.Add(materialLabel4);
            panel1.Controls.Add(iconPictureBox5);
            panel1.Controls.Add(materialLabel3);
            panel1.Controls.Add(iconPictureBox6);
            panel1.Controls.Add(txt_condicion);
            panel1.Controls.Add(txt_mail);
            panel1.Controls.Add(txt_domicilio);
            panel1.Controls.Add(txt_nombre);
            panel1.Location = new Point(10, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 418);
            panel1.TabIndex = 164;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 620);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(btn_editar);
            Controls.Add(iconPictureBox9);
            Controls.Add(iconPictureBox8);
            Controls.Add(iconPictureBox7);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_agregar);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(iconPictureBox4);
            Controls.Add(txt_filtrarGrilla);
            Controls.Add(dgvProveedor);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Proveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proveedores";
            Load += Proveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label7;
        private DataGridView dgvProveedor;
        private DataGridViewButtonColumn btn_seleccionar;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox txt_filtrarGrilla;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconButton btn_modi;
        private FontAwesome.Sharp.IconButton btn_alta;
        private FontAwesome.Sharp.IconButton btn_baja;
        private MaterialSkin.Controls.MaterialTextBox txt_cuit;
        private MaterialSkin.Controls.MaterialTextBox txt_condicion;
        private MaterialSkin.Controls.MaterialTextBox txt_mail;
        private MaterialSkin.Controls.MaterialTextBox txt_domicilio;
        private MaterialSkin.Controls.MaterialTextBox txt_nombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btn_agregar;

        private MaterialSkin.Controls.MaterialButton btn_eliminar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private MaterialSkin.Controls.MaterialButton btn_editar;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private Panel panel1;
    }
}