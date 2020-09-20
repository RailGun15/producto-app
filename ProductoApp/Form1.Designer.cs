namespace ProductoApp
{
    partial class formArticulos
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.filterMarca = new System.Windows.Forms.ComboBox();
            this.filterCategoria = new System.Windows.Forms.ComboBox();
            this.filterNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFilterCategoria = new System.Windows.Forms.Label();
            this.lblfilterNombre = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(26, 87);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(476, 173);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.SelectionChanged += new System.EventHandler(this.dgvLista_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(199, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Administración de Artículos";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditar.Location = new System.Drawing.Point(26, 266);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Location = new System.Drawing.Point(124, 266);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(322, 266);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCargar.Size = new System.Drawing.Size(180, 23);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar Articulos";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(26, 305);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 36);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // pbArticulo
            // 
            this.pbArticulo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbArticulo.Location = new System.Drawing.Point(523, 87);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(184, 173);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 10;
            this.pbArticulo.TabStop = false;
            // 
            // filterMarca
            // 
            this.filterMarca.FormattingEnabled = true;
            this.filterMarca.Location = new System.Drawing.Point(74, 52);
            this.filterMarca.Name = "filterMarca";
            this.filterMarca.Size = new System.Drawing.Size(113, 21);
            this.filterMarca.TabIndex = 18;
            this.filterMarca.SelectionChangeCommitted += new System.EventHandler(this.filterMarca_TextChanged);
            this.filterMarca.Click += new System.EventHandler(this.filterMarca_Click);
            // 
            // filterCategoria
            // 
            this.filterCategoria.FormattingEnabled = true;
            this.filterCategoria.Location = new System.Drawing.Point(270, 51);
            this.filterCategoria.Name = "filterCategoria";
            this.filterCategoria.Size = new System.Drawing.Size(106, 21);
            this.filterCategoria.TabIndex = 19;
            this.filterCategoria.TextChanged += new System.EventHandler(this.filterCategoria_TextChanged);
            this.filterCategoria.Click += new System.EventHandler(this.filterCategoria_Click);
            // 
            // filterNombre
            // 
            this.filterNombre.Location = new System.Drawing.Point(450, 52);
            this.filterNombre.Name = "filterNombre";
            this.filterNombre.Size = new System.Drawing.Size(187, 20);
            this.filterNombre.TabIndex = 20;
            this.filterNombre.TextChanged += new System.EventHandler(this.filterNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Por Marca";
            // 
            // lblFilterCategoria
            // 
            this.lblFilterCategoria.AutoSize = true;
            this.lblFilterCategoria.Location = new System.Drawing.Point(193, 55);
            this.lblFilterCategoria.Name = "lblFilterCategoria";
            this.lblFilterCategoria.Size = new System.Drawing.Size(71, 13);
            this.lblFilterCategoria.TabIndex = 22;
            this.lblFilterCategoria.Text = "Por Categoria";
            // 
            // lblfilterNombre
            // 
            this.lblfilterNombre.AutoSize = true;
            this.lblfilterNombre.Location = new System.Drawing.Point(393, 55);
            this.lblfilterNombre.Name = "lblfilterNombre";
            this.lblfilterNombre.Size = new System.Drawing.Size(40, 13);
            this.lblfilterNombre.TabIndex = 23;
            this.lblfilterNombre.Text = "Buscar";
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReset.Location = new System.Drawing.Point(15, 16);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 23);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Mostrar Todos";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // formArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(729, 353);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblfilterNombre);
            this.Controls.Add(this.lblFilterCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterNombre);
            this.Controls.Add(this.filterCategoria);
            this.Controls.Add(this.filterMarca);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvLista);
            this.MinimumSize = new System.Drawing.Size(745, 392);
            this.Name = "formArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.ComboBox filterMarca;
        private System.Windows.Forms.ComboBox filterCategoria;
        private System.Windows.Forms.TextBox filterNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFilterCategoria;
        private System.Windows.Forms.Label lblfilterNombre;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label lblTitulo;
    }
}

