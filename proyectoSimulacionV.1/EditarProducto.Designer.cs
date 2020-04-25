namespace proyectoSimulacionV._1
{
    partial class EditarProducto
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
            this.groupNuevoProducto = new System.Windows.Forms.GroupBox();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.btnGuardarEditarProducto = new System.Windows.Forms.Button();
            this.txtTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.txtPrecioCostoProducto = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtPrecioVentaProducto = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioVentaProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioCostoProducto = new System.Windows.Forms.Label();
            this.lblTiempoPreparacion = new System.Windows.Forms.Label();
            this.txtTiempoPreparacion = new System.Windows.Forms.NumericUpDown();
            this.groupNuevoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCostoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVentaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempoPreparacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupNuevoProducto
            // 
            this.groupNuevoProducto.Controls.Add(this.txtTiempoPreparacion);
            this.groupNuevoProducto.Controls.Add(this.lblTiempoPreparacion);
            this.groupNuevoProducto.Controls.Add(this.chkHabilitado);
            this.groupNuevoProducto.Controls.Add(this.btnGuardarEditarProducto);
            this.groupNuevoProducto.Controls.Add(this.txtTipoProducto);
            this.groupNuevoProducto.Controls.Add(this.lblNombreProducto);
            this.groupNuevoProducto.Controls.Add(this.lblTipoProducto);
            this.groupNuevoProducto.Controls.Add(this.txtPrecioCostoProducto);
            this.groupNuevoProducto.Controls.Add(this.lblStock);
            this.groupNuevoProducto.Controls.Add(this.txtPrecioVentaProducto);
            this.groupNuevoProducto.Controls.Add(this.lblPrecioVentaProducto);
            this.groupNuevoProducto.Controls.Add(this.txtNombreProducto);
            this.groupNuevoProducto.Controls.Add(this.txtStock);
            this.groupNuevoProducto.Controls.Add(this.lblPrecioCostoProducto);
            this.groupNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNuevoProducto.Location = new System.Drawing.Point(12, 12);
            this.groupNuevoProducto.Name = "groupNuevoProducto";
            this.groupNuevoProducto.Size = new System.Drawing.Size(449, 365);
            this.groupNuevoProducto.TabIndex = 11;
            this.groupNuevoProducto.TabStop = false;
            this.groupNuevoProducto.Text = "Editar Producto";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHabilitado.Location = new System.Drawing.Point(27, 266);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(120, 29);
            this.chkHabilitado.TabIndex = 7;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            this.chkHabilitado.CheckedChanged += new System.EventHandler(this.chkHabilitado_CheckedChanged);
            // 
            // btnGuardarEditarProducto
            // 
            this.btnGuardarEditarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarEditarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEditarProducto.Location = new System.Drawing.Point(99, 317);
            this.btnGuardarEditarProducto.Name = "btnGuardarEditarProducto";
            this.btnGuardarEditarProducto.Size = new System.Drawing.Size(249, 42);
            this.btnGuardarEditarProducto.TabIndex = 8;
            this.btnGuardarEditarProducto.Text = "Guardar";
            this.btnGuardarEditarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarEditarProducto.Click += new System.EventHandler(this.btnGuardarEditarProducto_Click);
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.DisplayMember = "cod_tipo_producto";
            this.txtTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoProducto.FormattingEnabled = true;
            this.txtTipoProducto.Location = new System.Drawing.Point(240, 223);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(174, 30);
            this.txtTipoProducto.TabIndex = 6;
            this.txtTipoProducto.SelectedIndexChanged += new System.EventHandler(this.txtTipoProducto_SelectedIndexChanged);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(23, 49);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(164, 24);
            this.lblNombreProducto.TabIndex = 9;
            this.lblNombreProducto.Text = "Nombre producto:";
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.Location = new System.Drawing.Point(23, 226);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(133, 24);
            this.lblTipoProducto.TabIndex = 14;
            this.lblTipoProducto.Text = "Tipo producto:";
            this.lblTipoProducto.Click += new System.EventHandler(this.lblTipoProducto_Click);
            // 
            // txtPrecioCostoProducto
            // 
            this.txtPrecioCostoProducto.DecimalPlaces = 2;
            this.txtPrecioCostoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCostoProducto.Location = new System.Drawing.Point(240, 83);
            this.txtPrecioCostoProducto.Name = "txtPrecioCostoProducto";
            this.txtPrecioCostoProducto.Size = new System.Drawing.Size(173, 28);
            this.txtPrecioCostoProducto.TabIndex = 2;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(23, 192);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(61, 24);
            this.lblStock.TabIndex = 13;
            this.lblStock.Text = "Stock:";
            this.lblStock.Click += new System.EventHandler(this.lblStock_Click);
            // 
            // txtPrecioVentaProducto
            // 
            this.txtPrecioVentaProducto.DecimalPlaces = 2;
            this.txtPrecioVentaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVentaProducto.Location = new System.Drawing.Point(240, 119);
            this.txtPrecioVentaProducto.Name = "txtPrecioVentaProducto";
            this.txtPrecioVentaProducto.Size = new System.Drawing.Size(173, 28);
            this.txtPrecioVentaProducto.TabIndex = 3;
            // 
            // lblPrecioVentaProducto
            // 
            this.lblPrecioVentaProducto.AutoSize = true;
            this.lblPrecioVentaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVentaProducto.Location = new System.Drawing.Point(23, 121);
            this.lblPrecioVentaProducto.Name = "lblPrecioVentaProducto";
            this.lblPrecioVentaProducto.Size = new System.Drawing.Size(119, 24);
            this.lblPrecioVentaProducto.TabIndex = 11;
            this.lblPrecioVentaProducto.Text = "Precio venta:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(240, 45);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(173, 28);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(240, 190);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(173, 28);
            this.txtStock.TabIndex = 5;
            // 
            // lblPrecioCostoProducto
            // 
            this.lblPrecioCostoProducto.AutoSize = true;
            this.lblPrecioCostoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCostoProducto.Location = new System.Drawing.Point(23, 85);
            this.lblPrecioCostoProducto.Name = "lblPrecioCostoProducto";
            this.lblPrecioCostoProducto.Size = new System.Drawing.Size(119, 24);
            this.lblPrecioCostoProducto.TabIndex = 10;
            this.lblPrecioCostoProducto.Text = "Precio costo:";
            // 
            // lblTiempoPreparacion
            // 
            this.lblTiempoPreparacion.AutoSize = true;
            this.lblTiempoPreparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoPreparacion.Location = new System.Drawing.Point(23, 156);
            this.lblTiempoPreparacion.Name = "lblTiempoPreparacion";
            this.lblTiempoPreparacion.Size = new System.Drawing.Size(213, 24);
            this.lblTiempoPreparacion.TabIndex = 12;
            this.lblTiempoPreparacion.Text = "Tiempo de preparacion:";
            // 
            // txtTiempoPreparacion
            // 
            this.txtTiempoPreparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempoPreparacion.Location = new System.Drawing.Point(240, 154);
            this.txtTiempoPreparacion.Name = "txtTiempoPreparacion";
            this.txtTiempoPreparacion.Size = new System.Drawing.Size(173, 28);
            this.txtTiempoPreparacion.TabIndex = 4;
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 393);
            this.Controls.Add(this.groupNuevoProducto);
            this.Name = "EditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Producto";
            this.groupNuevoProducto.ResumeLayout(false);
            this.groupNuevoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCostoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVentaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempoPreparacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupNuevoProducto;
        private System.Windows.Forms.Button btnGuardarEditarProducto;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.ComboBox txtTipoProducto;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecioVentaProducto;
        private System.Windows.Forms.NumericUpDown txtStock;
        private System.Windows.Forms.Label lblPrecioCostoProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.NumericUpDown txtPrecioVentaProducto;
        private System.Windows.Forms.NumericUpDown txtPrecioCostoProducto;
        private System.Windows.Forms.NumericUpDown txtTiempoPreparacion;
        private System.Windows.Forms.Label lblTiempoPreparacion;
    }
}