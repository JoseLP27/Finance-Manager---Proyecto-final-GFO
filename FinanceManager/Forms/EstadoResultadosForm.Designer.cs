#nullable disable

namespace FinanceManager.Forms;

partial class EstadoResultadosForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.panelEncabezado = new System.Windows.Forms.Panel();
        this.lblSubtitulo = new System.Windows.Forms.Label();
        this.lblTitulo = new System.Windows.Forms.Label();
        this.btnCerrar = new System.Windows.Forms.Button();
        this.panelDatos = new System.Windows.Forms.Panel();
        this.btnGuardar = new System.Windows.Forms.Button();
        this.btnLimpiar = new System.Windows.Forms.Button();
        this.btnCalcular = new System.Windows.Forms.Button();
        this.grpCostos = new System.Windows.Forms.GroupBox();
        this.lblOtrosGastos = new System.Windows.Forms.Label();
        this.numOtrosGastos = new System.Windows.Forms.NumericUpDown();
        this.lblDepreciacion = new System.Windows.Forms.Label();
        this.numDepreciacion = new System.Windows.Forms.NumericUpDown();
        this.lblGastosVentas = new System.Windows.Forms.Label();
        this.numGastosVentas = new System.Windows.Forms.NumericUpDown();
        this.lblGastosAdministracion = new System.Windows.Forms.Label();
        this.numGastosAdministracion = new System.Windows.Forms.NumericUpDown();
        this.lblCostoVentas = new System.Windows.Forms.Label();
        this.numCostoVentas = new System.Windows.Forms.NumericUpDown();
        this.grpIngresos = new System.Windows.Forms.GroupBox();
        this.lblOtrosIngresos = new System.Windows.Forms.Label();
        this.numOtrosIngresos = new System.Windows.Forms.NumericUpDown();
        this.lblVentas = new System.Windows.Forms.Label();
        this.numVentas = new System.Windows.Forms.NumericUpDown();
        this.grpDatos = new System.Windows.Forms.GroupBox();
        this.lblTasaNota = new System.Windows.Forms.Label();
        this.numTasa = new System.Windows.Forms.NumericUpDown();
        this.lblTasa = new System.Windows.Forms.Label();
        this.txtPeriodo = new System.Windows.Forms.TextBox();
        this.lblPeriodo = new System.Windows.Forms.Label();
        this.txtEmpresa = new System.Windows.Forms.TextBox();
        this.lblEmpresa = new System.Windows.Forms.Label();
        this.grpResumen = new System.Windows.Forms.GroupBox();
        this.lblNotaMoneda = new System.Windows.Forms.Label();
        this.lblMensaje = new System.Windows.Forms.Label();
        this.cardUtilidad = new System.Windows.Forms.Panel();
        this.lblUtilidadNeta = new System.Windows.Forms.Label();
        this.lblEtiquetaUtilidadNeta = new System.Windows.Forms.Label();
        this.lblImpuesto = new System.Windows.Forms.Label();
        this.lblTituloImpuesto = new System.Windows.Forms.Label();
        this.lblUtilidadAntes = new System.Windows.Forms.Label();
        this.lblTituloUtilidadAntes = new System.Windows.Forms.Label();
        this.lblOtrosGastosResumen = new System.Windows.Forms.Label();
        this.lblTituloOtrosGastos = new System.Windows.Forms.Label();
        this.lblUtilidadOperativa = new System.Windows.Forms.Label();
        this.lblTituloUtilidadOperativa = new System.Windows.Forms.Label();
        this.lblGastosOperativos = new System.Windows.Forms.Label();
        this.lblTituloGastosOperativos = new System.Windows.Forms.Label();
        this.lblUtilidadBruta = new System.Windows.Forms.Label();
        this.lblTituloUtilidadBruta = new System.Windows.Forms.Label();
        this.lblCostoVentasResumen = new System.Windows.Forms.Label();
        this.lblTituloCostoVentas = new System.Windows.Forms.Label();
        this.lblIngresosTotales = new System.Windows.Forms.Label();
        this.lblTituloIngresosTotales = new System.Windows.Forms.Label();
        this.lblResumenEncabezado = new System.Windows.Forms.Label();
        this.panelEncabezado.SuspendLayout();
        this.panelDatos.SuspendLayout();
        this.grpCostos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numOtrosGastos)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numDepreciacion)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numGastosVentas)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numGastosAdministracion)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numCostoVentas)).BeginInit();
        this.grpIngresos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numOtrosIngresos)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numVentas)).BeginInit();
        this.grpDatos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numTasa)).BeginInit();
        this.grpResumen.SuspendLayout();
        this.cardUtilidad.SuspendLayout();
        this.SuspendLayout();
        // 
        // panelEncabezado
        // 
        this.panelEncabezado.BackColor = System.Drawing.Color.FromArgb(20, 33, 61);
        this.panelEncabezado.Controls.Add(this.btnCerrar);
        this.panelEncabezado.Controls.Add(this.lblSubtitulo);
        this.panelEncabezado.Controls.Add(this.lblTitulo);
        this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
        this.panelEncabezado.Name = "panelEncabezado";
        this.panelEncabezado.Size = new System.Drawing.Size(1040, 84);
        this.panelEncabezado.TabIndex = 0;
        // 
        // lblSubtitulo
        // 
        this.lblSubtitulo.AutoSize = true;
        this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(201, 211, 230);
        this.lblSubtitulo.Location = new System.Drawing.Point(32, 48);
        this.lblSubtitulo.Name = "lblSubtitulo";
        this.lblSubtitulo.Size = new System.Drawing.Size(525, 17);
        this.lblSubtitulo.TabIndex = 1;
        this.lblSubtitulo.Text = "Completa los datos del período para calcular el resultado del ejercicio.";
        // 
        // lblTitulo
        // 
        this.lblTitulo.AutoSize = true;
        this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        this.lblTitulo.ForeColor = System.Drawing.Color.White;
        this.lblTitulo.Location = new System.Drawing.Point(30, 12);
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.Size = new System.Drawing.Size(255, 37);
        this.lblTitulo.TabIndex = 0;
        this.lblTitulo.Text = "Estado de Resultados";
        // 
        // btnCerrar
        // 
        this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(20, 33, 61);
        this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(148, 163, 184);
        this.btnCerrar.FlatAppearance.BorderSize = 1;
        this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 58, 138);
        this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnCerrar.ForeColor = System.Drawing.Color.White;
        this.btnCerrar.Location = new System.Drawing.Point(920, 24);
        this.btnCerrar.Name = "btnCerrar";
        this.btnCerrar.Size = new System.Drawing.Size(88, 34);
        this.btnCerrar.TabIndex = 2;
        this.btnCerrar.Text = "Cerrar";
        this.btnCerrar.UseVisualStyleBackColor = false;
        this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
        // 
        // panelDatos
        // 
        this.panelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.panelDatos.AutoScroll = true;
        this.panelDatos.BackColor = System.Drawing.Color.White;
        this.panelDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panelDatos.Controls.Add(this.btnGuardar);
        this.panelDatos.Controls.Add(this.btnLimpiar);
        this.panelDatos.Controls.Add(this.btnCalcular);
        this.panelDatos.Controls.Add(this.grpCostos);
        this.panelDatos.Controls.Add(this.grpIngresos);
        this.panelDatos.Controls.Add(this.grpDatos);
        this.panelDatos.Location = new System.Drawing.Point(24, 96);
        this.panelDatos.Name = "panelDatos";
        this.panelDatos.Size = new System.Drawing.Size(560, 520);
        this.panelDatos.TabIndex = 1;
        // 
        // btnGuardar
        // 
        this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnGuardar.BackColor = System.Drawing.Color.White;
        this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
        this.btnGuardar.FlatAppearance.BorderSize = 1;
        this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.btnGuardar.Location = new System.Drawing.Point(404, 466);
        this.btnGuardar.Name = "btnGuardar";
        this.btnGuardar.Size = new System.Drawing.Size(144, 42);
        this.btnGuardar.TabIndex = 5;
        this.btnGuardar.Text = "Guardar reporte";
        this.btnGuardar.UseVisualStyleBackColor = false;
        this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
        // 
        // btnLimpiar
        // 
        this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
        this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnLimpiar.FlatAppearance.BorderSize = 0;
        this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(203, 213, 225);
        this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.btnLimpiar.Location = new System.Drawing.Point(248, 466);
        this.btnLimpiar.Name = "btnLimpiar";
        this.btnLimpiar.Size = new System.Drawing.Size(140, 42);
        this.btnLimpiar.TabIndex = 4;
        this.btnLimpiar.Text = "Limpiar";
        this.btnLimpiar.UseVisualStyleBackColor = false;
        this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
        // 
        // btnCalcular
        // 
        this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnCalcular.FlatAppearance.BorderSize = 0;
        this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 78, 216);
        this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnCalcular.ForeColor = System.Drawing.Color.White;
        this.btnCalcular.Location = new System.Drawing.Point(12, 466);
        this.btnCalcular.Name = "btnCalcular";
        this.btnCalcular.Size = new System.Drawing.Size(220, 42);
        this.btnCalcular.TabIndex = 3;
        this.btnCalcular.Text = "Calcular";
        this.btnCalcular.UseVisualStyleBackColor = false;
        this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
        // 
        // grpCostos
        // 
        this.grpCostos.Controls.Add(this.lblOtrosGastos);
        this.grpCostos.Controls.Add(this.numOtrosGastos);
        this.grpCostos.Controls.Add(this.lblDepreciacion);
        this.grpCostos.Controls.Add(this.numDepreciacion);
        this.grpCostos.Controls.Add(this.lblGastosVentas);
        this.grpCostos.Controls.Add(this.numGastosVentas);
        this.grpCostos.Controls.Add(this.lblGastosAdministracion);
        this.grpCostos.Controls.Add(this.numGastosAdministracion);
        this.grpCostos.Controls.Add(this.lblCostoVentas);
        this.grpCostos.Controls.Add(this.numCostoVentas);
        this.grpCostos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right));
        this.grpCostos.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpCostos.Location = new System.Drawing.Point(12, 256);
        this.grpCostos.Name = "grpCostos";
        this.grpCostos.Size = new System.Drawing.Size(536, 200);
        this.grpCostos.TabIndex = 2;
        this.grpCostos.TabStop = false;
        this.grpCostos.Text = "Costos y gastos";
        // 
        // lblOtrosGastos
        // 
        this.lblOtrosGastos.Location = new System.Drawing.Point(16, 154);
        this.lblOtrosGastos.Name = "lblOtrosGastos";
        this.lblOtrosGastos.Size = new System.Drawing.Size(240, 23);
        this.lblOtrosGastos.TabIndex = 8;
        this.lblOtrosGastos.Text = "Otros gastos:";
        this.lblOtrosGastos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numOtrosGastos
        // 
        this.numOtrosGastos.DecimalPlaces = 2;
        this.numOtrosGastos.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numOtrosGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numOtrosGastos.Location = new System.Drawing.Point(268, 150);
        this.numOtrosGastos.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numOtrosGastos.Name = "numOtrosGastos";
        this.numOtrosGastos.Size = new System.Drawing.Size(252, 25);
        this.numOtrosGastos.TabIndex = 9;
        this.numOtrosGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numOtrosGastos.ThousandsSeparator = true;
        // 
        // lblDepreciacion
        // 
        this.lblDepreciacion.Location = new System.Drawing.Point(16, 122);
        this.lblDepreciacion.Name = "lblDepreciacion";
        this.lblDepreciacion.Size = new System.Drawing.Size(240, 23);
        this.lblDepreciacion.TabIndex = 6;
        this.lblDepreciacion.Text = "Depreciación y amortización:";
        this.lblDepreciacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numDepreciacion
        // 
        this.numDepreciacion.DecimalPlaces = 2;
        this.numDepreciacion.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numDepreciacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numDepreciacion.Location = new System.Drawing.Point(268, 118);
        this.numDepreciacion.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numDepreciacion.Name = "numDepreciacion";
        this.numDepreciacion.Size = new System.Drawing.Size(252, 25);
        this.numDepreciacion.TabIndex = 7;
        this.numDepreciacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numDepreciacion.ThousandsSeparator = true;
        // 
        // lblGastosVentas
        // 
        this.lblGastosVentas.Location = new System.Drawing.Point(16, 90);
        this.lblGastosVentas.Name = "lblGastosVentas";
        this.lblGastosVentas.Size = new System.Drawing.Size(240, 23);
        this.lblGastosVentas.TabIndex = 4;
        this.lblGastosVentas.Text = "Gastos de ventas:";
        this.lblGastosVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numGastosVentas
        // 
        this.numGastosVentas.DecimalPlaces = 2;
        this.numGastosVentas.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numGastosVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numGastosVentas.Location = new System.Drawing.Point(268, 86);
        this.numGastosVentas.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numGastosVentas.Name = "numGastosVentas";
        this.numGastosVentas.Size = new System.Drawing.Size(252, 25);
        this.numGastosVentas.TabIndex = 5;
        this.numGastosVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numGastosVentas.ThousandsSeparator = true;
        // 
        // lblGastosAdministracion
        // 
        this.lblGastosAdministracion.Location = new System.Drawing.Point(16, 58);
        this.lblGastosAdministracion.Name = "lblGastosAdministracion";
        this.lblGastosAdministracion.Size = new System.Drawing.Size(240, 23);
        this.lblGastosAdministracion.TabIndex = 2;
        this.lblGastosAdministracion.Text = "Gastos de administración:";
        this.lblGastosAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numGastosAdministracion
        // 
        this.numGastosAdministracion.DecimalPlaces = 2;
        this.numGastosAdministracion.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numGastosAdministracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numGastosAdministracion.Location = new System.Drawing.Point(268, 54);
        this.numGastosAdministracion.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numGastosAdministracion.Name = "numGastosAdministracion";
        this.numGastosAdministracion.Size = new System.Drawing.Size(252, 25);
        this.numGastosAdministracion.TabIndex = 3;
        this.numGastosAdministracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numGastosAdministracion.ThousandsSeparator = true;
        // 
        // lblCostoVentas
        // 
        this.lblCostoVentas.Location = new System.Drawing.Point(16, 26);
        this.lblCostoVentas.Name = "lblCostoVentas";
        this.lblCostoVentas.Size = new System.Drawing.Size(240, 23);
        this.lblCostoVentas.TabIndex = 0;
        this.lblCostoVentas.Text = "Costo de ventas:";
        this.lblCostoVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numCostoVentas
        // 
        this.numCostoVentas.DecimalPlaces = 2;
        this.numCostoVentas.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numCostoVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numCostoVentas.Location = new System.Drawing.Point(268, 22);
        this.numCostoVentas.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numCostoVentas.Name = "numCostoVentas";
        this.numCostoVentas.Size = new System.Drawing.Size(252, 25);
        this.numCostoVentas.TabIndex = 1;
        this.numCostoVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numCostoVentas.ThousandsSeparator = true;
        // 
        // grpIngresos
        // 
        this.grpIngresos.Controls.Add(this.lblOtrosIngresos);
        this.grpIngresos.Controls.Add(this.numOtrosIngresos);
        this.grpIngresos.Controls.Add(this.lblVentas);
        this.grpIngresos.Controls.Add(this.numVentas);
        this.grpIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right));
        this.grpIngresos.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpIngresos.Location = new System.Drawing.Point(12, 144);
        this.grpIngresos.Name = "grpIngresos";
        this.grpIngresos.Size = new System.Drawing.Size(536, 100);
        this.grpIngresos.TabIndex = 1;
        this.grpIngresos.TabStop = false;
        this.grpIngresos.Text = "Ingresos";
        // 
        // lblOtrosIngresos
        // 
        this.lblOtrosIngresos.Location = new System.Drawing.Point(16, 62);
        this.lblOtrosIngresos.Name = "lblOtrosIngresos";
        this.lblOtrosIngresos.Size = new System.Drawing.Size(240, 23);
        this.lblOtrosIngresos.TabIndex = 2;
        this.lblOtrosIngresos.Text = "Otros ingresos:";
        this.lblOtrosIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numOtrosIngresos
        // 
        this.numOtrosIngresos.DecimalPlaces = 2;
        this.numOtrosIngresos.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numOtrosIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numOtrosIngresos.Location = new System.Drawing.Point(268, 58);
        this.numOtrosIngresos.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numOtrosIngresos.Name = "numOtrosIngresos";
        this.numOtrosIngresos.Size = new System.Drawing.Size(252, 25);
        this.numOtrosIngresos.TabIndex = 3;
        this.numOtrosIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numOtrosIngresos.ThousandsSeparator = true;
        // 
        // lblVentas
        // 
        this.lblVentas.Location = new System.Drawing.Point(16, 30);
        this.lblVentas.Name = "lblVentas";
        this.lblVentas.Size = new System.Drawing.Size(240, 23);
        this.lblVentas.TabIndex = 0;
        this.lblVentas.Text = "Ventas netas:";
        this.lblVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numVentas
        // 
        this.numVentas.DecimalPlaces = 2;
        this.numVentas.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numVentas.Location = new System.Drawing.Point(268, 26);
        this.numVentas.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numVentas.Name = "numVentas";
        this.numVentas.Size = new System.Drawing.Size(252, 25);
        this.numVentas.TabIndex = 1;
        this.numVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numVentas.ThousandsSeparator = true;
        // 
        // grpDatos
        // 
        this.grpDatos.Controls.Add(this.lblTasaNota);
        this.grpDatos.Controls.Add(this.numTasa);
        this.grpDatos.Controls.Add(this.lblTasa);
        this.grpDatos.Controls.Add(this.txtPeriodo);
        this.grpDatos.Controls.Add(this.lblPeriodo);
        this.grpDatos.Controls.Add(this.txtEmpresa);
        this.grpDatos.Controls.Add(this.lblEmpresa);
        this.grpDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right));
        this.grpDatos.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpDatos.Location = new System.Drawing.Point(12, 12);
        this.grpDatos.Name = "grpDatos";
        this.grpDatos.Size = new System.Drawing.Size(536, 120);
        this.grpDatos.TabIndex = 0;
        this.grpDatos.TabStop = false;
        this.grpDatos.Text = "Datos generales";
        // 
        // lblTasaNota
        // 
        this.lblTasaNota.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblTasaNota.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        this.lblTasaNota.Location = new System.Drawing.Point(282, 86);
        this.lblTasaNota.Name = "lblTasaNota";
        this.lblTasaNota.Size = new System.Drawing.Size(220, 23);
        this.lblTasaNota.TabIndex = 6;
        this.lblTasaNota.Text = "Sobre la renta";
        this.lblTasaNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numTasa
        // 
        this.numTasa.DecimalPlaces = 2;
        this.numTasa.Increment = new decimal(new int[] { 1, 0, 0, 0 });
        this.numTasa.Location = new System.Drawing.Point(172, 82);
        this.numTasa.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
        this.numTasa.Name = "numTasa";
        this.numTasa.Size = new System.Drawing.Size(100, 25);
        this.numTasa.TabIndex = 5;
        this.numTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numTasa.Value = new decimal(new int[] { 30, 0, 0, 0 });
        // 
        // lblTasa
        // 
        this.lblTasa.Location = new System.Drawing.Point(16, 86);
        this.lblTasa.Name = "lblTasa";
        this.lblTasa.Size = new System.Drawing.Size(150, 23);
        this.lblTasa.TabIndex = 4;
        this.lblTasa.Text = "Tasa de impuesto (%):";
        this.lblTasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtPeriodo
        // 
        this.txtPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right));
        this.txtPeriodo.Location = new System.Drawing.Point(112, 52);
        this.txtPeriodo.Name = "txtPeriodo";
        this.txtPeriodo.PlaceholderText = "Ej. Enero - Diciembre 2026";
        this.txtPeriodo.Size = new System.Drawing.Size(408, 27);
        this.txtPeriodo.TabIndex = 3;
        // 
        // lblPeriodo
        // 
        this.lblPeriodo.Location = new System.Drawing.Point(16, 56);
        this.lblPeriodo.Name = "lblPeriodo";
        this.lblPeriodo.Size = new System.Drawing.Size(90, 23);
        this.lblPeriodo.TabIndex = 2;
        this.lblPeriodo.Text = "Período:";
        this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtEmpresa
        // 
        this.txtEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right));
        this.txtEmpresa.Location = new System.Drawing.Point(112, 22);
        this.txtEmpresa.Name = "txtEmpresa";
        this.txtEmpresa.PlaceholderText = "Nombre de la empresa u organización";
        this.txtEmpresa.Size = new System.Drawing.Size(408, 27);
        this.txtEmpresa.TabIndex = 1;
        // 
        // lblEmpresa
        // 
        this.lblEmpresa.Location = new System.Drawing.Point(16, 26);
        this.lblEmpresa.Name = "lblEmpresa";
        this.lblEmpresa.Size = new System.Drawing.Size(90, 23);
        this.lblEmpresa.TabIndex = 0;
        this.lblEmpresa.Text = "Empresa:";
        this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // grpResumen
        // 
        this.grpResumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.grpResumen.BackColor = System.Drawing.Color.White;
        this.grpResumen.Controls.Add(this.lblNotaMoneda);
        this.grpResumen.Controls.Add(this.lblMensaje);
        this.grpResumen.Controls.Add(this.cardUtilidad);
        this.grpResumen.Controls.Add(this.lblImpuesto);
        this.grpResumen.Controls.Add(this.lblTituloImpuesto);
        this.grpResumen.Controls.Add(this.lblUtilidadAntes);
        this.grpResumen.Controls.Add(this.lblTituloUtilidadAntes);
        this.grpResumen.Controls.Add(this.lblOtrosGastosResumen);
        this.grpResumen.Controls.Add(this.lblTituloOtrosGastos);
        this.grpResumen.Controls.Add(this.lblUtilidadOperativa);
        this.grpResumen.Controls.Add(this.lblTituloUtilidadOperativa);
        this.grpResumen.Controls.Add(this.lblGastosOperativos);
        this.grpResumen.Controls.Add(this.lblTituloGastosOperativos);
        this.grpResumen.Controls.Add(this.lblUtilidadBruta);
        this.grpResumen.Controls.Add(this.lblTituloUtilidadBruta);
        this.grpResumen.Controls.Add(this.lblCostoVentasResumen);
        this.grpResumen.Controls.Add(this.lblTituloCostoVentas);
        this.grpResumen.Controls.Add(this.lblIngresosTotales);
        this.grpResumen.Controls.Add(this.lblTituloIngresosTotales);
        this.grpResumen.Controls.Add(this.lblResumenEncabezado);
        this.grpResumen.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpResumen.Location = new System.Drawing.Point(608, 96);
        this.grpResumen.Name = "grpResumen";
        this.grpResumen.Size = new System.Drawing.Size(408, 520);
        this.grpResumen.TabIndex = 2;
        this.grpResumen.TabStop = false;
        this.grpResumen.Text = "Resumen del período";
        // 
        // lblNotaMoneda
        // 
        this.lblNotaMoneda.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblNotaMoneda.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        this.lblNotaMoneda.Location = new System.Drawing.Point(16, 464);
        this.lblNotaMoneda.Name = "lblNotaMoneda";
        this.lblNotaMoneda.Size = new System.Drawing.Size(376, 40);
        this.lblNotaMoneda.TabIndex = 19;
        this.lblNotaMoneda.Text = "La utilidad neta se traslada al patrimonio del balance general.\r\nExpresado en córdobas (C$).";
        // 
        // lblMensaje
        // 
        this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblMensaje.Location = new System.Drawing.Point(16, 382);
        this.lblMensaje.Name = "lblMensaje";
        this.lblMensaje.Size = new System.Drawing.Size(376, 56);
        this.lblMensaje.TabIndex = 18;
        this.lblMensaje.Text = "Completa los datos y presiona Calcular para ver el resumen.";
        // 
        // cardUtilidad
        // 
        this.cardUtilidad.BackColor = System.Drawing.Color.FromArgb(15, 118, 110);
        this.cardUtilidad.Controls.Add(this.lblUtilidadNeta);
        this.cardUtilidad.Controls.Add(this.lblEtiquetaUtilidadNeta);
        this.cardUtilidad.Location = new System.Drawing.Point(16, 290);
        this.cardUtilidad.Name = "cardUtilidad";
        this.cardUtilidad.Size = new System.Drawing.Size(376, 86);
        this.cardUtilidad.TabIndex = 17;
        // 
        // lblUtilidadNeta
        // 
        this.lblUtilidadNeta.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        this.lblUtilidadNeta.ForeColor = System.Drawing.Color.White;
        this.lblUtilidadNeta.Location = new System.Drawing.Point(14, 26);
        this.lblUtilidadNeta.Name = "lblUtilidadNeta";
        this.lblUtilidadNeta.Size = new System.Drawing.Size(348, 40);
        this.lblUtilidadNeta.TabIndex = 1;
        this.lblUtilidadNeta.Text = "—";
        this.lblUtilidadNeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblEtiquetaUtilidadNeta
        // 
        this.lblEtiquetaUtilidadNeta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblEtiquetaUtilidadNeta.ForeColor = System.Drawing.Color.FromArgb(204, 251, 241);
        this.lblEtiquetaUtilidadNeta.Location = new System.Drawing.Point(14, 8);
        this.lblEtiquetaUtilidadNeta.Name = "lblEtiquetaUtilidadNeta";
        this.lblEtiquetaUtilidadNeta.Size = new System.Drawing.Size(348, 20);
        this.lblEtiquetaUtilidadNeta.TabIndex = 0;
        this.lblEtiquetaUtilidadNeta.Text = "UTILIDAD NETA";
        // 
        // lblImpuesto
        // 
        this.lblImpuesto.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblImpuesto.Location = new System.Drawing.Point(206, 250);
        this.lblImpuesto.Name = "lblImpuesto";
        this.lblImpuesto.Size = new System.Drawing.Size(186, 24);
        this.lblImpuesto.TabIndex = 16;
        this.lblImpuesto.Text = "—";
        this.lblImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloImpuesto
        // 
        this.lblTituloImpuesto.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblTituloImpuesto.Location = new System.Drawing.Point(16, 250);
        this.lblTituloImpuesto.Name = "lblTituloImpuesto";
        this.lblTituloImpuesto.Size = new System.Drawing.Size(190, 24);
        this.lblTituloImpuesto.TabIndex = 15;
        this.lblTituloImpuesto.Text = "Impuesto sobre la renta";
        this.lblTituloImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblUtilidadAntes
        // 
        this.lblUtilidadAntes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblUtilidadAntes.Location = new System.Drawing.Point(206, 220);
        this.lblUtilidadAntes.Name = "lblUtilidadAntes";
        this.lblUtilidadAntes.Size = new System.Drawing.Size(186, 24);
        this.lblUtilidadAntes.TabIndex = 14;
        this.lblUtilidadAntes.Text = "—";
        this.lblUtilidadAntes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloUtilidadAntes
        // 
        this.lblTituloUtilidadAntes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblTituloUtilidadAntes.Location = new System.Drawing.Point(16, 220);
        this.lblTituloUtilidadAntes.Name = "lblTituloUtilidadAntes";
        this.lblTituloUtilidadAntes.Size = new System.Drawing.Size(190, 24);
        this.lblTituloUtilidadAntes.TabIndex = 13;
        this.lblTituloUtilidadAntes.Text = "Utilidad antes de impuestos";
        this.lblTituloUtilidadAntes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblOtrosGastosResumen
        // 
        this.lblOtrosGastosResumen.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblOtrosGastosResumen.Location = new System.Drawing.Point(206, 190);
        this.lblOtrosGastosResumen.Name = "lblOtrosGastosResumen";
        this.lblOtrosGastosResumen.Size = new System.Drawing.Size(186, 24);
        this.lblOtrosGastosResumen.TabIndex = 12;
        this.lblOtrosGastosResumen.Text = "—";
        this.lblOtrosGastosResumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloOtrosGastos
        // 
        this.lblTituloOtrosGastos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblTituloOtrosGastos.Location = new System.Drawing.Point(16, 190);
        this.lblTituloOtrosGastos.Name = "lblTituloOtrosGastos";
        this.lblTituloOtrosGastos.Size = new System.Drawing.Size(190, 24);
        this.lblTituloOtrosGastos.TabIndex = 11;
        this.lblTituloOtrosGastos.Text = "Otros gastos";
        this.lblTituloOtrosGastos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblUtilidadOperativa
        // 
        this.lblUtilidadOperativa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblUtilidadOperativa.Location = new System.Drawing.Point(206, 160);
        this.lblUtilidadOperativa.Name = "lblUtilidadOperativa";
        this.lblUtilidadOperativa.Size = new System.Drawing.Size(186, 24);
        this.lblUtilidadOperativa.TabIndex = 10;
        this.lblUtilidadOperativa.Text = "—";
        this.lblUtilidadOperativa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloUtilidadOperativa
        // 
        this.lblTituloUtilidadOperativa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblTituloUtilidadOperativa.Location = new System.Drawing.Point(16, 160);
        this.lblTituloUtilidadOperativa.Name = "lblTituloUtilidadOperativa";
        this.lblTituloUtilidadOperativa.Size = new System.Drawing.Size(190, 24);
        this.lblTituloUtilidadOperativa.TabIndex = 9;
        this.lblTituloUtilidadOperativa.Text = "Utilidad operativa";
        this.lblTituloUtilidadOperativa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblGastosOperativos
        // 
        this.lblGastosOperativos.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblGastosOperativos.Location = new System.Drawing.Point(206, 130);
        this.lblGastosOperativos.Name = "lblGastosOperativos";
        this.lblGastosOperativos.Size = new System.Drawing.Size(186, 24);
        this.lblGastosOperativos.TabIndex = 8;
        this.lblGastosOperativos.Text = "—";
        this.lblGastosOperativos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloGastosOperativos
        // 
        this.lblTituloGastosOperativos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblTituloGastosOperativos.Location = new System.Drawing.Point(16, 130);
        this.lblTituloGastosOperativos.Name = "lblTituloGastosOperativos";
        this.lblTituloGastosOperativos.Size = new System.Drawing.Size(190, 24);
        this.lblTituloGastosOperativos.TabIndex = 7;
        this.lblTituloGastosOperativos.Text = "Gastos operativos";
        this.lblTituloGastosOperativos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblUtilidadBruta
        // 
        this.lblUtilidadBruta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblUtilidadBruta.Location = new System.Drawing.Point(206, 100);
        this.lblUtilidadBruta.Name = "lblUtilidadBruta";
        this.lblUtilidadBruta.Size = new System.Drawing.Size(186, 24);
        this.lblUtilidadBruta.TabIndex = 6;
        this.lblUtilidadBruta.Text = "—";
        this.lblUtilidadBruta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloUtilidadBruta
        // 
        this.lblTituloUtilidadBruta.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblTituloUtilidadBruta.Location = new System.Drawing.Point(16, 100);
        this.lblTituloUtilidadBruta.Name = "lblTituloUtilidadBruta";
        this.lblTituloUtilidadBruta.Size = new System.Drawing.Size(190, 24);
        this.lblTituloUtilidadBruta.TabIndex = 5;
        this.lblTituloUtilidadBruta.Text = "Utilidad bruta";
        this.lblTituloUtilidadBruta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblCostoVentasResumen
        // 
        this.lblCostoVentasResumen.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblCostoVentasResumen.Location = new System.Drawing.Point(206, 70);
        this.lblCostoVentasResumen.Name = "lblCostoVentasResumen";
        this.lblCostoVentasResumen.Size = new System.Drawing.Size(186, 24);
        this.lblCostoVentasResumen.TabIndex = 4;
        this.lblCostoVentasResumen.Text = "—";
        this.lblCostoVentasResumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloCostoVentas
        // 
        this.lblTituloCostoVentas.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblTituloCostoVentas.Location = new System.Drawing.Point(16, 70);
        this.lblTituloCostoVentas.Name = "lblTituloCostoVentas";
        this.lblTituloCostoVentas.Size = new System.Drawing.Size(190, 24);
        this.lblTituloCostoVentas.TabIndex = 3;
        this.lblTituloCostoVentas.Text = "Costo de ventas";
        this.lblTituloCostoVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblIngresosTotales
        // 
        this.lblIngresosTotales.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblIngresosTotales.Location = new System.Drawing.Point(206, 40);
        this.lblIngresosTotales.Name = "lblIngresosTotales";
        this.lblIngresosTotales.Size = new System.Drawing.Size(186, 24);
        this.lblIngresosTotales.TabIndex = 2;
        this.lblIngresosTotales.Text = "—";
        this.lblIngresosTotales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloIngresosTotales
        // 
        this.lblTituloIngresosTotales.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblTituloIngresosTotales.Location = new System.Drawing.Point(16, 40);
        this.lblTituloIngresosTotales.Name = "lblTituloIngresosTotales";
        this.lblTituloIngresosTotales.Size = new System.Drawing.Size(190, 24);
        this.lblTituloIngresosTotales.TabIndex = 1;
        this.lblTituloIngresosTotales.Text = "Ingresos totales";
        this.lblTituloIngresosTotales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblResumenEncabezado
        // 
        this.lblResumenEncabezado.AutoEllipsis = true;
        this.lblResumenEncabezado.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblResumenEncabezado.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        this.lblResumenEncabezado.Location = new System.Drawing.Point(16, 12);
        this.lblResumenEncabezado.Name = "lblResumenEncabezado";
        this.lblResumenEncabezado.Size = new System.Drawing.Size(376, 20);
        this.lblResumenEncabezado.TabIndex = 0;
        this.lblResumenEncabezado.Text = "Sin datos calculados";
        // 
        // EstadoResultadosForm
        // 
        this.AcceptButton = this.btnCalcular;
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.FromArgb(244, 246, 250);
        this.CancelButton = this.btnCerrar;
        this.ClientSize = new System.Drawing.Size(1040, 632);
        this.Controls.Add(this.grpResumen);
        this.Controls.Add(this.panelDatos);
        this.Controls.Add(this.panelEncabezado);
        this.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.MinimumSize = new System.Drawing.Size(1056, 671);
        this.Name = "EstadoResultadosForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Estado de Resultados - Finance Manager";
        this.panelEncabezado.ResumeLayout(false);
        this.panelEncabezado.PerformLayout();
        this.panelDatos.ResumeLayout(false);
        this.grpCostos.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.numOtrosGastos)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numDepreciacion)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numGastosVentas)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numGastosAdministracion)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numCostoVentas)).EndInit();
        this.grpIngresos.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.numOtrosIngresos)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numVentas)).EndInit();
        this.grpDatos.ResumeLayout(false);
        this.grpDatos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numTasa)).EndInit();
        this.grpResumen.ResumeLayout(false);
        this.cardUtilidad.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel panelEncabezado;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label lblSubtitulo;
    private System.Windows.Forms.Button btnCerrar;
    private System.Windows.Forms.Panel panelDatos;
    private System.Windows.Forms.GroupBox grpDatos;
    private System.Windows.Forms.Label lblEmpresa;
    private System.Windows.Forms.TextBox txtEmpresa;
    private System.Windows.Forms.Label lblPeriodo;
    private System.Windows.Forms.TextBox txtPeriodo;
    private System.Windows.Forms.Label lblTasa;
    private System.Windows.Forms.NumericUpDown numTasa;
    private System.Windows.Forms.Label lblTasaNota;
    private System.Windows.Forms.GroupBox grpIngresos;
    private System.Windows.Forms.Label lblVentas;
    private System.Windows.Forms.NumericUpDown numVentas;
    private System.Windows.Forms.Label lblOtrosIngresos;
    private System.Windows.Forms.NumericUpDown numOtrosIngresos;
    private System.Windows.Forms.GroupBox grpCostos;
    private System.Windows.Forms.Label lblCostoVentas;
    private System.Windows.Forms.NumericUpDown numCostoVentas;
    private System.Windows.Forms.Label lblGastosAdministracion;
    private System.Windows.Forms.NumericUpDown numGastosAdministracion;
    private System.Windows.Forms.Label lblGastosVentas;
    private System.Windows.Forms.NumericUpDown numGastosVentas;
    private System.Windows.Forms.Label lblDepreciacion;
    private System.Windows.Forms.NumericUpDown numDepreciacion;
    private System.Windows.Forms.Label lblOtrosGastos;
    private System.Windows.Forms.NumericUpDown numOtrosGastos;
    private System.Windows.Forms.Button btnCalcular;
    private System.Windows.Forms.Button btnLimpiar;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.GroupBox grpResumen;
    private System.Windows.Forms.Label lblResumenEncabezado;
    private System.Windows.Forms.Label lblTituloIngresosTotales;
    private System.Windows.Forms.Label lblIngresosTotales;
    private System.Windows.Forms.Label lblTituloCostoVentas;
    private System.Windows.Forms.Label lblCostoVentasResumen;
    private System.Windows.Forms.Label lblTituloUtilidadBruta;
    private System.Windows.Forms.Label lblUtilidadBruta;
    private System.Windows.Forms.Label lblTituloGastosOperativos;
    private System.Windows.Forms.Label lblGastosOperativos;
    private System.Windows.Forms.Label lblTituloUtilidadOperativa;
    private System.Windows.Forms.Label lblUtilidadOperativa;
    private System.Windows.Forms.Label lblTituloOtrosGastos;
    private System.Windows.Forms.Label lblOtrosGastosResumen;
    private System.Windows.Forms.Label lblTituloUtilidadAntes;
    private System.Windows.Forms.Label lblUtilidadAntes;
    private System.Windows.Forms.Label lblTituloImpuesto;
    private System.Windows.Forms.Label lblImpuesto;
    private System.Windows.Forms.Panel cardUtilidad;
    private System.Windows.Forms.Label lblEtiquetaUtilidadNeta;
    private System.Windows.Forms.Label lblUtilidadNeta;
    private System.Windows.Forms.Label lblMensaje;
    private System.Windows.Forms.Label lblNotaMoneda;
}
