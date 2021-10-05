
namespace ConstruccionInterfaz
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mBAgregar = new MetroFramework.Controls.MetroButton();
            this.mCID = new MetroFramework.Controls.MetroComboBox();
            this.metroLaber1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mCProductos = new MetroFramework.Controls.MetroComboBox();
            this.mCOfertas = new MetroFramework.Controls.MetroComboBox();
            this.mCDescripcion = new MetroFramework.Controls.MetroComboBox();
            this.mBEliminar = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // mBAgregar
            // 
            this.mBAgregar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mBAgregar.Location = new System.Drawing.Point(431, 330);
            this.mBAgregar.Name = "mBAgregar";
            this.mBAgregar.Size = new System.Drawing.Size(75, 23);
            this.mBAgregar.TabIndex = 0;
            this.mBAgregar.Text = "Agregar";
            this.mBAgregar.UseSelectable = true;
            // 
            // mCID
            // 
            this.mCID.FormattingEnabled = true;
            this.mCID.ItemHeight = 23;
            this.mCID.Location = new System.Drawing.Point(212, 86);
            this.mCID.Name = "mCID";
            this.mCID.Size = new System.Drawing.Size(177, 29);
            this.mCID.TabIndex = 1;
            this.mCID.UseSelectable = true;
            // 
            // metroLaber1
            // 
            this.metroLaber1.AutoSize = true;
            this.metroLaber1.Location = new System.Drawing.Point(81, 96);
            this.metroLaber1.Name = "metroLaber1";
            this.metroLaber1.Size = new System.Drawing.Size(75, 19);
            this.metroLaber1.TabIndex = 2;
            this.metroLaber1.Text = "CatalogoID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(81, 144);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Productos";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(81, 201);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Ofertas";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(81, 257);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Descripcion";
            // 
            // mCProductos
            // 
            this.mCProductos.FormattingEnabled = true;
            this.mCProductos.ItemHeight = 23;
            this.mCProductos.Location = new System.Drawing.Point(212, 144);
            this.mCProductos.Name = "mCProductos";
            this.mCProductos.Size = new System.Drawing.Size(177, 29);
            this.mCProductos.TabIndex = 8;
            this.mCProductos.UseSelectable = true;
            // 
            // mCOfertas
            // 
            this.mCOfertas.FormattingEnabled = true;
            this.mCOfertas.ItemHeight = 23;
            this.mCOfertas.Location = new System.Drawing.Point(212, 201);
            this.mCOfertas.Name = "mCOfertas";
            this.mCOfertas.Size = new System.Drawing.Size(177, 29);
            this.mCOfertas.TabIndex = 9;
            this.mCOfertas.UseSelectable = true;
            // 
            // mCDescripcion
            // 
            this.mCDescripcion.FormattingEnabled = true;
            this.mCDescripcion.ItemHeight = 23;
            this.mCDescripcion.Location = new System.Drawing.Point(212, 257);
            this.mCDescripcion.Name = "mCDescripcion";
            this.mCDescripcion.Size = new System.Drawing.Size(177, 29);
            this.mCDescripcion.TabIndex = 10;
            this.mCDescripcion.UseSelectable = true;
            // 
            // mBEliminar
            // 
            this.mBEliminar.Location = new System.Drawing.Point(657, 330);
            this.mBEliminar.Name = "mBEliminar";
            this.mBEliminar.Size = new System.Drawing.Size(75, 23);
            this.mBEliminar.TabIndex = 11;
            this.mBEliminar.Text = "Eliminar";
            this.mBEliminar.UseSelectable = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(431, 86);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(301, 200);
            this.metroGrid1.TabIndex = 12;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.metroLabel1.Location = new System.Drawing.Point(81, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Catalogo";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.mBEliminar);
            this.Controls.Add(this.mCDescripcion);
            this.Controls.Add(this.mCOfertas);
            this.Controls.Add(this.mCProductos);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLaber1);
            this.Controls.Add(this.mCID);
            this.Controls.Add(this.mBAgregar);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mBAgregar;
        private MetroFramework.Controls.MetroComboBox mCID;
        private MetroFramework.Controls.MetroLabel metroLaber1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox mCProductos;
        private MetroFramework.Controls.MetroComboBox mCOfertas;
        private MetroFramework.Controls.MetroComboBox mCDescripcion;
        private MetroFramework.Controls.MetroButton mBEliminar;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}