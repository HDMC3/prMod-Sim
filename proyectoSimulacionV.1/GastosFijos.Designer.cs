namespace proyectoSimulacionV._1
{
    partial class GastosFijos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupGastosFijos = new System.Windows.Forms.GroupBox();
            this.groupAccionesTipos = new System.Windows.Forms.GroupBox();
            this.btnRecargarGastos = new System.Windows.Forms.Button();
            this.btnEliminarGasto = new System.Windows.Forms.Button();
            this.btnEditarGasto = new System.Windows.Forms.Button();
            this.btnCrearGasto = new System.Windows.Forms.Button();
            this.tblGastosFijos = new System.Windows.Forms.DataGridView();
            this.groupGastosFijos.SuspendLayout();
            this.groupAccionesTipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblGastosFijos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupGastosFijos
            // 
            this.groupGastosFijos.Controls.Add(this.tblGastosFijos);
            this.groupGastosFijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupGastosFijos.Location = new System.Drawing.Point(13, 13);
            this.groupGastosFijos.Name = "groupGastosFijos";
            this.groupGastosFijos.Size = new System.Drawing.Size(728, 584);
            this.groupGastosFijos.TabIndex = 0;
            this.groupGastosFijos.TabStop = false;
            this.groupGastosFijos.Text = "Gastos fijos";
            // 
            // groupAccionesTipos
            // 
            this.groupAccionesTipos.Controls.Add(this.btnRecargarGastos);
            this.groupAccionesTipos.Controls.Add(this.btnEliminarGasto);
            this.groupAccionesTipos.Controls.Add(this.btnEditarGasto);
            this.groupAccionesTipos.Controls.Add(this.btnCrearGasto);
            this.groupAccionesTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAccionesTipos.Location = new System.Drawing.Point(747, 13);
            this.groupAccionesTipos.Name = "groupAccionesTipos";
            this.groupAccionesTipos.Size = new System.Drawing.Size(209, 584);
            this.groupAccionesTipos.TabIndex = 2;
            this.groupAccionesTipos.TabStop = false;
            this.groupAccionesTipos.Text = "Acciones";
            // 
            // btnRecargarGastos
            // 
            this.btnRecargarGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargarGastos.Location = new System.Drawing.Point(6, 154);
            this.btnRecargarGastos.Name = "btnRecargarGastos";
            this.btnRecargarGastos.Size = new System.Drawing.Size(196, 36);
            this.btnRecargarGastos.TabIndex = 3;
            this.btnRecargarGastos.Text = "Recargar gastos";
            this.btnRecargarGastos.UseVisualStyleBackColor = true;
            this.btnRecargarGastos.Click += new System.EventHandler(this.btnRecargarGastos_Click);
            // 
            // btnEliminarGasto
            // 
            this.btnEliminarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGasto.Location = new System.Drawing.Point(6, 112);
            this.btnEliminarGasto.Name = "btnEliminarGasto";
            this.btnEliminarGasto.Size = new System.Drawing.Size(196, 36);
            this.btnEliminarGasto.TabIndex = 2;
            this.btnEliminarGasto.Text = "Eliminar gasto";
            this.btnEliminarGasto.Click += new System.EventHandler(this.btnEliminarGasto_Click);
            // 
            // btnEditarGasto
            // 
            this.btnEditarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarGasto.Location = new System.Drawing.Point(6, 70);
            this.btnEditarGasto.Name = "btnEditarGasto";
            this.btnEditarGasto.Size = new System.Drawing.Size(196, 36);
            this.btnEditarGasto.TabIndex = 1;
            this.btnEditarGasto.Text = "Editar gasto";
            this.btnEditarGasto.UseVisualStyleBackColor = true;
            this.btnEditarGasto.Click += new System.EventHandler(this.btnEditarGasto_Click);
            // 
            // btnCrearGasto
            // 
            this.btnCrearGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearGasto.Location = new System.Drawing.Point(7, 28);
            this.btnCrearGasto.Name = "btnCrearGasto";
            this.btnCrearGasto.Size = new System.Drawing.Size(196, 36);
            this.btnCrearGasto.TabIndex = 0;
            this.btnCrearGasto.Text = "Nuevo gasto";
            this.btnCrearGasto.UseVisualStyleBackColor = true;
            this.btnCrearGasto.Click += new System.EventHandler(this.btnCrearGasto_Click);
            // 
            // tblGastosFijos
            // 
            this.tblGastosFijos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblGastosFijos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblGastosFijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblGastosFijos.Location = new System.Drawing.Point(6, 25);
            this.tblGastosFijos.Name = "tblGastosFijos";
            this.tblGastosFijos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tblGastosFijos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tblGastosFijos.RowTemplate.Height = 24;
            this.tblGastosFijos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblGastosFijos.Size = new System.Drawing.Size(716, 553);
            this.tblGastosFijos.TabIndex = 0;
            // 
            // GastosFijos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 609);
            this.Controls.Add(this.groupAccionesTipos);
            this.Controls.Add(this.groupGastosFijos);
            this.MaximizeBox = false;
            this.Name = "GastosFijos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos fijos";
            this.groupGastosFijos.ResumeLayout(false);
            this.groupAccionesTipos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblGastosFijos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupGastosFijos;
        private System.Windows.Forms.DataGridView tblGastosFijos;
        private System.Windows.Forms.GroupBox groupAccionesTipos;
        private System.Windows.Forms.Button btnRecargarGastos;
        private System.Windows.Forms.Button btnEliminarGasto;
        private System.Windows.Forms.Button btnEditarGasto;
        private System.Windows.Forms.Button btnCrearGasto;
    }
}