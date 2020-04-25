namespace proyectoSimulacionV._1
{
    partial class EditarGasto
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
            this.groupEditarGasto = new System.Windows.Forms.GroupBox();
            this.btnGuardarGasto = new System.Windows.Forms.Button();
            this.txtNombreGasto = new System.Windows.Forms.TextBox();
            this.txtCantidadGasto = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadGasto = new System.Windows.Forms.Label();
            this.lblNombreGasto = new System.Windows.Forms.Label();
            this.groupEditarGasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadGasto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupEditarGasto
            // 
            this.groupEditarGasto.Controls.Add(this.btnGuardarGasto);
            this.groupEditarGasto.Controls.Add(this.txtNombreGasto);
            this.groupEditarGasto.Controls.Add(this.txtCantidadGasto);
            this.groupEditarGasto.Controls.Add(this.lblCantidadGasto);
            this.groupEditarGasto.Controls.Add(this.lblNombreGasto);
            this.groupEditarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupEditarGasto.Location = new System.Drawing.Point(12, 12);
            this.groupEditarGasto.Name = "groupEditarGasto";
            this.groupEditarGasto.Size = new System.Drawing.Size(355, 188);
            this.groupEditarGasto.TabIndex = 1;
            this.groupEditarGasto.TabStop = false;
            this.groupEditarGasto.Text = "Editar gasto";
            // 
            // btnGuardarGasto
            // 
            this.btnGuardarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarGasto.Location = new System.Drawing.Point(45, 129);
            this.btnGuardarGasto.Name = "btnGuardarGasto";
            this.btnGuardarGasto.Size = new System.Drawing.Size(249, 42);
            this.btnGuardarGasto.TabIndex = 4;
            this.btnGuardarGasto.Text = "Guardar";
            this.btnGuardarGasto.UseVisualStyleBackColor = true;
            this.btnGuardarGasto.Click += new System.EventHandler(this.btnGuardarGasto_Click);
            // 
            // txtNombreGasto
            // 
            this.txtNombreGasto.Location = new System.Drawing.Point(122, 33);
            this.txtNombreGasto.Name = "txtNombreGasto";
            this.txtNombreGasto.Size = new System.Drawing.Size(200, 30);
            this.txtNombreGasto.TabIndex = 3;
            // 
            // txtCantidadGasto
            // 
            this.txtCantidadGasto.DecimalPlaces = 2;
            this.txtCantidadGasto.Location = new System.Drawing.Point(122, 70);
            this.txtCantidadGasto.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtCantidadGasto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidadGasto.Name = "txtCantidadGasto";
            this.txtCantidadGasto.Size = new System.Drawing.Size(200, 30);
            this.txtCantidadGasto.TabIndex = 2;
            this.txtCantidadGasto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidadGasto
            // 
            this.lblCantidadGasto.AutoSize = true;
            this.lblCantidadGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadGasto.Location = new System.Drawing.Point(27, 74);
            this.lblCantidadGasto.Name = "lblCantidadGasto";
            this.lblCantidadGasto.Size = new System.Drawing.Size(89, 24);
            this.lblCantidadGasto.TabIndex = 1;
            this.lblCantidadGasto.Text = "Cantidad:";
            // 
            // lblNombreGasto
            // 
            this.lblNombreGasto.AutoSize = true;
            this.lblNombreGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreGasto.Location = new System.Drawing.Point(27, 38);
            this.lblNombreGasto.Name = "lblNombreGasto";
            this.lblNombreGasto.Size = new System.Drawing.Size(84, 24);
            this.lblNombreGasto.TabIndex = 0;
            this.lblNombreGasto.Text = "Nombre:";
            // 
            // EditarGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 212);
            this.Controls.Add(this.groupEditarGasto);
            this.Name = "EditarGasto";
            this.Text = "EditarGasto";
            this.groupEditarGasto.ResumeLayout(false);
            this.groupEditarGasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadGasto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupEditarGasto;
        private System.Windows.Forms.Button btnGuardarGasto;
        private System.Windows.Forms.TextBox txtNombreGasto;
        private System.Windows.Forms.NumericUpDown txtCantidadGasto;
        private System.Windows.Forms.Label lblCantidadGasto;
        private System.Windows.Forms.Label lblNombreGasto;
    }
}