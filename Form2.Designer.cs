
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
            this.mbAgregar = new MetroFramework.Controls.MetroButton();
            this.label = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.mbEliminar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.txtOfertas = new System.Windows.Forms.TextBox();
            this.txtPrecios = new System.Windows.Forms.TextBox();
            this.dgtCatalogos = new System.Windows.Forms.DataGridView();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgtCatalogos)).BeginInit();
            this.SuspendLayout();
            // 
            // mbAgregar
            // 
            this.mbAgregar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mbAgregar.Location = new System.Drawing.Point(450, 318);
            this.mbAgregar.Name = "mbAgregar";
            this.mbAgregar.Size = new System.Drawing.Size(75, 23);
            this.mbAgregar.TabIndex = 0;
            this.mbAgregar.Text = "Agregar";
            this.mbAgregar.UseSelectable = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(81, 96);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(75, 19);
            this.label.TabIndex = 2;
            this.label.Text = "CatalogoID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ofertas";
            // 
            // mbEliminar
            // 
            this.mbEliminar.Location = new System.Drawing.Point(784, 318);
            this.mbEliminar.Name = "mbEliminar";
            this.mbEliminar.Size = new System.Drawing.Size(75, 23);
            this.mbEliminar.TabIndex = 11;
            this.mbEliminar.Text = "Eliminar";
            this.mbEliminar.UseSelectable = true;
            this.mbEliminar.Click += new System.EventHandler(this.mbEliminar_Click);
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
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(207, 96);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(193, 20);
            this.txtId.TabIndex = 15;
            // 
            // txtProductos
            // 
            this.txtProductos.Location = new System.Drawing.Point(207, 144);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(193, 20);
            this.txtProductos.TabIndex = 16;
            // 
            // txtOfertas
            // 
            this.txtOfertas.Location = new System.Drawing.Point(207, 201);
            this.txtOfertas.Name = "txtOfertas";
            this.txtOfertas.Size = new System.Drawing.Size(193, 20);
            this.txtOfertas.TabIndex = 17;
            // 
            // txtPrecios
            // 
            this.txtPrecios.Location = new System.Drawing.Point(207, 257);
            this.txtPrecios.Name = "txtPrecios";
            this.txtPrecios.Size = new System.Drawing.Size(193, 20);
            this.txtPrecios.TabIndex = 18;
            // 
            // dgtCatalogos
            // 
            this.dgtCatalogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtCatalogos.Location = new System.Drawing.Point(450, 96);
            this.dgtCatalogos.Name = "dgtCatalogos";
            this.dgtCatalogos.Size = new System.Drawing.Size(409, 181);
            this.dgtCatalogos.TabIndex = 19;
            this.dgtCatalogos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtCatalogos_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Precios";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgtCatalogos);
            this.Controls.Add(this.txtPrecios);
            this.Controls.Add(this.txtOfertas);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mbEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.mbAgregar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtCatalogos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbAgregar;
        private MetroFramework.Controls.MetroLabel label;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroButton mbEliminar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.TextBox txtOfertas;
        private System.Windows.Forms.TextBox txtPrecios;
        private System.Windows.Forms.DataGridView dgtCatalogos;
        private MetroFramework.Controls.MetroLabel label4;
    }
}