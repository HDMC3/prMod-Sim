namespace proyectoSimulacionV._1
{
    partial class CrearTipoProducto
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
            this.groupNuevoTipoProducto = new System.Windows.Forms.GroupBox();
            this.chkTipoHabilitado = new System.Windows.Forms.CheckBox();
            this.lblNombreTipoProducto = new System.Windows.Forms.Label();
            this.btnGuardarTipoProducto = new System.Windows.Forms.Button();
            this.txtNombreTipoProducto = new System.Windows.Forms.TextBox();
            this.groupNuevoTipoProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupNuevoTipoProducto
            // 
            this.groupNuevoTipoProducto.Controls.Add(this.chkTipoHabilitado);
            this.groupNuevoTipoProducto.Controls.Add(this.lblNombreTipoProducto);
            this.groupNuevoTipoProducto.Controls.Add(this.btnGuardarTipoProducto);
            this.groupNuevoTipoProducto.Controls.Add(this.txtNombreTipoProducto);
            this.groupNuevoTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNuevoTipoProducto.Location = new System.Drawing.Point(12, 12);
            this.groupNuevoTipoProducto.Name = "groupNuevoTipoProducto";
            this.groupNuevoTipoProducto.Size = new System.Drawing.Size(387, 207);
            this.groupNuevoTipoProducto.TabIndex = 11;
            this.groupNuevoTipoProducto.TabStop = false;
            this.groupNuevoTipoProducto.Text = "Nuevo tipo";
            // 
            // chkTipoHabilitado
            // 
            this.chkTipoHabilitado.AutoSize = true;
            this.chkTipoHabilitado.Location = new System.Drawing.Point(31, 84);
            this.chkTipoHabilitado.Name = "chkTipoHabilitado";
            this.chkTipoHabilitado.Size = new System.Drawing.Size(120, 29);
            this.chkTipoHabilitado.TabIndex = 15;
            this.chkTipoHabilitado.Text = "Habilitado";
            this.chkTipoHabilitado.UseVisualStyleBackColor = true;
            // 
            // lblNombreTipoProducto
            // 
            this.lblNombreTipoProducto.AutoSize = true;
            this.lblNombreTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTipoProducto.Location = new System.Drawing.Point(27, 43);
            this.lblNombreTipoProducto.Name = "lblNombreTipoProducto";
            this.lblNombreTipoProducto.Size = new System.Drawing.Size(119, 24);
            this.lblNombreTipoProducto.TabIndex = 8;
            this.lblNombreTipoProducto.Text = "Nombre tipo:";
            // 
            // btnGuardarTipoProducto
            // 
            this.btnGuardarTipoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTipoProducto.Location = new System.Drawing.Point(60, 154);
            this.btnGuardarTipoProducto.Name = "btnGuardarTipoProducto";
            this.btnGuardarTipoProducto.Size = new System.Drawing.Size(249, 42);
            this.btnGuardarTipoProducto.TabIndex = 7;
            this.btnGuardarTipoProducto.Text = "Guardar producto";
            this.btnGuardarTipoProducto.UseVisualStyleBackColor = true;
            this.btnGuardarTipoProducto.Click += new System.EventHandler(this.btnGuardarTipoProducto_Click);
            // 
            // txtNombreTipoProducto
            // 
            this.txtNombreTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTipoProducto.Location = new System.Drawing.Point(152, 40);
            this.txtNombreTipoProducto.Name = "txtNombreTipoProducto";
            this.txtNombreTipoProducto.Size = new System.Drawing.Size(227, 28);
            this.txtNombreTipoProducto.TabIndex = 1;
            // 
            // CrearTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 233);
            this.Controls.Add(this.groupNuevoTipoProducto);
            this.Name = "CrearTipoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearTipoProducto";
            this.groupNuevoTipoProducto.ResumeLayout(false);
            this.groupNuevoTipoProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupNuevoTipoProducto;
        private System.Windows.Forms.CheckBox chkTipoHabilitado;
        private System.Windows.Forms.Label lblNombreTipoProducto;
        private System.Windows.Forms.Button btnGuardarTipoProducto;
        private System.Windows.Forms.TextBox txtNombreTipoProducto;
    }
}