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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControlTipos = new System.Windows.Forms.TabControl();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.groupAccionesProductos = new System.Windows.Forms.GroupBox();
            this.btnRecargarProductos = new System.Windows.Forms.Button();
            this.btnHabDeshabProducto = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.groupListaProductos = new System.Windows.Forms.GroupBox();
            this.tblProductos = new System.Windows.Forms.DataGridView();
            this.tabTipoProductos = new System.Windows.Forms.TabPage();
            this.groupAccionesTipos = new System.Windows.Forms.GroupBox();
            this.btnRecargarTiposProducto = new System.Windows.Forms.Button();
            this.btnHabDeshabTipoProducto = new System.Windows.Forms.Button();
            this.btnEditarTipoProducto = new System.Windows.Forms.Button();
            this.btnCrearTipoProducto = new System.Windows.Forms.Button();
            this.groupTiposProducto = new System.Windows.Forms.GroupBox();
            this.tblTiposProducto = new System.Windows.Forms.DataGridView();
            this.tabSimulacion = new System.Windows.Forms.TabPage();
            this.groupBoxResultadosSimulacion = new System.Windows.Forms.GroupBox();
            this.tblSimulacion = new System.Windows.Forms.DataGridView();
            this.groupParametrosEntrada = new System.Windows.Forms.GroupBox();
            this.btnAgregarGastos = new System.Windows.Forms.Button();
            this.lblSeleccionarEscenario = new System.Windows.Forms.Label();
            this.txtCantidadEscenarios = new System.Windows.Forms.NumericUpDown();
            this.checkCantidadEscenarios = new System.Windows.Forms.CheckBox();
            this.comboBoxEscenarios = new System.Windows.Forms.ComboBox();
            this.btnGenerarRegistros = new System.Windows.Forms.Button();
            this.txtHorasSimulacion = new System.Windows.Forms.NumericUpDown();
            this.lblHorasSimulacion = new System.Windows.Forms.Label();
            this.checkTasaServicio = new System.Windows.Forms.CheckBox();
            this.txtCapacidadDeServicio = new System.Windows.Forms.NumericUpDown();
            this.lblTasaServicio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tblResultadosColas = new System.Windows.Forms.DataGridView();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.tabControlTipos.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.groupAccionesProductos.SuspendLayout();
            this.groupListaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).BeginInit();
            this.tabTipoProductos.SuspendLayout();
            this.groupAccionesTipos.SuspendLayout();
            this.groupTiposProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTiposProducto)).BeginInit();
            this.tabSimulacion.SuspendLayout();
            this.groupBoxResultadosSimulacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSimulacion)).BeginInit();
            this.groupParametrosEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadEscenarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHorasSimulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidadDeServicio)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblResultadosColas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTipos
            // 
            this.tabControlTipos.Controls.Add(this.tabProductos);
            this.tabControlTipos.Controls.Add(this.tabTipoProductos);
            this.tabControlTipos.Controls.Add(this.tabSimulacion);
            this.tabControlTipos.Location = new System.Drawing.Point(12, 12);
            this.tabControlTipos.Name = "tabControlTipos";
            this.tabControlTipos.SelectedIndex = 0;
            this.tabControlTipos.Size = new System.Drawing.Size(1238, 649);
            this.tabControlTipos.TabIndex = 0;
            this.tabControlTipos.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.groupAccionesProductos);
            this.tabProductos.Controls.Add(this.groupListaProductos);
            this.tabProductos.Location = new System.Drawing.Point(4, 25);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(1230, 620);
            this.tabProductos.TabIndex = 0;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // groupAccionesProductos
            // 
            this.groupAccionesProductos.Controls.Add(this.btnRecargarProductos);
            this.groupAccionesProductos.Controls.Add(this.btnHabDeshabProducto);
            this.groupAccionesProductos.Controls.Add(this.btnEditarProducto);
            this.groupAccionesProductos.Controls.Add(this.btnCrearProducto);
            this.groupAccionesProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAccionesProductos.Location = new System.Drawing.Point(1015, 6);
            this.groupAccionesProductos.Name = "groupAccionesProductos";
            this.groupAccionesProductos.Size = new System.Drawing.Size(209, 608);
            this.groupAccionesProductos.TabIndex = 2;
            this.groupAccionesProductos.TabStop = false;
            this.groupAccionesProductos.Text = "Acciones";
            // 
            // btnRecargarProductos
            // 
            this.btnRecargarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargarProductos.Location = new System.Drawing.Point(6, 154);
            this.btnRecargarProductos.Name = "btnRecargarProductos";
            this.btnRecargarProductos.Size = new System.Drawing.Size(196, 36);
            this.btnRecargarProductos.TabIndex = 3;
            this.btnRecargarProductos.Text = "Recargar productos";
            this.btnRecargarProductos.UseVisualStyleBackColor = true;
            this.btnRecargarProductos.Click += new System.EventHandler(this.btnRecargarProductos_Click);
            // 
            // btnHabDeshabProducto
            // 
            this.btnHabDeshabProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabDeshabProducto.Location = new System.Drawing.Point(6, 112);
            this.btnHabDeshabProducto.Name = "btnHabDeshabProducto";
            this.btnHabDeshabProducto.Size = new System.Drawing.Size(196, 36);
            this.btnHabDeshabProducto.TabIndex = 2;
            this.btnHabDeshabProducto.Text = "Habilitar/Deshabilitar";
            this.btnHabDeshabProducto.UseVisualStyleBackColor = true;
            this.btnHabDeshabProducto.Click += new System.EventHandler(this.btnHabDeshabProducto_Click);
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
            this.groupListaProductos.Size = new System.Drawing.Size(1003, 608);
            this.groupListaProductos.TabIndex = 1;
            this.groupListaProductos.TabStop = false;
            this.groupListaProductos.Text = "Lista productos";
            // 
            // tblProductos
            // 
            this.tblProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProductos.Location = new System.Drawing.Point(6, 29);
            this.tblProductos.MultiSelect = false;
            this.tblProductos.Name = "tblProductos";
            this.tblProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tblProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tblProductos.RowTemplate.Height = 24;
            this.tblProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblProductos.Size = new System.Drawing.Size(991, 573);
            this.tblProductos.TabIndex = 0;
            // 
            // tabTipoProductos
            // 
            this.tabTipoProductos.Controls.Add(this.groupAccionesTipos);
            this.tabTipoProductos.Controls.Add(this.groupTiposProducto);
            this.tabTipoProductos.Location = new System.Drawing.Point(4, 25);
            this.tabTipoProductos.Name = "tabTipoProductos";
            this.tabTipoProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTipoProductos.Size = new System.Drawing.Size(1230, 620);
            this.tabTipoProductos.TabIndex = 2;
            this.tabTipoProductos.Text = "Tipos producto";
            this.tabTipoProductos.UseVisualStyleBackColor = true;
            // 
            // groupAccionesTipos
            // 
            this.groupAccionesTipos.Controls.Add(this.btnRecargarTiposProducto);
            this.groupAccionesTipos.Controls.Add(this.btnHabDeshabTipoProducto);
            this.groupAccionesTipos.Controls.Add(this.btnEditarTipoProducto);
            this.groupAccionesTipos.Controls.Add(this.btnCrearTipoProducto);
            this.groupAccionesTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAccionesTipos.Location = new System.Drawing.Point(1015, 6);
            this.groupAccionesTipos.Name = "groupAccionesTipos";
            this.groupAccionesTipos.Size = new System.Drawing.Size(209, 608);
            this.groupAccionesTipos.TabIndex = 1;
            this.groupAccionesTipos.TabStop = false;
            this.groupAccionesTipos.Text = "Acciones";
            // 
            // btnRecargarTiposProducto
            // 
            this.btnRecargarTiposProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargarTiposProducto.Location = new System.Drawing.Point(6, 154);
            this.btnRecargarTiposProducto.Name = "btnRecargarTiposProducto";
            this.btnRecargarTiposProducto.Size = new System.Drawing.Size(196, 36);
            this.btnRecargarTiposProducto.TabIndex = 3;
            this.btnRecargarTiposProducto.Text = "Recargar tipos";
            this.btnRecargarTiposProducto.UseVisualStyleBackColor = true;
            this.btnRecargarTiposProducto.Click += new System.EventHandler(this.btnRecargarTiposProducto_Click);
            // 
            // btnHabDeshabTipoProducto
            // 
            this.btnHabDeshabTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabDeshabTipoProducto.Location = new System.Drawing.Point(6, 112);
            this.btnHabDeshabTipoProducto.Name = "btnHabDeshabTipoProducto";
            this.btnHabDeshabTipoProducto.Size = new System.Drawing.Size(196, 36);
            this.btnHabDeshabTipoProducto.TabIndex = 2;
            this.btnHabDeshabTipoProducto.Text = "Habilitar/Deshabilitar";
            this.btnHabDeshabTipoProducto.Click += new System.EventHandler(this.btnHabDeshabTipoProducto_Click);
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
            this.btnEditarTipoProducto.Click += new System.EventHandler(this.btnEditarTipoProducto_Click);
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
            // groupTiposProducto
            // 
            this.groupTiposProducto.Controls.Add(this.tblTiposProducto);
            this.groupTiposProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTiposProducto.Location = new System.Drawing.Point(6, 6);
            this.groupTiposProducto.Name = "groupTiposProducto";
            this.groupTiposProducto.Size = new System.Drawing.Size(1003, 608);
            this.groupTiposProducto.TabIndex = 0;
            this.groupTiposProducto.TabStop = false;
            this.groupTiposProducto.Text = "Lista tipos";
            // 
            // tblTiposProducto
            // 
            this.tblTiposProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblTiposProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTiposProducto.Location = new System.Drawing.Point(6, 29);
            this.tblTiposProducto.MultiSelect = false;
            this.tblTiposProducto.Name = "tblTiposProducto";
            this.tblTiposProducto.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tblTiposProducto.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tblTiposProducto.RowTemplate.Height = 24;
            this.tblTiposProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblTiposProducto.Size = new System.Drawing.Size(991, 573);
            this.tblTiposProducto.TabIndex = 0;
            // 
            // tabSimulacion
            // 
            this.tabSimulacion.Controls.Add(this.groupBox1);
            this.tabSimulacion.Controls.Add(this.groupBoxResultadosSimulacion);
            this.tabSimulacion.Controls.Add(this.groupParametrosEntrada);
            this.tabSimulacion.Location = new System.Drawing.Point(4, 25);
            this.tabSimulacion.Name = "tabSimulacion";
            this.tabSimulacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimulacion.Size = new System.Drawing.Size(1230, 620);
            this.tabSimulacion.TabIndex = 1;
            this.tabSimulacion.Text = "Simulacion";
            this.tabSimulacion.UseVisualStyleBackColor = true;
            // 
            // groupBoxResultadosSimulacion
            // 
            this.groupBoxResultadosSimulacion.Controls.Add(this.tblSimulacion);
            this.groupBoxResultadosSimulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxResultadosSimulacion.Location = new System.Drawing.Point(377, 6);
            this.groupBoxResultadosSimulacion.Name = "groupBoxResultadosSimulacion";
            this.groupBoxResultadosSimulacion.Size = new System.Drawing.Size(847, 396);
            this.groupBoxResultadosSimulacion.TabIndex = 2;
            this.groupBoxResultadosSimulacion.TabStop = false;
            this.groupBoxResultadosSimulacion.Text = "Resultados simulacion";
            // 
            // tblSimulacion
            // 
            this.tblSimulacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSimulacion.Location = new System.Drawing.Point(6, 25);
            this.tblSimulacion.MultiSelect = false;
            this.tblSimulacion.Name = "tblSimulacion";
            this.tblSimulacion.RowHeadersWidth = 51;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tblSimulacion.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tblSimulacion.RowTemplate.Height = 24;
            this.tblSimulacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblSimulacion.Size = new System.Drawing.Size(835, 365);
            this.tblSimulacion.TabIndex = 1;
            this.tblSimulacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblSimulacion_CellClick);
            // 
            // groupParametrosEntrada
            // 
            this.groupParametrosEntrada.Controls.Add(this.lblLeyenda);
            this.groupParametrosEntrada.Controls.Add(this.lblTasaServicio);
            this.groupParametrosEntrada.Controls.Add(this.txtCapacidadDeServicio);
            this.groupParametrosEntrada.Controls.Add(this.checkTasaServicio);
            this.groupParametrosEntrada.Controls.Add(this.btnAgregarGastos);
            this.groupParametrosEntrada.Controls.Add(this.lblSeleccionarEscenario);
            this.groupParametrosEntrada.Controls.Add(this.txtCantidadEscenarios);
            this.groupParametrosEntrada.Controls.Add(this.checkCantidadEscenarios);
            this.groupParametrosEntrada.Controls.Add(this.comboBoxEscenarios);
            this.groupParametrosEntrada.Controls.Add(this.btnGenerarRegistros);
            this.groupParametrosEntrada.Controls.Add(this.txtHorasSimulacion);
            this.groupParametrosEntrada.Controls.Add(this.lblHorasSimulacion);
            this.groupParametrosEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupParametrosEntrada.Location = new System.Drawing.Point(6, 6);
            this.groupParametrosEntrada.Name = "groupParametrosEntrada";
            this.groupParametrosEntrada.Size = new System.Drawing.Size(365, 608);
            this.groupParametrosEntrada.TabIndex = 0;
            this.groupParametrosEntrada.TabStop = false;
            this.groupParametrosEntrada.Text = "Parametros de entrada";
            // 
            // btnAgregarGastos
            // 
            this.btnAgregarGastos.Enabled = false;
            this.btnAgregarGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGastos.Location = new System.Drawing.Point(9, 228);
            this.btnAgregarGastos.Name = "btnAgregarGastos";
            this.btnAgregarGastos.Size = new System.Drawing.Size(196, 36);
            this.btnAgregarGastos.TabIndex = 8;
            this.btnAgregarGastos.Text = "Agregar gastos";
            this.btnAgregarGastos.UseVisualStyleBackColor = true;
            this.btnAgregarGastos.Click += new System.EventHandler(this.btnAgregarGastos_Click);
            // 
            // lblSeleccionarEscenario
            // 
            this.lblSeleccionarEscenario.AutoSize = true;
            this.lblSeleccionarEscenario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarEscenario.Location = new System.Drawing.Point(6, 386);
            this.lblSeleccionarEscenario.Name = "lblSeleccionarEscenario";
            this.lblSeleccionarEscenario.Size = new System.Drawing.Size(284, 18);
            this.lblSeleccionarEscenario.TabIndex = 7;
            this.lblSeleccionarEscenario.Text = "Seleccione escenario para ver resultados:";
            // 
            // txtCantidadEscenarios
            // 
            this.txtCantidadEscenarios.Enabled = false;
            this.txtCantidadEscenarios.Location = new System.Drawing.Point(9, 115);
            this.txtCantidadEscenarios.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidadEscenarios.Name = "txtCantidadEscenarios";
            this.txtCantidadEscenarios.Size = new System.Drawing.Size(120, 26);
            this.txtCantidadEscenarios.TabIndex = 6;
            this.txtCantidadEscenarios.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkCantidadEscenarios
            // 
            this.checkCantidadEscenarios.AutoSize = true;
            this.checkCantidadEscenarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCantidadEscenarios.Location = new System.Drawing.Point(9, 85);
            this.checkCantidadEscenarios.Name = "checkCantidadEscenarios";
            this.checkCantidadEscenarios.Size = new System.Drawing.Size(239, 22);
            this.checkCantidadEscenarios.TabIndex = 5;
            this.checkCantidadEscenarios.Text = "Ingresar cantidad de escenarios";
            this.checkCantidadEscenarios.UseVisualStyleBackColor = true;
            this.checkCantidadEscenarios.CheckedChanged += new System.EventHandler(this.checkCantidadEscenarios_CheckedChanged);
            // 
            // comboBoxEscenarios
            // 
            this.comboBoxEscenarios.Enabled = false;
            this.comboBoxEscenarios.FormattingEnabled = true;
            this.comboBoxEscenarios.Location = new System.Drawing.Point(9, 407);
            this.comboBoxEscenarios.Name = "comboBoxEscenarios";
            this.comboBoxEscenarios.Size = new System.Drawing.Size(196, 28);
            this.comboBoxEscenarios.TabIndex = 4;
            this.comboBoxEscenarios.SelectedIndexChanged += new System.EventHandler(this.comboBoxEscenarios_SelectedIndexChanged);
            // 
            // btnGenerarRegistros
            // 
            this.btnGenerarRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarRegistros.Location = new System.Drawing.Point(9, 165);
            this.btnGenerarRegistros.Name = "btnGenerarRegistros";
            this.btnGenerarRegistros.Size = new System.Drawing.Size(196, 36);
            this.btnGenerarRegistros.TabIndex = 3;
            this.btnGenerarRegistros.Text = "Generar simulacion";
            this.btnGenerarRegistros.UseVisualStyleBackColor = true;
            this.btnGenerarRegistros.Click += new System.EventHandler(this.btnGenerarRegistros_Click);
            // 
            // txtHorasSimulacion
            // 
            this.txtHorasSimulacion.Location = new System.Drawing.Point(126, 33);
            this.txtHorasSimulacion.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.txtHorasSimulacion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHorasSimulacion.Name = "txtHorasSimulacion";
            this.txtHorasSimulacion.Size = new System.Drawing.Size(120, 26);
            this.txtHorasSimulacion.TabIndex = 2;
            this.txtHorasSimulacion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblHorasSimulacion
            // 
            this.lblHorasSimulacion.AutoSize = true;
            this.lblHorasSimulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasSimulacion.Location = new System.Drawing.Point(6, 36);
            this.lblHorasSimulacion.Name = "lblHorasSimulacion";
            this.lblHorasSimulacion.Size = new System.Drawing.Size(117, 18);
            this.lblHorasSimulacion.TabIndex = 0;
            this.lblHorasSimulacion.Text = "Horas a simular:";
            // 
            // checkTasaServicio
            // 
            this.checkTasaServicio.AutoSize = true;
            this.checkTasaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTasaServicio.Location = new System.Drawing.Point(9, 307);
            this.checkTasaServicio.Name = "checkTasaServicio";
            this.checkTasaServicio.Size = new System.Drawing.Size(325, 22);
            this.checkTasaServicio.TabIndex = 9;
            this.checkTasaServicio.Text = "Ingresar capacidad de servicio personalizada";
            this.checkTasaServicio.UseVisualStyleBackColor = true;
            this.checkTasaServicio.CheckedChanged += new System.EventHandler(this.checkTasaServicio_CheckedChanged);
            // 
            // txtCapacidadDeServicio
            // 
            this.txtCapacidadDeServicio.Enabled = false;
            this.txtCapacidadDeServicio.Location = new System.Drawing.Point(9, 335);
            this.txtCapacidadDeServicio.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtCapacidadDeServicio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCapacidadDeServicio.Name = "txtCapacidadDeServicio";
            this.txtCapacidadDeServicio.Size = new System.Drawing.Size(120, 26);
            this.txtCapacidadDeServicio.TabIndex = 10;
            this.txtCapacidadDeServicio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTasaServicio
            // 
            this.lblTasaServicio.AutoSize = true;
            this.lblTasaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasaServicio.Location = new System.Drawing.Point(135, 337);
            this.lblTasaServicio.Name = "lblTasaServicio";
            this.lblTasaServicio.Size = new System.Drawing.Size(102, 18);
            this.lblTasaServicio.TabIndex = 11;
            this.lblTasaServicio.Text = "(clientes/hora)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tblResultadosColas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(377, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 206);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados de linea";
            // 
            // tblResultadosColas
            // 
            this.tblResultadosColas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblResultadosColas.Location = new System.Drawing.Point(6, 25);
            this.tblResultadosColas.Name = "tblResultadosColas";
            this.tblResultadosColas.ReadOnly = true;
            this.tblResultadosColas.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tblResultadosColas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.tblResultadosColas.RowTemplate.Height = 24;
            this.tblResultadosColas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblResultadosColas.Size = new System.Drawing.Size(835, 175);
            this.tblResultadosColas.TabIndex = 0;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.Location = new System.Drawing.Point(6, 460);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(341, 96);
            this.lblLeyenda.TabIndex = 12;
            this.lblLeyenda.Text = resources.GetString("lblLeyenda.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.tabControlTipos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControlTipos.ResumeLayout(false);
            this.tabProductos.ResumeLayout(false);
            this.groupAccionesProductos.ResumeLayout(false);
            this.groupListaProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).EndInit();
            this.tabTipoProductos.ResumeLayout(false);
            this.groupAccionesTipos.ResumeLayout(false);
            this.groupTiposProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblTiposProducto)).EndInit();
            this.tabSimulacion.ResumeLayout(false);
            this.groupBoxResultadosSimulacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblSimulacion)).EndInit();
            this.groupParametrosEntrada.ResumeLayout(false);
            this.groupParametrosEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadEscenarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHorasSimulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidadDeServicio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblResultadosColas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTipos;
        private System.Windows.Forms.TabPage tabSimulacion;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.DataGridView tblProductos;
        private System.Windows.Forms.GroupBox groupAccionesProductos;
        private System.Windows.Forms.GroupBox groupListaProductos;
        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.Button btnHabDeshabProducto;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.GroupBox groupParametrosEntrada;
        private System.Windows.Forms.Label lblHorasSimulacion;
        private System.Windows.Forms.NumericUpDown txtHorasSimulacion;
        private System.Windows.Forms.DataGridView tblSimulacion;
        private System.Windows.Forms.TabPage tabTipoProductos;
        private System.Windows.Forms.GroupBox groupAccionesTipos;
        private System.Windows.Forms.Button btnCrearTipoProducto;
        private System.Windows.Forms.GroupBox groupTiposProducto;
        private System.Windows.Forms.Button btnHabDeshabTipoProducto;
        private System.Windows.Forms.Button btnEditarTipoProducto;
        private System.Windows.Forms.DataGridView tblTiposProducto;
        private System.Windows.Forms.Button btnRecargarProductos;
        private System.Windows.Forms.Button btnRecargarTiposProducto;
        private System.Windows.Forms.Button btnGenerarRegistros;
        private System.Windows.Forms.ComboBox comboBoxEscenarios;
        private System.Windows.Forms.Label lblSeleccionarEscenario;
        private System.Windows.Forms.NumericUpDown txtCantidadEscenarios;
        private System.Windows.Forms.CheckBox checkCantidadEscenarios;
        private System.Windows.Forms.GroupBox groupBoxResultadosSimulacion;
        private System.Windows.Forms.Button btnAgregarGastos;
        private System.Windows.Forms.Label lblTasaServicio;
        private System.Windows.Forms.NumericUpDown txtCapacidadDeServicio;
        private System.Windows.Forms.CheckBox checkTasaServicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tblResultadosColas;
        private System.Windows.Forms.Label lblLeyenda;
    }
}

