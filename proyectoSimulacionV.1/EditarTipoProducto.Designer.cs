namespace proyectoSimulacionV._1
{
    partial class EditarTipoProducto
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
            this.groupEditarTipoProducto = new System.Windows.Forms.GroupBox();
            this.chkTipoHabilitado = new System.Windows.Forms.CheckBox();
            this.lblNombreTipoProducto = new System.Windows.Forms.Label();
            this.btnGuardarEditarTipoProducto = new System.Windows.Forms.Button();
            this.txtNombreTipoProducto = new System.Windows.Forms.TextBox();
            this.groupEditarTipoProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupEditarTipoProducto
            // 
            this.groupEditarTipoProducto.Controls.Add(this.chkTipoHabilitado);
            this.groupEditarTipoProducto.Controls.Add(this.lblNombreTipoProducto);
            this.groupEditarTipoProducto.Controls.Add(this.btnGuardarEditarTipoProducto);
            this.groupEditarTipoProducto.Controls.Add(this.txtNombreTipoProducto);
            this.groupEditarTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupEditarTipoProducto.Location = new System.Drawing.Point(12, 12);
            this.groupEditarTipoProducto.Name = "groupEditarTipoProducto";
            this.groupEditarTipoProducto.Size = new System.Drawing.Size(387, 207);
            this.groupEditarTipoProducto.TabIndex = 12;
            this.groupEditarTipoProducto.TabStop = false;
            this.groupEditarTipoProducto.Text = "Editar tipo";
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
            // btnGuardarEditarTipoProducto
            // 
            this.btnGuardarEditarTipoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarEditarTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEditarTipoProducto.Location = new System.Drawing.Point(60, 154);
            this.btnGuardarEditarTipoProducto.Name = "btnGuardarEditarTipoProducto";
            this.btnGuardarEditarTipoProducto.Size = new System.Drawing.Size(249, 42);
            this.btnGuardarEditarTipoProducto.TabIndex = 7;
            this.btnGuardarEditarTipoProducto.Text = "Guardar";
            this.btnGuardarEditarTipoProducto.UseVisualStyleBackColor = true;
            this.btnGuardarEditarTipoProducto.Click += new System.EventHandler(this.btnGuardarEditarTipoProducto_Click);
            // 
            // txtNombreTipoProducto
            // 
            this.txtNombreTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTipoProducto.Location = new System.Drawing.Point(152, 40);
            this.txtNombreTipoProducto.Name = "txtNombreTipoProducto";
            this.txtNombreTipoProducto.Size = new System.Drawing.Size(227, 28);
            this.txtNombreTipoProducto.TabIndex = 1;
            // 
            // EditarTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 230);
            this.Controls.Add(this.groupEditarTipoProducto);
            this.Name = "EditarTipoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarTipoProducto";
            this.groupEditarTipoProducto.ResumeLayout(false);
            this.groupEditarTipoProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupEditarTipoProducto;
        private System.Windows.Forms.CheckBox chkTipoHabilitado;
        private System.Windows.Forms.Label lblNombreTipoProducto;
        private System.Windows.Forms.Button btnGuardarEditarTipoProducto;
        private System.Windows.Forms.TextBox txtNombreTipoProducto;
    }
}