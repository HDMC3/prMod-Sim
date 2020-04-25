namespace proyectoSimulacionV._1
{
    partial class DetalleHora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupClientes = new System.Windows.Forms.GroupBox();
            this.groupProductos = new System.Windows.Forms.GroupBox();
            this.tblClientes = new System.Windows.Forms.DataGridView();
            this.tblProductosCliente = new System.Windows.Forms.DataGridView();
            this.groupClientes.SuspendLayout();
            this.groupProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductosCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupClientes
            // 
            this.groupClientes.Controls.Add(this.tblClientes);
            this.groupClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupClientes.Location = new System.Drawing.Point(12, 12);
            this.groupClientes.Name = "groupClientes";
            this.groupClientes.Size = new System.Drawing.Size(518, 426);
            this.groupClientes.TabIndex = 0;
            this.groupClientes.TabStop = false;
            this.groupClientes.Text = "Clientes";
            // 
            // groupProductos
            // 
            this.groupProductos.Controls.Add(this.tblProductosCliente);
            this.groupProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupProductos.Location = new System.Drawing.Point(536, 12);
            this.groupProductos.Name = "groupProductos";
            this.groupProductos.Size = new System.Drawing.Size(684, 426);
            this.groupProductos.TabIndex = 1;
            this.groupProductos.TabStop = false;
            this.groupProductos.Text = "Productos";
            // 
            // tblClientes
            // 
            this.tblClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblClientes.Location = new System.Drawing.Point(6, 25);
            this.tblClientes.Name = "tblClientes";
            this.tblClientes.ReadOnly = true;
            this.tblClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tblClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tblClientes.RowTemplate.Height = 24;
            this.tblClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblClientes.Size = new System.Drawing.Size(505, 395);
            this.tblClientes.TabIndex = 0;
            this.tblClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tblProductosCliente
            // 
            this.tblProductosCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblProductosCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblProductosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProductosCliente.Location = new System.Drawing.Point(6, 25);
            this.tblProductosCliente.MultiSelect = false;
            this.tblProductosCliente.Name = "tblProductosCliente";
            this.tblProductosCliente.ReadOnly = true;
            this.tblProductosCliente.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tblProductosCliente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tblProductosCliente.RowTemplate.Height = 24;
            this.tblProductosCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblProductosCliente.Size = new System.Drawing.Size(672, 395);
            this.tblProductosCliente.TabIndex = 0;
            // 
            // DetalleHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 450);
            this.Controls.Add(this.groupProductos);
            this.Controls.Add(this.groupClientes);
            this.Name = "DetalleHora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de hora";
            this.groupClientes.ResumeLayout(false);
            this.groupProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductosCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupClientes;
        private System.Windows.Forms.DataGridView tblClientes;
        private System.Windows.Forms.GroupBox groupProductos;
        private System.Windows.Forms.DataGridView tblProductosCliente;
    }
}