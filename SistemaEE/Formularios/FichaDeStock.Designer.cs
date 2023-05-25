namespace SistemaEE.Formularios
{
    partial class FichaDeStock
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12 });
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1223, 150);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Cod_Producto";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre_Proucto";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Precio_Unitario";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Cantidad";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Precio_Unitario";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Total";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Cantidad";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Precio_Unitario";
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "Total";
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "Fecha";
            Column12.Name = "Column12";
            // 
            // FichaDeStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 469);
            Controls.Add(dataGridView1);
            Name = "FichaDeStock";
            Text = "FichaDeStock";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
    }
}