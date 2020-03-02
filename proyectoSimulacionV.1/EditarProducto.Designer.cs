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
            this.txtTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecioVentaProducto = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioCostoProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaProducto = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioCostoProducto = new System.Windows.Forms.NumericUpDown();
            this.groupNuevoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVentaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCostoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupNuevoProducto
            // 
            this.groupNuevoProducto.Controls.Add(this.chkHabilitado);
            this.groupNuevoProducto.Controls.Add(this.btnEditarProducto);
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
            this.groupNuevoProducto.Size = new System.Drawing.Size(398, 365);
            this.groupNuevoProducto.TabIndex = 11;
            this.groupNuevoProducto.TabStop = false;
            this.groupNuevoProducto.Text = "Editar Producto";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHabilitado.Location = new System.Drawing.Point(27, 233);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(120, 29);
            this.chkHabilitado.TabIndex = 27;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            this.chkHabilitado.CheckedChanged += new System.EventHandler(this.chkHabilitado_CheckedChanged);
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.DisplayMember = "cod_tipo_producto";
            this.txtTipoProducto.FormattingEnabled = true;
            this.txtTipoProducto.Location = new System.Drawing.Point(201, 196);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(174, 33);
            this.txtTipoProducto.TabIndex = 26;
            this.txtTipoProducto.SelectedIndexChanged += new System.EventHandler(this.txtTipoProducto_SelectedIndexChanged);
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.Location = new System.Drawing.Point(23, 193);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(133, 24);
            this.lblTipoProducto.TabIndex = 25;
            this.lblTipoProducto.Text = "Tipo producto:";
            this.lblTipoProducto.Click += new System.EventHandler(this.lblTipoProducto_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(23, 159);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(61, 24);
            this.lblStock.TabIndex = 24;
            this.lblStock.Text = "Stock:";
            this.lblStock.Click += new System.EventHandler(this.lblStock_Click);
            // 
            // lblPrecioVentaProducto
            // 
            this.lblPrecioVentaProducto.AutoSize = true;
            this.lblPrecioVentaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVentaProducto.Location = new System.Drawing.Point(23, 121);
            this.lblPrecioVentaProducto.Name = "lblPrecioVentaProducto";
            this.lblPrecioVentaProducto.Size = new System.Drawing.Size(119, 24);
            this.lblPrecioVentaProducto.TabIndex = 22;
            this.lblPrecioVentaProducto.Text = "Precio venta:";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(202, 162);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(173, 28);
            this.txtStock.TabIndex = 23;
            // 
            // lblPrecioCostoProducto
            // 
            this.lblPrecioCostoProducto.AutoSize = true;
            this.lblPrecioCostoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCostoProducto.Location = new System.Drawing.Point(23, 85);
            this.lblPrecioCostoProducto.Name = "lblPrecioCostoProducto";
            this.lblPrecioCostoProducto.Size = new System.Drawing.Size(119, 24);
            this.lblPrecioCostoProducto.TabIndex = 21;
            this.lblPrecioCostoProducto.Text = "Precio costo:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(23, 44);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(164, 24);
            this.lblNombreProducto.TabIndex = 20;
            this.lblNombreProducto.Text = "Nombre producto:";
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProducto.Location = new System.Drawing.Point(77, 289);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(249, 42);
            this.btnEditarProducto.TabIndex = 19;
            this.btnEditarProducto.Text = "Editar producto";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(202, 46);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(173, 28);
            this.txtNombreProducto.TabIndex = 16;
            // 
            // txtPrecioVentaProducto
            // 
            this.txtPrecioVentaProducto.DecimalPlaces = 2;
            this.txtPrecioVentaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVentaProducto.Location = new System.Drawing.Point(202, 124);
            this.txtPrecioVentaProducto.Name = "txtPrecioVentaProducto";
            this.txtPrecioVentaProducto.Size = new System.Drawing.Size(173, 28);
            this.txtPrecioVentaProducto.TabIndex = 18;
            // 
            // txtPrecioCostoProducto
            // 
            this.txtPrecioCostoProducto.DecimalPlaces = 2;
            this.txtPrecioCostoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCostoProducto.Location = new System.Drawing.Point(202, 88);
            this.txtPrecioCostoProducto.Name = "txtPrecioCostoProducto";
            this.txtPrecioCostoProducto.Size = new System.Drawing.Size(173, 28);
            this.txtPrecioCostoProducto.TabIndex = 17;
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 393);
            this.Controls.Add(this.groupNuevoProducto);
            this.Name = "EditarProducto";
            this.Text = "Editar Producto";
            this.groupNuevoProducto.ResumeLayout(false);
            this.groupNuevoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVentaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCostoProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupNuevoProducto;
        private System.Windows.Forms.Button btnEditarProducto;
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
    }
}