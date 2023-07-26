namespace presentacion
{
    partial class Menu
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxImagenUrl = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.tbxFiltroRapido = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.tbxFiltroAv = new System.Windows.Forms.TextBox();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.lblDescripcion2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenUrl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToOrderColumns = true;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvArticulos.Location = new System.Drawing.Point(44, 121);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(742, 479);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellDoubleClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxImagenUrl
            // 
            this.pbxImagenUrl.BackColor = System.Drawing.Color.SlateGray;
            this.pbxImagenUrl.Location = new System.Drawing.Point(323, 19);
            this.pbxImagenUrl.MaximumSize = new System.Drawing.Size(394, 461);
            this.pbxImagenUrl.Name = "pbxImagenUrl";
            this.pbxImagenUrl.Size = new System.Drawing.Size(394, 461);
            this.pbxImagenUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenUrl.TabIndex = 1;
            this.pbxImagenUrl.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnAgregar.Location = new System.Drawing.Point(43, 606);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 24);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnModificar.Location = new System.Drawing.Point(146, 606);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 24);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnBorrar.Location = new System.Drawing.Point(253, 606);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(98, 24);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblFiltro.Location = new System.Drawing.Point(476, 92);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(63, 18);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Buscar :";
            // 
            // tbxFiltroRapido
            // 
            this.tbxFiltroRapido.Location = new System.Drawing.Point(537, 91);
            this.tbxFiltroRapido.Name = "tbxFiltroRapido";
            this.tbxFiltroRapido.Size = new System.Drawing.Size(249, 20);
            this.tbxFiltroRapido.TabIndex = 6;
            this.tbxFiltroRapido.TextChanged += new System.EventHandler(this.tbxFiltroRapido_TextChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnFiltro.Location = new System.Drawing.Point(642, 650);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(123, 24);
            this.btnFiltro.TabIndex = 7;
            this.btnFiltro.Text = "Aplicar filtros";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // cbxCampo
            // 
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(162, 647);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(121, 26);
            this.cbxCampo.TabIndex = 8;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(351, 647);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(121, 26);
            this.cbxCriterio.TabIndex = 9;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCampo.Location = new System.Drawing.Point(99, 650);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(57, 18);
            this.lblCampo.TabIndex = 10;
            this.lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCriterio.Location = new System.Drawing.Point(296, 650);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(56, 18);
            this.lblCriterio.TabIndex = 12;
            this.lblCriterio.Text = "Criterio";
            // 
            // tbxFiltroAv
            // 
            this.tbxFiltroAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFiltroAv.Location = new System.Drawing.Point(492, 648);
            this.tbxFiltroAv.Name = "tbxFiltroAv";
            this.tbxFiltroAv.Size = new System.Drawing.Size(108, 22);
            this.tbxFiltroAv.TabIndex = 13;
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblFiltros.Location = new System.Drawing.Point(47, 650);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(53, 18);
            this.lblFiltros.TabIndex = 14;
            this.lblFiltros.Text = "Filtros:";
            // 
            // btnDetalles
            // 
            this.btnDetalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnDetalles.Location = new System.Drawing.Point(30, 413);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(99, 24);
            this.btnDetalles.TabIndex = 15;
            this.btnDetalles.Text = "Ver detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // lblDescripcion2
            // 
            this.lblDescripcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblDescripcion2.Location = new System.Drawing.Point(125, 199);
            this.lblDescripcion2.Name = "lblDescripcion2";
            this.lblDescripcion2.Size = new System.Drawing.Size(179, 35);
            this.lblDescripcion2.TabIndex = 21;
            this.lblDescripcion2.Text = "Id:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNombre2.Location = new System.Drawing.Point(125, 148);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(179, 33);
            this.lblNombre2.TabIndex = 20;
            this.lblNombre2.Text = "Id:";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCodigo2.Location = new System.Drawing.Point(125, 96);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(179, 37);
            this.lblCodigo2.TabIndex = 19;
            this.lblCodigo2.Text = "Id:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblDescripcion.Location = new System.Drawing.Point(22, 199);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 18);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNombre.Location = new System.Drawing.Point(22, 148);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCodigo.Location = new System.Drawing.Point(22, 96);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 18);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio2.Location = new System.Drawing.Point(93, 322);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(193, 48);
            this.lblPrecio2.TabIndex = 23;
            this.lblPrecio2.Text = "Id:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblPrecio.Location = new System.Drawing.Point(27, 322);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 18);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblMarca2
            // 
            this.lblMarca2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMarca2.Location = new System.Drawing.Point(125, 251);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(179, 38);
            this.lblMarca2.TabIndex = 25;
            this.lblMarca2.Text = "Id:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMarca.Location = new System.Drawing.Point(22, 251);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(54, 18);
            this.lblMarca.TabIndex = 24;
            this.lblMarca.Text = "Marca:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox1.Controls.Add(this.pbxImagenUrl);
            this.groupBox1.Controls.Add(this.lblMarca2);
            this.groupBox1.Controls.Add(this.btnDetalles);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblPrecio2);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.lblDescripcion2);
            this.groupBox1.Controls.Add(this.lblCodigo2);
            this.groupBox1.Controls.Add(this.lblNombre2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(849, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 546);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artículo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1614, 738);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.tbxFiltroAv);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.cbxCriterio);
            this.Controls.Add(this.cbxCampo);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.tbxFiltroRapido);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenUrl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxImagenUrl;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox tbxFiltroRapido;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.TextBox tbxFiltroAv;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Label lblDescripcion2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca2;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

