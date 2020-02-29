namespace proyectoSimulacionV._1
{
    partial class CrearProducto
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
            this.lblPrecioVentaProducto = new System.Windows.Forms.Label();
            this.lblPrecioCostoProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaProducto = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioCostoProducto = new System.Windows.Forms.NumericUpDown();
            this.groupNuevoProducto = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVentaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCostoProducto)).BeginInit();
            this.groupNuevoProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrecioVentaProducto
            // 
            this.lblPrecioVentaProducto.AutoSize = true;
            this.lblPrecioVentaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVentaProducto.Location = new System.Drawing.Point(40, 153);
            this.lblPrecioVentaProducto.Name = "lblPrecioVentaProducto";
            this.lblPrecioVentaProducto.Size = new System.Drawing.Size(119, 24);
            this.lblPrecioVentaProducto.TabIndex = 10;
            this.lblPrecioVentaProducto.Text = "Precio venta:";
            // 
            // lblPrecioCostoProducto
            // 
            this.lblPrecioCostoProducto.AutoSize = true;
            this.lblPrecioCostoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCostoProducto.Location = new System.Drawing.Point(40, 99);
            this.lblPrecioCostoProducto.Name = "lblPrecioCostoProducto";
            this.lblPrecioCostoProducto.Size = new System.Drawing.Size(119, 24);
            this.lblPrecioCostoProducto.TabIndex = 9;
            this.lblPrecioCostoProducto.Text = "Precio costo:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(40, 46);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(164, 24);
            this.lblNombreProducto.TabIndex = 8;
            this.lblNombreProducto.Text = "Nombre producto:";
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.Location = new System.Drawing.Point(75, 221);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(249, 42);
            this.btnGuardarProducto.TabIndex = 7;
            this.btnGuardarProducto.Text = "Guardar producto";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(219, 48);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(120, 28);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // txtPrecioVentaProducto
            // 
            this.txtPrecioVentaProducto.DecimalPlaces = 2;
            this.txtPrecioVentaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVentaProducto.Location = new System.Drawing.Point(219, 156);
            this.txtPrecioVentaProducto.Name = "txtPrecioVentaProducto";
            this.txtPrecioVentaProducto.Size = new System.Drawing.Size(120, 28);
            this.txtPrecioVentaProducto.TabIndex = 6;
            // 
            // txtPrecioCostoProducto
            // 
            this.txtPrecioCostoProducto.DecimalPlaces = 2;
            this.txtPrecioCostoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCostoProducto.Location = new System.Drawing.Point(219, 102);
            this.txtPrecioCostoProducto.Name = "txtPrecioCostoProducto";
            this.txtPrecioCostoProducto.Size = new System.Drawing.Size(120, 28);
            this.txtPrecioCostoProducto.TabIndex = 4;
            // 
            // groupNuevoProducto
            // 
            this.groupNuevoProducto.Controls.Add(this.lblPrecioVentaProducto);
            this.groupNuevoProducto.Controls.Add(this.lblPrecioCostoProducto);
            this.groupNuevoProducto.Controls.Add(this.lblNombreProducto);
            this.groupNuevoProducto.Controls.Add(this.btnGuardarProducto);
            this.groupNuevoProducto.Controls.Add(this.txtNombreProducto);
            this.groupNuevoProducto.Controls.Add(this.txtPrecioVentaProducto);
            this.groupNuevoProducto.Controls.Add(this.txtPrecioCostoProducto);
            this.groupNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNuevoProducto.Location = new System.Drawing.Point(12, 12);
            this.groupNuevoProducto.Name = "groupNuevoProducto";
            this.groupNuevoProducto.Size = new System.Drawing.Size(398, 303);
            this.groupNuevoProducto.TabIndex = 10;
            this.groupNuevoProducto.TabStop = false;
            this.groupNuevoProducto.Text = "Nuevo Producto";
            // 
            // CrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 327);
            this.Controls.Add(this.groupNuevoProducto);
            this.Name = "CrearProducto";
            this.Text = "                ";
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVentaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCostoProducto)).EndInit();
            this.groupNuevoProducto.ResumeLayout(false);
            this.groupNuevoProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrecioVentaProducto;
        private System.Windows.Forms.Label lblPrecioCostoProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.NumericUpDown txtPrecioVentaProducto;
        private System.Windows.Forms.NumericUpDown txtPrecioCostoProducto;
        private System.Windows.Forms.GroupBox groupNuevoProducto;
    }
}