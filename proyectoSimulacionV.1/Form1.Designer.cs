namespace proyectoSimulacionV._1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.groupAccionesProductos = new System.Windows.Forms.GroupBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.groupListaProductos = new System.Windows.Forms.GroupBox();
            this.tblProductos = new System.Windows.Forms.DataGridView();
            this.tabSimulacion = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupParametrosEntrada = new System.Windows.Forms.GroupBox();
            this.checkStock = new System.Windows.Forms.CheckBox();
            this.txtHoraFin = new System.Windows.Forms.NumericUpDown();
            this.txtHoraInicio = new System.Windows.Forms.NumericUpDown();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.tabTipoProductos = new System.Windows.Forms.TabPage();
            this.groupTiposProducto = new System.Windows.Forms.GroupBox();
            this.groupAccionesTipos = new System.Windows.Forms.GroupBox();
            this.tblTiposProducto = new System.Windows.Forms.DataGridView();
            this.btnCrearTipoProducto = new System.Windows.Forms.Button();
            this.btnEditarTipoProducto = new System.Windows.Forms.Button();
            this.btnEliminarTipoProducto = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.groupAccionesProductos.SuspendLayout();
            this.groupListaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).BeginInit();
            this.tabSimulacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupParametrosEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraInicio)).BeginInit();
            this.tabTipoProductos.SuspendLayout();
            this.groupTiposProducto.SuspendLayout();
            this.groupAccionesTipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTiposProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProductos);
            this.tabControl1.Controls.Add(this.tabTipoProductos);
            this.tabControl1.Controls.Add(this.tabSimulacion);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 518);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.groupAccionesProductos);
            this.tabProductos.Controls.Add(this.groupListaProductos);
            this.tabProductos.Location = new System.Drawing.Point(4, 25);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(1045, 489);
            this.tabProductos.TabIndex = 0;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // groupAccionesProductos
            // 
            this.groupAccionesProductos.Controls.Add(this.btnEliminarProducto);
            this.groupAccionesProductos.Controls.Add(this.btnEditarProducto);
            this.groupAccionesProductos.Controls.Add(this.btnCrearProducto);
            this.groupAccionesProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAccionesProductos.Location = new System.Drawing.Point(830, 6);
            this.groupAccionesProductos.Name = "groupAccionesProductos";
            this.groupAccionesProductos.Size = new System.Drawing.Size(209, 477);
            this.groupAccionesProductos.TabIndex = 2;
            this.groupAccionesProductos.TabStop = false;
            this.groupAccionesProductos.Text = "Acciones";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Location = new System.Drawing.Point(6, 112);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(196, 36);
            this.btnEliminarProducto.TabIndex = 2;
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProducto.Location = new System.Drawing.Point(6, 70);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(196, 36);
            this.btnEditarProducto.TabIndex = 1;
            this.btnEditarProducto.Text = "Editar producto";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProducto.Location = new System.Drawing.Point(7, 28);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(196, 36);
            this.btnCrearProducto.TabIndex = 0;
            this.btnCrearProducto.Text = "Crear producto";
            this.btnCrearProducto.UseVisualStyleBackColor = true;
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // groupListaProductos
            // 
            this.groupListaProductos.Controls.Add(this.tblProductos);
            this.groupListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupListaProductos.Location = new System.Drawing.Point(6, 6);
            this.groupListaProductos.Name = "groupListaProductos";
            this.groupListaProductos.Size = new System.Drawing.Size(818, 477);
            this.groupListaProductos.TabIndex = 1;
            this.groupListaProductos.TabStop = false;
            this.groupListaProductos.Text = "Lista productos";
            // 
            // tblProductos
            // 
            this.tblProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProductos.Location = new System.Drawing.Point(19, 29);
            this.tblProductos.MultiSelect = false;
            this.tblProductos.Name = "tblProductos";
            this.tblProductos.RowHeadersWidth = 51;
            this.tblProductos.RowTemplate.Height = 24;
            this.tblProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblProductos.Size = new System.Drawing.Size(784, 429);
            this.tblProductos.TabIndex = 0;
            // 
            // tabSimulacion
            // 
            this.tabSimulacion.Controls.Add(this.dataGridView1);
            this.tabSimulacion.Controls.Add(this.groupParametrosEntrada);
            this.tabSimulacion.Location = new System.Drawing.Point(4, 25);
            this.tabSimulacion.Name = "tabSimulacion";
            this.tabSimulacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimulacion.Size = new System.Drawing.Size(1045, 489);
            this.tabSimulacion.TabIndex = 1;
            this.tabSimulacion.Text = "Simulacion";
            this.tabSimulacion.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(710, 477);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupParametrosEntrada
            // 
            this.groupParametrosEntrada.Controls.Add(this.checkStock);
            this.groupParametrosEntrada.Controls.Add(this.txtHoraFin);
            this.groupParametrosEntrada.Controls.Add(this.txtHoraInicio);
            this.groupParametrosEntrada.Controls.Add(this.lblHoraFin);
            this.groupParametrosEntrada.Controls.Add(this.lblHoraInicio);
            this.groupParametrosEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupParametrosEntrada.Location = new System.Drawing.Point(6, 6);
            this.groupParametrosEntrada.Name = "groupParametrosEntrada";
            this.groupParametrosEntrada.Size = new System.Drawing.Size(317, 477);
            this.groupParametrosEntrada.TabIndex = 0;
            this.groupParametrosEntrada.TabStop = false;
            this.groupParametrosEntrada.Text = "Parametros de entrada";
            // 
            // checkStock
            // 
            this.checkStock.AutoSize = true;
            this.checkStock.Location = new System.Drawing.Point(9, 126);
            this.checkStock.Name = "checkStock";
            this.checkStock.Size = new System.Drawing.Size(142, 24);
            this.checkStock.TabIndex = 4;
            this.checkStock.Text = "Stock aleatorio";
            this.checkStock.UseVisualStyleBackColor = true;
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Location = new System.Drawing.Point(115, 71);
            this.txtHoraFin.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.txtHoraFin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Size = new System.Drawing.Size(120, 26);
            this.txtHoraFin.TabIndex = 3;
            this.txtHoraFin.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(115, 33);
            this.txtHoraInicio.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.txtHoraInicio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(120, 26);
            this.txtHoraInicio.TabIndex = 2;
            this.txtHoraInicio.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.Location = new System.Drawing.Point(6, 74);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(84, 18);
            this.lblHoraFin.TabIndex = 1;
            this.lblHoraFin.Text = "Hora de fin:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(6, 36);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(103, 18);
            this.lblHoraInicio.TabIndex = 0;
            this.lblHoraInicio.Text = "Hora de inicio:";
            // 
            // tabTipoProductos
            // 
            this.tabTipoProductos.Controls.Add(this.groupAccionesTipos);
            this.tabTipoProductos.Controls.Add(this.groupTiposProducto);
            this.tabTipoProductos.Location = new System.Drawing.Point(4, 25);
            this.tabTipoProductos.Name = "tabTipoProductos";
            this.tabTipoProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTipoProductos.Size = new System.Drawing.Size(1045, 489);
            this.tabTipoProductos.TabIndex = 2;
            this.tabTipoProductos.Text = "Tipos producto";
            this.tabTipoProductos.UseVisualStyleBackColor = true;
            // 
            // groupTiposProducto
            // 
            this.groupTiposProducto.Controls.Add(this.tblTiposProducto);
            this.groupTiposProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTiposProducto.Location = new System.Drawing.Point(6, 6);
            this.groupTiposProducto.Name = "groupTiposProducto";
            this.groupTiposProducto.Size = new System.Drawing.Size(818, 477);
            this.groupTiposProducto.TabIndex = 0;
            this.groupTiposProducto.TabStop = false;
            this.groupTiposProducto.Text = "Lista tipos";
            // 
            // groupAccionesTipos
            // 
            this.groupAccionesTipos.Controls.Add(this.btnEliminarTipoProducto);
            this.groupAccionesTipos.Controls.Add(this.btnEditarTipoProducto);
            this.groupAccionesTipos.Controls.Add(this.btnCrearTipoProducto);
            this.groupAccionesTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAccionesTipos.Location = new System.Drawing.Point(830, 6);
            this.groupAccionesTipos.Name = "groupAccionesTipos";
            this.groupAccionesTipos.Size = new System.Drawing.Size(209, 477);
            this.groupAccionesTipos.TabIndex = 1;
            this.groupAccionesTipos.TabStop = false;
            this.groupAccionesTipos.Text = "Acciones";
            // 
            // tblTiposProducto
            // 
            this.tblTiposProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblTiposProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTiposProducto.Location = new System.Drawing.Point(19, 29);
            this.tblTiposProducto.MultiSelect = false;
            this.tblTiposProducto.Name = "tblTiposProducto";
            this.tblTiposProducto.RowHeadersWidth = 51;
            this.tblTiposProducto.RowTemplate.Height = 24;
            this.tblTiposProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblTiposProducto.Size = new System.Drawing.Size(784, 429);
            this.tblTiposProducto.TabIndex = 0;
            // 
            // btnCrearTipoProducto
            // 
            this.btnCrearTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTipoProducto.Location = new System.Drawing.Point(7, 28);
            this.btnCrearTipoProducto.Name = "btnCrearTipoProducto";
            this.btnCrearTipoProducto.Size = new System.Drawing.Size(196, 36);
            this.btnCrearTipoProducto.TabIndex = 0;
            this.btnCrearTipoProducto.Text = "Nuevo tipo";
            this.btnCrearTipoProducto.UseVisualStyleBackColor = true;
            this.btnCrearTipoProducto.Click += new System.EventHandler(this.btnCrearTipoProducto_Click);
            // 
            // btnEditarTipoProducto
            // 
            this.btnEditarTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTipoProducto.Location = new System.Drawing.Point(6, 70);
            this.btnEditarTipoProducto.Name = "btnEditarTipoProducto";
            this.btnEditarTipoProducto.Size = new System.Drawing.Size(196, 36);
            this.btnEditarTipoProducto.TabIndex = 1;
            this.btnEditarTipoProducto.Text = "Editar tipo";
            this.btnEditarTipoProducto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTipoProducto
            // 
            this.btnEliminarTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipoProducto.Location = new System.Drawing.Point(6, 112);
            this.btnEliminarTipoProducto.Name = "btnEliminarTipoProducto";
            this.btnEliminarTipoProducto.Size = new System.Drawing.Size(196, 36);
            this.btnEliminarTipoProducto.TabIndex = 2;
            this.btnEliminarTipoProducto.Text = "Eliminar tipo";
            this.btnEliminarTipoProducto.Click += new System.EventHandler(this.btnEliminarTipoProducto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 542);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabProductos.ResumeLayout(false);
            this.groupAccionesProductos.ResumeLayout(false);
            this.groupListaProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).EndInit();
            this.tabSimulacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupParametrosEntrada.ResumeLayout(false);
            this.groupParametrosEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraInicio)).EndInit();
            this.tabTipoProductos.ResumeLayout(false);
            this.groupTiposProducto.ResumeLayout(false);
            this.groupAccionesTipos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblTiposProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSimulacion;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.DataGridView tblProductos;
        private System.Windows.Forms.GroupBox groupAccionesProductos;
        private System.Windows.Forms.GroupBox groupListaProductos;
        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.GroupBox groupParametrosEntrada;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.NumericUpDown txtHoraFin;
        private System.Windows.Forms.NumericUpDown txtHoraInicio;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkStock;
        private System.Windows.Forms.TabPage tabTipoProductos;
        private System.Windows.Forms.GroupBox groupAccionesTipos;
        private System.Windows.Forms.Button btnCrearTipoProducto;
        private System.Windows.Forms.GroupBox groupTiposProducto;
        private System.Windows.Forms.Button btnEliminarTipoProducto;
        private System.Windows.Forms.Button btnEditarTipoProducto;
        public System.Windows.Forms.DataGridView tblTiposProducto;
    }
}

