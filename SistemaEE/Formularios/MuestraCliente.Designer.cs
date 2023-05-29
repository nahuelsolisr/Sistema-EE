namespace SistemaEE.Formularios
{
    partial class MuestraCliente
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
            dgvCliente = new DataGridView();
            btn_seleccionar = new DataGridViewButtonColumn();
            Column0 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txt_filtrar = new MaterialSkin.Controls.MaterialTextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToResizeColumns = false;
            dgvCliente.AllowUserToResizeRows = false;
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
            dgvCliente.Location = new Point(14, 141);
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
            dgvCliente.Size = new Size(673, 321);
            dgvCliente.TabIndex = 160;
            dgvCliente.CellClick += Seleccionar;
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
            // txt_filtrar
            // 
            txt_filtrar.AnimateReadOnly = false;
            txt_filtrar.BorderStyle = BorderStyle.None;
            txt_filtrar.Depth = 0;
            txt_filtrar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_filtrar.LeadingIcon = null;
            txt_filtrar.Location = new Point(312, 84);
            txt_filtrar.MaxLength = 50;
            txt_filtrar.MouseState = MaterialSkin.MouseState.OUT;
            txt_filtrar.Multiline = false;
            txt_filtrar.Name = "txt_filtrar";
            txt_filtrar.Size = new Size(316, 50);
            txt_filtrar.TabIndex = 162;
            txt_filtrar.Text = "";
            txt_filtrar.TrailingIcon = null;
            txt_filtrar.TextChanged += txt_filtrar_TextChanged;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 48;
            iconPictureBox1.Location = new Point(634, 84);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(53, 48);
            iconPictureBox1.TabIndex = 161;
            iconPictureBox1.TabStop = false;
            // 
            // MuestraCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 469);
            Controls.Add(txt_filtrar);
            Controls.Add(iconPictureBox1);
            Controls.Add(dgvCliente);
            Name = "MuestraCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".:  Clientes disponibles :.";
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
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
        private MaterialSkin.Controls.MaterialTextBox txt_filtrar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}