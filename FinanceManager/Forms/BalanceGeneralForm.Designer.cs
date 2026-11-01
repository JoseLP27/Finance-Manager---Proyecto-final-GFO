#nullable disable

namespace FinanceManager.Forms;

partial class BalanceGeneralForm
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
        this.btnCerrar = new System.Windows.Forms.Button();
        this.lblSubtitulo = new System.Windows.Forms.Label();
        this.lblTitulo = new System.Windows.Forms.Label();
        this.grpDatos = new System.Windows.Forms.GroupBox();
        this.lblMoneda = new System.Windows.Forms.Label();
        this.dtpFechaCorte = new System.Windows.Forms.DateTimePicker();
        this.lblFechaCorte = new System.Windows.Forms.Label();
        this.txtEmpresa = new System.Windows.Forms.TextBox();
        this.lblEmpresa = new System.Windows.Forms.Label();
        this.tabDatos = new System.Windows.Forms.TabControl();
        this.tabActivos = new System.Windows.Forms.TabPage();
        this.grpActivosNoCorrientes = new System.Windows.Forms.GroupBox();
        this.numOtrosActivosNoCorrientes = new System.Windows.Forms.NumericUpDown();
        this.lblOtrosActivosNoCorrientes = new System.Windows.Forms.Label();
        this.numActivosIntangibles = new System.Windows.Forms.NumericUpDown();
        this.lblActivosIntangibles = new System.Windows.Forms.Label();
        this.numDepreciacionAcumulada = new System.Windows.Forms.NumericUpDown();
        this.lblDepreciacionAcumulada = new System.Windows.Forms.Label();
        this.numPropiedadPlantaEquipo = new System.Windows.Forms.NumericUpDown();
        this.lblPropiedadPlantaEquipo = new System.Windows.Forms.Label();
        this.grpActivosCorrientes = new System.Windows.Forms.GroupBox();
        this.numOtrosActivosCorrientes = new System.Windows.Forms.NumericUpDown();
        this.lblOtrosActivosCorrientes = new System.Windows.Forms.Label();
        this.numInventario = new System.Windows.Forms.NumericUpDown();
        this.lblInventario = new System.Windows.Forms.Label();
        this.numCuentasPorCobrar = new System.Windows.Forms.NumericUpDown();
        this.lblCuentasPorCobrar = new System.Windows.Forms.Label();
        this.numEfectivo = new System.Windows.Forms.NumericUpDown();
        this.lblEfectivo = new System.Windows.Forms.Label();
        this.tabPasivos = new System.Windows.Forms.TabPage();
        this.lblAyudaPasivos = new System.Windows.Forms.Label();
        this.grpPasivosNoCorrientes = new System.Windows.Forms.GroupBox();
        this.numOtrosPasivosNoCorrientes = new System.Windows.Forms.NumericUpDown();
        this.lblOtrosPasivosNoCorrientes = new System.Windows.Forms.Label();
        this.numPrestamosLargoPlazo = new System.Windows.Forms.NumericUpDown();
        this.lblPrestamosLargoPlazo = new System.Windows.Forms.Label();
        this.grpPasivosCorrientes = new System.Windows.Forms.GroupBox();
        this.numOtrosPasivosCorrientes = new System.Windows.Forms.NumericUpDown();
        this.lblOtrosPasivosCorrientes = new System.Windows.Forms.Label();
        this.numObligacionesCortoPlazo = new System.Windows.Forms.NumericUpDown();
        this.lblObligacionesCortoPlazo = new System.Windows.Forms.Label();
        this.numImpuestosPorPagar = new System.Windows.Forms.NumericUpDown();
        this.lblImpuestosPorPagar = new System.Windows.Forms.Label();
        this.numCuentasPorPagar = new System.Windows.Forms.NumericUpDown();
        this.lblCuentasPorPagar = new System.Windows.Forms.Label();
        this.tabPatrimonio = new System.Windows.Forms.TabPage();
        this.lblAyudaUtilidad = new System.Windows.Forms.Label();
        this.btnUsarUtilidad = new System.Windows.Forms.Button();
        this.grpPatrimonio = new System.Windows.Forms.GroupBox();
        this.numUtilidadEjercicio = new System.Windows.Forms.NumericUpDown();
        this.lblUtilidadEjercicio = new System.Windows.Forms.Label();
        this.numResultadosAcumulados = new System.Windows.Forms.NumericUpDown();
        this.lblResultadosAcumulados = new System.Windows.Forms.Label();
        this.numReservas = new System.Windows.Forms.NumericUpDown();
        this.lblReservas = new System.Windows.Forms.Label();
        this.numCapitalSocial = new System.Windows.Forms.NumericUpDown();
        this.lblCapitalSocial = new System.Windows.Forms.Label();
        this.btnGuardar = new System.Windows.Forms.Button();
        this.btnLimpiar = new System.Windows.Forms.Button();
        this.btnCalcular = new System.Windows.Forms.Button();
        this.grpResumen = new System.Windows.Forms.GroupBox();
        this.lblNotaBalance = new System.Windows.Forms.Label();
        this.panelEstado = new System.Windows.Forms.Panel();
        this.lblEstado = new System.Windows.Forms.Label();
        this.lblDiferencia = new System.Windows.Forms.Label();
        this.lblTituloDiferencia = new System.Windows.Forms.Label();
        this.lblTotalPasivoPatrimonio = new System.Windows.Forms.Label();
        this.lblTituloPasivoPatrimonio = new System.Windows.Forms.Label();
        this.lblPatrimonio = new System.Windows.Forms.Label();
        this.lblTituloPatrimonio = new System.Windows.Forms.Label();
        this.lblTotalPasivo = new System.Windows.Forms.Label();
        this.lblTituloTotalPasivo = new System.Windows.Forms.Label();
        this.lblPasivosNoCorrientes = new System.Windows.Forms.Label();
        this.lblTituloPasivosNoCorrientes = new System.Windows.Forms.Label();
        this.lblPasivosCorrientes = new System.Windows.Forms.Label();
        this.lblTituloPasivosCorrientes = new System.Windows.Forms.Label();
        this.lblTotalActivo = new System.Windows.Forms.Label();
        this.lblTituloTotalActivo = new System.Windows.Forms.Label();
        this.lblActivosNoCorrientes = new System.Windows.Forms.Label();
        this.lblTituloActivosNoCorrientes = new System.Windows.Forms.Label();
        this.lblActivosCorrientes = new System.Windows.Forms.Label();
        this.lblTituloActivosCorrientes = new System.Windows.Forms.Label();
        this.lblEncabezado = new System.Windows.Forms.Label();
        this.panelEncabezado.SuspendLayout();
        this.grpDatos.SuspendLayout();
        this.tabDatos.SuspendLayout();
        this.tabActivos.SuspendLayout();
        this.grpActivosNoCorrientes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numOtrosActivosNoCorrientes)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numActivosIntangibles)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numDepreciacionAcumulada)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numPropiedadPlantaEquipo)).BeginInit();
        this.grpActivosCorrientes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numOtrosActivosCorrientes)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numInventario)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numCuentasPorCobrar)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numEfectivo)).BeginInit();
        this.tabPasivos.SuspendLayout();
        this.grpPasivosNoCorrientes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numOtrosPasivosNoCorrientes)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numPrestamosLargoPlazo)).BeginInit();
        this.grpPasivosCorrientes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numOtrosPasivosCorrientes)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numObligacionesCortoPlazo)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numImpuestosPorPagar)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numCuentasPorPagar)).BeginInit();
        this.tabPatrimonio.SuspendLayout();
        this.grpPatrimonio.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numUtilidadEjercicio)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numResultadosAcumulados)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numReservas)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numCapitalSocial)).BeginInit();
        this.grpResumen.SuspendLayout();
        this.panelEstado.SuspendLayout();
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
        this.panelEncabezado.Size = new System.Drawing.Size(1080, 84);
        this.panelEncabezado.TabIndex = 0;
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
        this.btnCerrar.Location = new System.Drawing.Point(960, 24);
        this.btnCerrar.Name = "btnCerrar";
        this.btnCerrar.Size = new System.Drawing.Size(88, 34);
        this.btnCerrar.TabIndex = 2;
        this.btnCerrar.Text = "Cerrar";
        this.btnCerrar.UseVisualStyleBackColor = false;
        this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
        // 
        // lblSubtitulo
        // 
        this.lblSubtitulo.AutoSize = true;
        this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(201, 211, 230);
        this.lblSubtitulo.Location = new System.Drawing.Point(32, 48);
        this.lblSubtitulo.Name = "lblSubtitulo";
        this.lblSubtitulo.Size = new System.Drawing.Size(536, 17);
        this.lblSubtitulo.TabIndex = 1;
        this.lblSubtitulo.Text = "Registra activos, pasivos y patrimonio, y verifica la ecuación contable.";
        // 
        // lblTitulo
        // 
        this.lblTitulo.AutoSize = true;
        this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        this.lblTitulo.ForeColor = System.Drawing.Color.White;
        this.lblTitulo.Location = new System.Drawing.Point(30, 12);
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.Size = new System.Drawing.Size(200, 37);
        this.lblTitulo.TabIndex = 0;
        this.lblTitulo.Text = "Balance General";
        // 
        // grpDatos
        // 
        this.grpDatos.Controls.Add(this.lblMoneda);
        this.grpDatos.Controls.Add(this.dtpFechaCorte);
        this.grpDatos.Controls.Add(this.lblFechaCorte);
        this.grpDatos.Controls.Add(this.txtEmpresa);
        this.grpDatos.Controls.Add(this.lblEmpresa);
        this.grpDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right));
        this.grpDatos.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpDatos.Location = new System.Drawing.Point(24, 94);
        this.grpDatos.Name = "grpDatos";
        this.grpDatos.Size = new System.Drawing.Size(640, 88);
        this.grpDatos.TabIndex = 1;
        this.grpDatos.TabStop = false;
        this.grpDatos.Text = "Datos generales";
        // 
        // lblMoneda
        // 
        this.lblMoneda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lblMoneda.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblMoneda.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        this.lblMoneda.Location = new System.Drawing.Point(352, 54);
        this.lblMoneda.Name = "lblMoneda";
        this.lblMoneda.Size = new System.Drawing.Size(272, 23);
        this.lblMoneda.TabIndex = 4;
        this.lblMoneda.Text = "Moneda: córdobas (C$)";
        this.lblMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // dtpFechaCorte
        // 
        this.dtpFechaCorte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpFechaCorte.Location = new System.Drawing.Point(130, 50);
        this.dtpFechaCorte.Name = "dtpFechaCorte";
        this.dtpFechaCorte.Size = new System.Drawing.Size(200, 27);
        this.dtpFechaCorte.TabIndex = 3;
        // 
        // lblFechaCorte
        // 
        this.lblFechaCorte.Location = new System.Drawing.Point(16, 54);
        this.lblFechaCorte.Name = "lblFechaCorte";
        this.lblFechaCorte.Size = new System.Drawing.Size(110, 23);
        this.lblFechaCorte.TabIndex = 2;
        this.lblFechaCorte.Text = "Fecha de corte:";
        this.lblFechaCorte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtEmpresa
        // 
        this.txtEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right));
        this.txtEmpresa.Location = new System.Drawing.Point(104, 20);
        this.txtEmpresa.Name = "txtEmpresa";
        this.txtEmpresa.PlaceholderText = "Nombre de la empresa u organización";
        this.txtEmpresa.Size = new System.Drawing.Size(520, 27);
        this.txtEmpresa.TabIndex = 1;
        // 
        // lblEmpresa
        // 
        this.lblEmpresa.Location = new System.Drawing.Point(16, 24);
        this.lblEmpresa.Name = "lblEmpresa";
        this.lblEmpresa.Size = new System.Drawing.Size(80, 23);
        this.lblEmpresa.TabIndex = 0;
        this.lblEmpresa.Text = "Empresa:";
        this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tabDatos
        // 
        this.tabDatos.Controls.Add(this.tabActivos);
        this.tabDatos.Controls.Add(this.tabPasivos);
        this.tabDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.tabDatos.Controls.Add(this.tabPatrimonio);
        this.tabDatos.Location = new System.Drawing.Point(24, 190);
        this.tabDatos.Name = "tabDatos";
        this.tabDatos.Size = new System.Drawing.Size(640, 360);
        this.tabDatos.TabIndex = 2;
        // 
        // tabActivos
        // 
        this.tabActivos.Controls.Add(this.grpActivosNoCorrientes);
        this.tabActivos.Controls.Add(this.grpActivosCorrientes);
        this.tabActivos.Location = new System.Drawing.Point(4, 26);
        this.tabActivos.Name = "tabActivos";
        this.tabActivos.Padding = new System.Windows.Forms.Padding(3);
        this.tabActivos.Size = new System.Drawing.Size(632, 330);
        this.tabActivos.TabIndex = 0;
        this.tabActivos.Text = "Activos";
        this.tabActivos.UseVisualStyleBackColor = true;
        // 
        // grpActivosNoCorrientes
        // 
        this.grpActivosNoCorrientes.Controls.Add(this.numOtrosActivosNoCorrientes);
        this.grpActivosNoCorrientes.Controls.Add(this.lblOtrosActivosNoCorrientes);
        this.grpActivosNoCorrientes.Controls.Add(this.numActivosIntangibles);
        this.grpActivosNoCorrientes.Controls.Add(this.lblActivosIntangibles);
        this.grpActivosNoCorrientes.Controls.Add(this.numDepreciacionAcumulada);
        this.grpActivosNoCorrientes.Controls.Add(this.lblDepreciacionAcumulada);
        this.grpActivosNoCorrientes.Controls.Add(this.numPropiedadPlantaEquipo);
        this.grpActivosNoCorrientes.Controls.Add(this.lblPropiedadPlantaEquipo);
        this.grpActivosNoCorrientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right));
        this.grpActivosNoCorrientes.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpActivosNoCorrientes.Location = new System.Drawing.Point(12, 172);
        this.grpActivosNoCorrientes.Name = "grpActivosNoCorrientes";
        this.grpActivosNoCorrientes.Size = new System.Drawing.Size(604, 150);
        this.grpActivosNoCorrientes.TabIndex = 1;
        this.grpActivosNoCorrientes.TabStop = false;
        this.grpActivosNoCorrientes.Text = "Activos no corrientes";
        // 
        // numOtrosActivosNoCorrientes
        // 
        this.numOtrosActivosNoCorrientes.DecimalPlaces = 2;
        this.numOtrosActivosNoCorrientes.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numOtrosActivosNoCorrientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numOtrosActivosNoCorrientes.Location = new System.Drawing.Point(328, 114);
        this.numOtrosActivosNoCorrientes.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numOtrosActivosNoCorrientes.Name = "numOtrosActivosNoCorrientes";
        this.numOtrosActivosNoCorrientes.Size = new System.Drawing.Size(260, 25);
        this.numOtrosActivosNoCorrientes.TabIndex = 7;
        this.numOtrosActivosNoCorrientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numOtrosActivosNoCorrientes.ThousandsSeparator = true;
        // 
        // lblOtrosActivosNoCorrientes
        // 
        this.lblOtrosActivosNoCorrientes.Location = new System.Drawing.Point(16, 118);
        this.lblOtrosActivosNoCorrientes.Name = "lblOtrosActivosNoCorrientes";
        this.lblOtrosActivosNoCorrientes.Size = new System.Drawing.Size(300, 23);
        this.lblOtrosActivosNoCorrientes.TabIndex = 6;
        this.lblOtrosActivosNoCorrientes.Text = "Otros activos no corrientes:";
        this.lblOtrosActivosNoCorrientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numActivosIntangibles
        // 
        this.numActivosIntangibles.DecimalPlaces = 2;
        this.numActivosIntangibles.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numActivosIntangibles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numActivosIntangibles.Location = new System.Drawing.Point(328, 84);
        this.numActivosIntangibles.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numActivosIntangibles.Name = "numActivosIntangibles";
        this.numActivosIntangibles.Size = new System.Drawing.Size(260, 25);
        this.numActivosIntangibles.TabIndex = 5;
        this.numActivosIntangibles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numActivosIntangibles.ThousandsSeparator = true;
        // 
        // lblActivosIntangibles
        // 
        this.lblActivosIntangibles.Location = new System.Drawing.Point(16, 88);
        this.lblActivosIntangibles.Name = "lblActivosIntangibles";
        this.lblActivosIntangibles.Size = new System.Drawing.Size(300, 23);
        this.lblActivosIntangibles.TabIndex = 4;
        this.lblActivosIntangibles.Text = "Activos intangibles:";
        this.lblActivosIntangibles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numDepreciacionAcumulada
        // 
        this.numDepreciacionAcumulada.DecimalPlaces = 2;
        this.numDepreciacionAcumulada.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numDepreciacionAcumulada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numDepreciacionAcumulada.Location = new System.Drawing.Point(328, 54);
        this.numDepreciacionAcumulada.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numDepreciacionAcumulada.Name = "numDepreciacionAcumulada";
        this.numDepreciacionAcumulada.Size = new System.Drawing.Size(260, 25);
        this.numDepreciacionAcumulada.TabIndex = 3;
        this.numDepreciacionAcumulada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numDepreciacionAcumulada.ThousandsSeparator = true;
        // 
        // lblDepreciacionAcumulada
        // 
        this.lblDepreciacionAcumulada.Location = new System.Drawing.Point(16, 58);
        this.lblDepreciacionAcumulada.Name = "lblDepreciacionAcumulada";
        this.lblDepreciacionAcumulada.Size = new System.Drawing.Size(300, 23);
        this.lblDepreciacionAcumulada.TabIndex = 2;
        this.lblDepreciacionAcumulada.Text = "Depreciación acumulada (-):";
        this.lblDepreciacionAcumulada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numPropiedadPlantaEquipo
        // 
        this.numPropiedadPlantaEquipo.DecimalPlaces = 2;
        this.numPropiedadPlantaEquipo.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numPropiedadPlantaEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numPropiedadPlantaEquipo.Location = new System.Drawing.Point(328, 24);
        this.numPropiedadPlantaEquipo.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numPropiedadPlantaEquipo.Name = "numPropiedadPlantaEquipo";
        this.numPropiedadPlantaEquipo.Size = new System.Drawing.Size(260, 25);
        this.numPropiedadPlantaEquipo.TabIndex = 1;
        this.numPropiedadPlantaEquipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numPropiedadPlantaEquipo.ThousandsSeparator = true;
        // 
        // lblPropiedadPlantaEquipo
        // 
        this.lblPropiedadPlantaEquipo.Location = new System.Drawing.Point(16, 28);
        this.lblPropiedadPlantaEquipo.Name = "lblPropiedadPlantaEquipo";
        this.lblPropiedadPlantaEquipo.Size = new System.Drawing.Size(300, 23);
        this.lblPropiedadPlantaEquipo.TabIndex = 0;
        this.lblPropiedadPlantaEquipo.Text = "Propiedad, planta y equipo:";
        this.lblPropiedadPlantaEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // grpActivosCorrientes
        // 
        this.grpActivosCorrientes.Controls.Add(this.numOtrosActivosCorrientes);
        this.grpActivosCorrientes.Controls.Add(this.lblOtrosActivosCorrientes);
        this.grpActivosCorrientes.Controls.Add(this.numInventario);
        this.grpActivosCorrientes.Controls.Add(this.lblInventario);
        this.grpActivosCorrientes.Controls.Add(this.numCuentasPorCobrar);
        this.grpActivosCorrientes.Controls.Add(this.lblCuentasPorCobrar);
        this.grpActivosCorrientes.Controls.Add(this.numEfectivo);
        this.grpActivosCorrientes.Controls.Add(this.lblEfectivo);
        this.grpActivosCorrientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right));
        this.grpActivosCorrientes.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpActivosCorrientes.Location = new System.Drawing.Point(12, 12);
        this.grpActivosCorrientes.Name = "grpActivosCorrientes";
        this.grpActivosCorrientes.Size = new System.Drawing.Size(604, 150);
        this.grpActivosCorrientes.TabIndex = 0;
        this.grpActivosCorrientes.TabStop = false;
        this.grpActivosCorrientes.Text = "Activos corrientes";
        // 
        // numOtrosActivosCorrientes
        // 
        this.numOtrosActivosCorrientes.DecimalPlaces = 2;
        this.numOtrosActivosCorrientes.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numOtrosActivosCorrientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numOtrosActivosCorrientes.Location = new System.Drawing.Point(328, 114);
        this.numOtrosActivosCorrientes.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numOtrosActivosCorrientes.Name = "numOtrosActivosCorrientes";
        this.numOtrosActivosCorrientes.Size = new System.Drawing.Size(260, 25);
        this.numOtrosActivosCorrientes.TabIndex = 7;
        this.numOtrosActivosCorrientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numOtrosActivosCorrientes.ThousandsSeparator = true;
        // 
        // lblOtrosActivosCorrientes
        // 
        this.lblOtrosActivosCorrientes.Location = new System.Drawing.Point(16, 118);
        this.lblOtrosActivosCorrientes.Name = "lblOtrosActivosCorrientes";
        this.lblOtrosActivosCorrientes.Size = new System.Drawing.Size(300, 23);
        this.lblOtrosActivosCorrientes.TabIndex = 6;
        this.lblOtrosActivosCorrientes.Text = "Otros activos corrientes:";
        this.lblOtrosActivosCorrientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numInventario
        // 
        this.numInventario.DecimalPlaces = 2;
        this.numInventario.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numInventario.Location = new System.Drawing.Point(328, 84);
        this.numInventario.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numInventario.Name = "numInventario";
        this.numInventario.Size = new System.Drawing.Size(260, 25);
        this.numInventario.TabIndex = 5;
        this.numInventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numInventario.ThousandsSeparator = true;
        // 
        // lblInventario
        // 
        this.lblInventario.Location = new System.Drawing.Point(16, 88);
        this.lblInventario.Name = "lblInventario";
        this.lblInventario.Size = new System.Drawing.Size(300, 23);
        this.lblInventario.TabIndex = 4;
        this.lblInventario.Text = "Inventario:";
        this.lblInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numCuentasPorCobrar
        // 
        this.numCuentasPorCobrar.DecimalPlaces = 2;
        this.numCuentasPorCobrar.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numCuentasPorCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numCuentasPorCobrar.Location = new System.Drawing.Point(328, 54);
        this.numCuentasPorCobrar.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numCuentasPorCobrar.Name = "numCuentasPorCobrar";
        this.numCuentasPorCobrar.Size = new System.Drawing.Size(260, 25);
        this.numCuentasPorCobrar.TabIndex = 3;
        this.numCuentasPorCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numCuentasPorCobrar.ThousandsSeparator = true;
        // 
        // lblCuentasPorCobrar
        // 
        this.lblCuentasPorCobrar.Location = new System.Drawing.Point(16, 58);
        this.lblCuentasPorCobrar.Name = "lblCuentasPorCobrar";
        this.lblCuentasPorCobrar.Size = new System.Drawing.Size(300, 23);
        this.lblCuentasPorCobrar.TabIndex = 2;
        this.lblCuentasPorCobrar.Text = "Cuentas por cobrar:";
        this.lblCuentasPorCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numEfectivo
        // 
        this.numEfectivo.DecimalPlaces = 2;
        this.numEfectivo.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numEfectivo.Location = new System.Drawing.Point(328, 24);
        this.numEfectivo.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numEfectivo.Name = "numEfectivo";
        this.numEfectivo.Size = new System.Drawing.Size(260, 25);
        this.numEfectivo.TabIndex = 1;
        this.numEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numEfectivo.ThousandsSeparator = true;
        // 
        // lblEfectivo
        // 
        this.lblEfectivo.Location = new System.Drawing.Point(16, 28);
        this.lblEfectivo.Name = "lblEfectivo";
        this.lblEfectivo.Size = new System.Drawing.Size(300, 23);
        this.lblEfectivo.TabIndex = 0;
        this.lblEfectivo.Text = "Efectivo y equivalentes:";
        this.lblEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tabPasivos
        // 
        this.tabPasivos.Controls.Add(this.lblAyudaPasivos);
        this.tabPasivos.Controls.Add(this.grpPasivosNoCorrientes);
        this.tabPasivos.Controls.Add(this.grpPasivosCorrientes);
        this.tabPasivos.Location = new System.Drawing.Point(4, 26);
        this.tabPasivos.Name = "tabPasivos";
        this.tabPasivos.Padding = new System.Windows.Forms.Padding(3);
        this.tabPasivos.Size = new System.Drawing.Size(632, 330);
        this.tabPasivos.TabIndex = 1;
        this.tabPasivos.Text = "Pasivos";
        this.tabPasivos.UseVisualStyleBackColor = true;
        // 
        // lblAyudaPasivos
        // 
        this.lblAyudaPasivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right));
        this.lblAyudaPasivos.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblAyudaPasivos.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        this.lblAyudaPasivos.Location = new System.Drawing.Point(12, 282);
        this.lblAyudaPasivos.Name = "lblAyudaPasivos";
        this.lblAyudaPasivos.Size = new System.Drawing.Size(604, 38);
        this.lblAyudaPasivos.TabIndex = 2;
        this.lblAyudaPasivos.Text = "Los pasivos no corrientes son obligaciones con vencimiento mayor a un año.";
        // 
        // grpPasivosNoCorrientes
        // 
        this.grpPasivosNoCorrientes.Controls.Add(this.numOtrosPasivosNoCorrientes);
        this.grpPasivosNoCorrientes.Controls.Add(this.lblOtrosPasivosNoCorrientes);
        this.grpPasivosNoCorrientes.Controls.Add(this.numPrestamosLargoPlazo);
        this.grpPasivosNoCorrientes.Controls.Add(this.lblPrestamosLargoPlazo);
        this.grpPasivosNoCorrientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right));
        this.grpPasivosNoCorrientes.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpPasivosNoCorrientes.Location = new System.Drawing.Point(12, 172);
        this.grpPasivosNoCorrientes.Name = "grpPasivosNoCorrientes";
        this.grpPasivosNoCorrientes.Size = new System.Drawing.Size(604, 100);
        this.grpPasivosNoCorrientes.TabIndex = 1;
        this.grpPasivosNoCorrientes.TabStop = false;
        this.grpPasivosNoCorrientes.Text = "Pasivos no corrientes";
        // 
        // numOtrosPasivosNoCorrientes
        // 
        this.numOtrosPasivosNoCorrientes.DecimalPlaces = 2;
        this.numOtrosPasivosNoCorrientes.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numOtrosPasivosNoCorrientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numOtrosPasivosNoCorrientes.Location = new System.Drawing.Point(328, 64);
        this.numOtrosPasivosNoCorrientes.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numOtrosPasivosNoCorrientes.Name = "numOtrosPasivosNoCorrientes";
        this.numOtrosPasivosNoCorrientes.Size = new System.Drawing.Size(260, 25);
        this.numOtrosPasivosNoCorrientes.TabIndex = 3;
        this.numOtrosPasivosNoCorrientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numOtrosPasivosNoCorrientes.ThousandsSeparator = true;
        // 
        // lblOtrosPasivosNoCorrientes
        // 
        this.lblOtrosPasivosNoCorrientes.Location = new System.Drawing.Point(16, 68);
        this.lblOtrosPasivosNoCorrientes.Name = "lblOtrosPasivosNoCorrientes";
        this.lblOtrosPasivosNoCorrientes.Size = new System.Drawing.Size(300, 23);
        this.lblOtrosPasivosNoCorrientes.TabIndex = 2;
        this.lblOtrosPasivosNoCorrientes.Text = "Otros pasivos no corrientes:";
        this.lblOtrosPasivosNoCorrientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numPrestamosLargoPlazo
        // 
        this.numPrestamosLargoPlazo.DecimalPlaces = 2;
        this.numPrestamosLargoPlazo.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numPrestamosLargoPlazo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numPrestamosLargoPlazo.Location = new System.Drawing.Point(328, 34);
        this.numPrestamosLargoPlazo.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numPrestamosLargoPlazo.Name = "numPrestamosLargoPlazo";
        this.numPrestamosLargoPlazo.Size = new System.Drawing.Size(260, 25);
        this.numPrestamosLargoPlazo.TabIndex = 1;
        this.numPrestamosLargoPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numPrestamosLargoPlazo.ThousandsSeparator = true;
        // 
        // lblPrestamosLargoPlazo
        // 
        this.lblPrestamosLargoPlazo.Location = new System.Drawing.Point(16, 38);
        this.lblPrestamosLargoPlazo.Name = "lblPrestamosLargoPlazo";
        this.lblPrestamosLargoPlazo.Size = new System.Drawing.Size(300, 23);
        this.lblPrestamosLargoPlazo.TabIndex = 0;
        this.lblPrestamosLargoPlazo.Text = "Préstamos a largo plazo:";
        this.lblPrestamosLargoPlazo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // grpPasivosCorrientes
        // 
        this.grpPasivosCorrientes.Controls.Add(this.numOtrosPasivosCorrientes);
        this.grpPasivosCorrientes.Controls.Add(this.lblOtrosPasivosCorrientes);
        this.grpPasivosCorrientes.Controls.Add(this.numObligacionesCortoPlazo);
        this.grpPasivosCorrientes.Controls.Add(this.lblObligacionesCortoPlazo);
        this.grpPasivosCorrientes.Controls.Add(this.numImpuestosPorPagar);
        this.grpPasivosCorrientes.Controls.Add(this.lblImpuestosPorPagar);
        this.grpPasivosCorrientes.Controls.Add(this.numCuentasPorPagar);
        this.grpPasivosCorrientes.Controls.Add(this.lblCuentasPorPagar);
        this.grpPasivosCorrientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right));
        this.grpPasivosCorrientes.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpPasivosCorrientes.Location = new System.Drawing.Point(12, 12);
        this.grpPasivosCorrientes.Name = "grpPasivosCorrientes";
        this.grpPasivosCorrientes.Size = new System.Drawing.Size(604, 150);
        this.grpPasivosCorrientes.TabIndex = 0;
        this.grpPasivosCorrientes.TabStop = false;
        this.grpPasivosCorrientes.Text = "Pasivos corrientes";
        // 
        // numOtrosPasivosCorrientes
        // 
        this.numOtrosPasivosCorrientes.DecimalPlaces = 2;
        this.numOtrosPasivosCorrientes.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numOtrosPasivosCorrientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numOtrosPasivosCorrientes.Location = new System.Drawing.Point(328, 114);
        this.numOtrosPasivosCorrientes.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numOtrosPasivosCorrientes.Name = "numOtrosPasivosCorrientes";
        this.numOtrosPasivosCorrientes.Size = new System.Drawing.Size(260, 25);
        this.numOtrosPasivosCorrientes.TabIndex = 7;
        this.numOtrosPasivosCorrientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numOtrosPasivosCorrientes.ThousandsSeparator = true;
        // 
        // lblOtrosPasivosCorrientes
        // 
        this.lblOtrosPasivosCorrientes.Location = new System.Drawing.Point(16, 118);
        this.lblOtrosPasivosCorrientes.Name = "lblOtrosPasivosCorrientes";
        this.lblOtrosPasivosCorrientes.Size = new System.Drawing.Size(300, 23);
        this.lblOtrosPasivosCorrientes.TabIndex = 6;
        this.lblOtrosPasivosCorrientes.Text = "Otros pasivos corrientes:";
        this.lblOtrosPasivosCorrientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numObligacionesCortoPlazo
        // 
        this.numObligacionesCortoPlazo.DecimalPlaces = 2;
        this.numObligacionesCortoPlazo.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numObligacionesCortoPlazo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numObligacionesCortoPlazo.Location = new System.Drawing.Point(328, 84);
        this.numObligacionesCortoPlazo.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numObligacionesCortoPlazo.Name = "numObligacionesCortoPlazo";
        this.numObligacionesCortoPlazo.Size = new System.Drawing.Size(260, 25);
        this.numObligacionesCortoPlazo.TabIndex = 5;
        this.numObligacionesCortoPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numObligacionesCortoPlazo.ThousandsSeparator = true;
        // 
        // lblObligacionesCortoPlazo
        // 
        this.lblObligacionesCortoPlazo.Location = new System.Drawing.Point(16, 88);
        this.lblObligacionesCortoPlazo.Name = "lblObligacionesCortoPlazo";
        this.lblObligacionesCortoPlazo.Size = new System.Drawing.Size(300, 23);
        this.lblObligacionesCortoPlazo.TabIndex = 4;
        this.lblObligacionesCortoPlazo.Text = "Obligaciones a corto plazo:";
        this.lblObligacionesCortoPlazo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numImpuestosPorPagar
        // 
        this.numImpuestosPorPagar.DecimalPlaces = 2;
        this.numImpuestosPorPagar.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numImpuestosPorPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numImpuestosPorPagar.Location = new System.Drawing.Point(328, 54);
        this.numImpuestosPorPagar.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numImpuestosPorPagar.Name = "numImpuestosPorPagar";
        this.numImpuestosPorPagar.Size = new System.Drawing.Size(260, 25);
        this.numImpuestosPorPagar.TabIndex = 3;
        this.numImpuestosPorPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numImpuestosPorPagar.ThousandsSeparator = true;
        // 
        // lblImpuestosPorPagar
        // 
        this.lblImpuestosPorPagar.Location = new System.Drawing.Point(16, 58);
        this.lblImpuestosPorPagar.Name = "lblImpuestosPorPagar";
        this.lblImpuestosPorPagar.Size = new System.Drawing.Size(300, 23);
        this.lblImpuestosPorPagar.TabIndex = 2;
        this.lblImpuestosPorPagar.Text = "Impuestos por pagar:";
        this.lblImpuestosPorPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numCuentasPorPagar
        // 
        this.numCuentasPorPagar.DecimalPlaces = 2;
        this.numCuentasPorPagar.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numCuentasPorPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numCuentasPorPagar.Location = new System.Drawing.Point(328, 24);
        this.numCuentasPorPagar.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numCuentasPorPagar.Name = "numCuentasPorPagar";
        this.numCuentasPorPagar.Size = new System.Drawing.Size(260, 25);
        this.numCuentasPorPagar.TabIndex = 1;
        this.numCuentasPorPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numCuentasPorPagar.ThousandsSeparator = true;
        // 
        // lblCuentasPorPagar
        // 
        this.lblCuentasPorPagar.Location = new System.Drawing.Point(16, 28);
        this.lblCuentasPorPagar.Name = "lblCuentasPorPagar";
        this.lblCuentasPorPagar.Size = new System.Drawing.Size(300, 23);
        this.lblCuentasPorPagar.TabIndex = 0;
        this.lblCuentasPorPagar.Text = "Cuentas por pagar:";
        this.lblCuentasPorPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tabPatrimonio
        // 
        this.tabPatrimonio.Controls.Add(this.lblAyudaUtilidad);
        this.tabPatrimonio.Controls.Add(this.btnUsarUtilidad);
        this.tabPatrimonio.Controls.Add(this.grpPatrimonio);
        this.tabPatrimonio.Location = new System.Drawing.Point(4, 26);
        this.tabPatrimonio.Name = "tabPatrimonio";
        this.tabPatrimonio.Padding = new System.Windows.Forms.Padding(3);
        this.tabPatrimonio.Size = new System.Drawing.Size(632, 330);
        this.tabPatrimonio.TabIndex = 2;
        this.tabPatrimonio.Text = "Patrimonio";
        this.tabPatrimonio.UseVisualStyleBackColor = true;
        // 
        // lblAyudaUtilidad
        // 
        this.lblAyudaUtilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right));
        this.lblAyudaUtilidad.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblAyudaUtilidad.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        this.lblAyudaUtilidad.Location = new System.Drawing.Point(12, 212);
        this.lblAyudaUtilidad.Name = "lblAyudaUtilidad";
        this.lblAyudaUtilidad.Size = new System.Drawing.Size(604, 44);
        this.lblAyudaUtilidad.TabIndex = 2;
        this.lblAyudaUtilidad.Text = "Si ya calculaste un estado de resultados, puedes trasladar automáticamente su utilidad neta al patrimonio.";
        // 
        // btnUsarUtilidad
        // 
        this.btnUsarUtilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
        this.btnUsarUtilidad.BackColor = System.Drawing.Color.White;
        this.btnUsarUtilidad.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnUsarUtilidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
        this.btnUsarUtilidad.FlatAppearance.BorderSize = 1;
        this.btnUsarUtilidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        this.btnUsarUtilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnUsarUtilidad.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnUsarUtilidad.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.btnUsarUtilidad.Location = new System.Drawing.Point(12, 170);
        this.btnUsarUtilidad.Name = "btnUsarUtilidad";
        this.btnUsarUtilidad.Size = new System.Drawing.Size(330, 36);
        this.btnUsarUtilidad.TabIndex = 1;
        this.btnUsarUtilidad.Text = "Usar utilidad del estado de resultados";
        this.btnUsarUtilidad.UseVisualStyleBackColor = false;
        this.btnUsarUtilidad.Click += new System.EventHandler(this.btnUsarUtilidad_Click);
        // 
        // grpPatrimonio
        // 
        this.grpPatrimonio.Controls.Add(this.numUtilidadEjercicio);
        this.grpPatrimonio.Controls.Add(this.lblUtilidadEjercicio);
        this.grpPatrimonio.Controls.Add(this.numResultadosAcumulados);
        this.grpPatrimonio.Controls.Add(this.lblResultadosAcumulados);
        this.grpPatrimonio.Controls.Add(this.numReservas);
        this.grpPatrimonio.Controls.Add(this.lblReservas);
        this.grpPatrimonio.Controls.Add(this.numCapitalSocial);
        this.grpPatrimonio.Controls.Add(this.lblCapitalSocial);
        this.grpPatrimonio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right));
        this.grpPatrimonio.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpPatrimonio.Location = new System.Drawing.Point(12, 12);
        this.grpPatrimonio.Name = "grpPatrimonio";
        this.grpPatrimonio.Size = new System.Drawing.Size(604, 150);
        this.grpPatrimonio.TabIndex = 0;
        this.grpPatrimonio.TabStop = false;
        this.grpPatrimonio.Text = "Patrimonio";
        // 
        // numUtilidadEjercicio
        // 
        this.numUtilidadEjercicio.DecimalPlaces = 2;
        this.numUtilidadEjercicio.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numUtilidadEjercicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numUtilidadEjercicio.Location = new System.Drawing.Point(328, 114);
        this.numUtilidadEjercicio.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numUtilidadEjercicio.Minimum = new decimal(new int[] { 999999999, 0, 0, -2147483648 });
        this.numUtilidadEjercicio.Name = "numUtilidadEjercicio";
        this.numUtilidadEjercicio.Size = new System.Drawing.Size(260, 25);
        this.numUtilidadEjercicio.TabIndex = 7;
        this.numUtilidadEjercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numUtilidadEjercicio.ThousandsSeparator = true;
        // 
        // lblUtilidadEjercicio
        // 
        this.lblUtilidadEjercicio.Location = new System.Drawing.Point(16, 118);
        this.lblUtilidadEjercicio.Name = "lblUtilidadEjercicio";
        this.lblUtilidadEjercicio.Size = new System.Drawing.Size(300, 23);
        this.lblUtilidadEjercicio.TabIndex = 6;
        this.lblUtilidadEjercicio.Text = "Utilidad del ejercicio:";
        this.lblUtilidadEjercicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numResultadosAcumulados
        // 
        this.numResultadosAcumulados.DecimalPlaces = 2;
        this.numResultadosAcumulados.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numResultadosAcumulados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numResultadosAcumulados.Location = new System.Drawing.Point(328, 84);
        this.numResultadosAcumulados.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numResultadosAcumulados.Minimum = new decimal(new int[] { 999999999, 0, 0, -2147483648 });
        this.numResultadosAcumulados.Name = "numResultadosAcumulados";
        this.numResultadosAcumulados.Size = new System.Drawing.Size(260, 25);
        this.numResultadosAcumulados.TabIndex = 5;
        this.numResultadosAcumulados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numResultadosAcumulados.ThousandsSeparator = true;
        // 
        // lblResultadosAcumulados
        // 
        this.lblResultadosAcumulados.Location = new System.Drawing.Point(16, 88);
        this.lblResultadosAcumulados.Name = "lblResultadosAcumulados";
        this.lblResultadosAcumulados.Size = new System.Drawing.Size(300, 23);
        this.lblResultadosAcumulados.TabIndex = 4;
        this.lblResultadosAcumulados.Text = "Resultados acumulados:";
        this.lblResultadosAcumulados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numReservas
        // 
        this.numReservas.DecimalPlaces = 2;
        this.numReservas.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numReservas.Location = new System.Drawing.Point(328, 54);
        this.numReservas.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numReservas.Name = "numReservas";
        this.numReservas.Size = new System.Drawing.Size(260, 25);
        this.numReservas.TabIndex = 3;
        this.numReservas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numReservas.ThousandsSeparator = true;
        // 
        // lblReservas
        // 
        this.lblReservas.Location = new System.Drawing.Point(16, 58);
        this.lblReservas.Name = "lblReservas";
        this.lblReservas.Size = new System.Drawing.Size(300, 23);
        this.lblReservas.TabIndex = 2;
        this.lblReservas.Text = "Reservas:";
        this.lblReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numCapitalSocial
        // 
        this.numCapitalSocial.DecimalPlaces = 2;
        this.numCapitalSocial.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        this.numCapitalSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.numCapitalSocial.Location = new System.Drawing.Point(328, 24);
        this.numCapitalSocial.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        this.numCapitalSocial.Name = "numCapitalSocial";
        this.numCapitalSocial.Size = new System.Drawing.Size(260, 25);
        this.numCapitalSocial.TabIndex = 1;
        this.numCapitalSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.numCapitalSocial.ThousandsSeparator = true;
        // 
        // lblCapitalSocial
        // 
        this.lblCapitalSocial.Location = new System.Drawing.Point(16, 28);
        this.lblCapitalSocial.Name = "lblCapitalSocial";
        this.lblCapitalSocial.Size = new System.Drawing.Size(300, 23);
        this.lblCapitalSocial.TabIndex = 0;
        this.lblCapitalSocial.Text = "Capital social:";
        this.lblCapitalSocial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btnGuardar
        // 
        this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.btnGuardar.BackColor = System.Drawing.Color.White;
        this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
        this.btnGuardar.FlatAppearance.BorderSize = 1;
        this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.btnGuardar.Location = new System.Drawing.Point(416, 562);
        this.btnGuardar.Name = "btnGuardar";
        this.btnGuardar.Size = new System.Drawing.Size(248, 42);
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
        this.btnLimpiar.Location = new System.Drawing.Point(260, 562);
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
        this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(15, 118, 110);
        this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnCalcular.FlatAppearance.BorderSize = 0;
        this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(13, 100, 94);
        this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnCalcular.ForeColor = System.Drawing.Color.White;
        this.btnCalcular.Location = new System.Drawing.Point(24, 562);
        this.btnCalcular.Name = "btnCalcular";
        this.btnCalcular.Size = new System.Drawing.Size(220, 42);
        this.btnCalcular.TabIndex = 3;
        this.btnCalcular.Text = "Calcular balance";
        this.btnCalcular.UseVisualStyleBackColor = false;
        this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
        // 
        // grpResumen
        // 
        this.grpResumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.grpResumen.BackColor = System.Drawing.Color.White;
        this.grpResumen.Controls.Add(this.lblNotaBalance);
        this.grpResumen.Controls.Add(this.panelEstado);
        this.grpResumen.Controls.Add(this.lblTotalPasivoPatrimonio);
        this.grpResumen.Controls.Add(this.lblTituloPasivoPatrimonio);
        this.grpResumen.Controls.Add(this.lblPatrimonio);
        this.grpResumen.Controls.Add(this.lblTituloPatrimonio);
        this.grpResumen.Controls.Add(this.lblTotalPasivo);
        this.grpResumen.Controls.Add(this.lblTituloTotalPasivo);
        this.grpResumen.Controls.Add(this.lblPasivosNoCorrientes);
        this.grpResumen.Controls.Add(this.lblTituloPasivosNoCorrientes);
        this.grpResumen.Controls.Add(this.lblPasivosCorrientes);
        this.grpResumen.Controls.Add(this.lblTituloPasivosCorrientes);
        this.grpResumen.Controls.Add(this.lblTotalActivo);
        this.grpResumen.Controls.Add(this.lblTituloTotalActivo);
        this.grpResumen.Controls.Add(this.lblActivosNoCorrientes);
        this.grpResumen.Controls.Add(this.lblTituloActivosNoCorrientes);
        this.grpResumen.Controls.Add(this.lblActivosCorrientes);
        this.grpResumen.Controls.Add(this.lblTituloActivosCorrientes);
        this.grpResumen.Controls.Add(this.lblEncabezado);
        this.grpResumen.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpResumen.Location = new System.Drawing.Point(688, 94);
        this.grpResumen.Name = "grpResumen";
        this.grpResumen.Size = new System.Drawing.Size(368, 510);
        this.grpResumen.TabIndex = 6;
        this.grpResumen.TabStop = false;
        this.grpResumen.Text = "Resumen del balance";
        // 
        // lblNotaBalance
        // 
        this.lblNotaBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.lblNotaBalance.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblNotaBalance.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        this.lblNotaBalance.Location = new System.Drawing.Point(16, 428);
        this.lblNotaBalance.Name = "lblNotaBalance";
        this.lblNotaBalance.Size = new System.Drawing.Size(336, 58);
        this.lblNotaBalance.TabIndex = 18;
        this.lblNotaBalance.Text = "Ecuación contable: Activo = Pasivo + Patrimonio.\r\nExpresado en córdobas (C$).";
        // 
        // panelEstado
        // 
        this.panelEstado.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.panelEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panelEstado.Controls.Add(this.lblEstado);
        this.panelEstado.Controls.Add(this.lblDiferencia);
        this.panelEstado.Controls.Add(this.lblTituloDiferencia);
        this.panelEstado.Location = new System.Drawing.Point(16, 288);
        this.panelEstado.Name = "panelEstado";
        this.panelEstado.Size = new System.Drawing.Size(336, 122);
        this.panelEstado.TabIndex = 17;
        // 
        // lblEstado
        // 
        this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        this.lblEstado.Location = new System.Drawing.Point(12, 68);
        this.lblEstado.Name = "lblEstado";
        this.lblEstado.Size = new System.Drawing.Size(310, 44);
        this.lblEstado.TabIndex = 2;
        this.lblEstado.Text = "Completa los montos y presiona Calcular para verificar la ecuación contable.";
        // 
        // lblDiferencia
        // 
        this.lblDiferencia.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblDiferencia.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        this.lblDiferencia.Location = new System.Drawing.Point(12, 30);
        this.lblDiferencia.Name = "lblDiferencia";
        this.lblDiferencia.Size = new System.Drawing.Size(310, 32);
        this.lblDiferencia.TabIndex = 1;
        this.lblDiferencia.Text = "—";
        this.lblDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloDiferencia
        // 
        this.lblTituloDiferencia.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblTituloDiferencia.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        this.lblTituloDiferencia.Location = new System.Drawing.Point(12, 10);
        this.lblTituloDiferencia.Name = "lblTituloDiferencia";
        this.lblTituloDiferencia.Size = new System.Drawing.Size(310, 18);
        this.lblTituloDiferencia.TabIndex = 0;
        this.lblTituloDiferencia.Text = "Diferencia (Activo - Pasivo - Patrimonio)";
        // 
        // lblTotalPasivoPatrimonio
        // 
        this.lblTotalPasivoPatrimonio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblTotalPasivoPatrimonio.Location = new System.Drawing.Point(196, 250);
        this.lblTotalPasivoPatrimonio.Name = "lblTotalPasivoPatrimonio";
        this.lblTotalPasivoPatrimonio.Size = new System.Drawing.Size(156, 24);
        this.lblTotalPasivoPatrimonio.TabIndex = 16;
        this.lblTotalPasivoPatrimonio.Text = "—";
        this.lblTotalPasivoPatrimonio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloPasivoPatrimonio
        // 
        this.lblTituloPasivoPatrimonio.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblTituloPasivoPatrimonio.Location = new System.Drawing.Point(16, 250);
        this.lblTituloPasivoPatrimonio.Name = "lblTituloPasivoPatrimonio";
        this.lblTituloPasivoPatrimonio.Size = new System.Drawing.Size(180, 24);
        this.lblTituloPasivoPatrimonio.TabIndex = 15;
        this.lblTituloPasivoPatrimonio.Text = "Total pasivo + patrimonio";
        this.lblTituloPasivoPatrimonio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblPatrimonio
        // 
        this.lblPatrimonio.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblPatrimonio.Location = new System.Drawing.Point(196, 220);
        this.lblPatrimonio.Name = "lblPatrimonio";
        this.lblPatrimonio.Size = new System.Drawing.Size(156, 24);
        this.lblPatrimonio.TabIndex = 14;
        this.lblPatrimonio.Text = "—";
        this.lblPatrimonio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloPatrimonio
        // 
        this.lblTituloPatrimonio.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblTituloPatrimonio.Location = new System.Drawing.Point(16, 220);
        this.lblTituloPatrimonio.Name = "lblTituloPatrimonio";
        this.lblTituloPatrimonio.Size = new System.Drawing.Size(180, 24);
        this.lblTituloPatrimonio.TabIndex = 13;
        this.lblTituloPatrimonio.Text = "Total patrimonio";
        this.lblTituloPatrimonio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblTotalPasivo
        // 
        this.lblTotalPasivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblTotalPasivo.Location = new System.Drawing.Point(196, 190);
        this.lblTotalPasivo.Name = "lblTotalPasivo";
        this.lblTotalPasivo.Size = new System.Drawing.Size(156, 24);
        this.lblTotalPasivo.TabIndex = 12;
        this.lblTotalPasivo.Text = "—";
        this.lblTotalPasivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloTotalPasivo
        // 
        this.lblTituloTotalPasivo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblTituloTotalPasivo.Location = new System.Drawing.Point(16, 190);
        this.lblTituloTotalPasivo.Name = "lblTituloTotalPasivo";
        this.lblTituloTotalPasivo.Size = new System.Drawing.Size(180, 24);
        this.lblTituloTotalPasivo.TabIndex = 11;
        this.lblTituloTotalPasivo.Text = "Total pasivo";
        this.lblTituloTotalPasivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblPasivosNoCorrientes
        // 
        this.lblPasivosNoCorrientes.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblPasivosNoCorrientes.Location = new System.Drawing.Point(196, 160);
        this.lblPasivosNoCorrientes.Name = "lblPasivosNoCorrientes";
        this.lblPasivosNoCorrientes.Size = new System.Drawing.Size(156, 24);
        this.lblPasivosNoCorrientes.TabIndex = 10;
        this.lblPasivosNoCorrientes.Text = "—";
        this.lblPasivosNoCorrientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloPasivosNoCorrientes
        // 
        this.lblTituloPasivosNoCorrientes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblTituloPasivosNoCorrientes.Location = new System.Drawing.Point(16, 160);
        this.lblTituloPasivosNoCorrientes.Name = "lblTituloPasivosNoCorrientes";
        this.lblTituloPasivosNoCorrientes.Size = new System.Drawing.Size(180, 24);
        this.lblTituloPasivosNoCorrientes.TabIndex = 9;
        this.lblTituloPasivosNoCorrientes.Text = "Total pasivos no corrientes";
        this.lblTituloPasivosNoCorrientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblPasivosCorrientes
        // 
        this.lblPasivosCorrientes.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblPasivosCorrientes.Location = new System.Drawing.Point(196, 130);
        this.lblPasivosCorrientes.Name = "lblPasivosCorrientes";
        this.lblPasivosCorrientes.Size = new System.Drawing.Size(156, 24);
        this.lblPasivosCorrientes.TabIndex = 8;
        this.lblPasivosCorrientes.Text = "—";
        this.lblPasivosCorrientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloPasivosCorrientes
        // 
        this.lblTituloPasivosCorrientes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblTituloPasivosCorrientes.Location = new System.Drawing.Point(16, 130);
        this.lblTituloPasivosCorrientes.Name = "lblTituloPasivosCorrientes";
        this.lblTituloPasivosCorrientes.Size = new System.Drawing.Size(180, 24);
        this.lblTituloPasivosCorrientes.TabIndex = 7;
        this.lblTituloPasivosCorrientes.Text = "Total pasivos corrientes";
        this.lblTituloPasivosCorrientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblTotalActivo
        // 
        this.lblTotalActivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblTotalActivo.Location = new System.Drawing.Point(196, 100);
        this.lblTotalActivo.Name = "lblTotalActivo";
        this.lblTotalActivo.Size = new System.Drawing.Size(156, 24);
        this.lblTotalActivo.TabIndex = 6;
        this.lblTotalActivo.Text = "—";
        this.lblTotalActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloTotalActivo
        // 
        this.lblTituloTotalActivo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblTituloTotalActivo.Location = new System.Drawing.Point(16, 100);
        this.lblTituloTotalActivo.Name = "lblTituloTotalActivo";
        this.lblTituloTotalActivo.Size = new System.Drawing.Size(180, 24);
        this.lblTituloTotalActivo.TabIndex = 5;
        this.lblTituloTotalActivo.Text = "Total activo";
        this.lblTituloTotalActivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblActivosNoCorrientes
        // 
        this.lblActivosNoCorrientes.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblActivosNoCorrientes.Location = new System.Drawing.Point(196, 70);
        this.lblActivosNoCorrientes.Name = "lblActivosNoCorrientes";
        this.lblActivosNoCorrientes.Size = new System.Drawing.Size(156, 24);
        this.lblActivosNoCorrientes.TabIndex = 4;
        this.lblActivosNoCorrientes.Text = "—";
        this.lblActivosNoCorrientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloActivosNoCorrientes
        // 
        this.lblTituloActivosNoCorrientes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblTituloActivosNoCorrientes.Location = new System.Drawing.Point(16, 70);
        this.lblTituloActivosNoCorrientes.Name = "lblTituloActivosNoCorrientes";
        this.lblTituloActivosNoCorrientes.Size = new System.Drawing.Size(180, 24);
        this.lblTituloActivosNoCorrientes.TabIndex = 3;
        this.lblTituloActivosNoCorrientes.Text = "Total activos no corrientes";
        this.lblTituloActivosNoCorrientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblActivosCorrientes
        // 
        this.lblActivosCorrientes.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblActivosCorrientes.Location = new System.Drawing.Point(196, 40);
        this.lblActivosCorrientes.Name = "lblActivosCorrientes";
        this.lblActivosCorrientes.Size = new System.Drawing.Size(156, 24);
        this.lblActivosCorrientes.TabIndex = 2;
        this.lblActivosCorrientes.Text = "—";
        this.lblActivosCorrientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTituloActivosCorrientes
        // 
        this.lblTituloActivosCorrientes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblTituloActivosCorrientes.Location = new System.Drawing.Point(16, 40);
        this.lblTituloActivosCorrientes.Name = "lblTituloActivosCorrientes";
        this.lblTituloActivosCorrientes.Size = new System.Drawing.Size(180, 24);
        this.lblTituloActivosCorrientes.TabIndex = 1;
        this.lblTituloActivosCorrientes.Text = "Total activos corrientes";
        this.lblTituloActivosCorrientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblEncabezado
        // 
        this.lblEncabezado.AutoEllipsis = true;
        this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblEncabezado.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        this.lblEncabezado.Location = new System.Drawing.Point(16, 12);
        this.lblEncabezado.Name = "lblEncabezado";
        this.lblEncabezado.Size = new System.Drawing.Size(336, 20);
        this.lblEncabezado.TabIndex = 0;
        this.lblEncabezado.Text = "Sin datos calculados";
        // 
        // BalanceGeneralForm
        // 
        this.AcceptButton = this.btnCalcular;
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.FromArgb(244, 246, 250);
        this.CancelButton = this.btnCerrar;
        this.ClientSize = new System.Drawing.Size(1080, 632);
        this.Controls.Add(this.grpResumen);
        this.Controls.Add(this.btnGuardar);
        this.Controls.Add(this.btnLimpiar);
        this.Controls.Add(this.btnCalcular);
        this.Controls.Add(this.tabDatos);
        this.Controls.Add(this.grpDatos);
        this.Controls.Add(this.panelEncabezado);
        this.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.MinimumSize = new System.Drawing.Size(1096, 671);
        this.Name = "BalanceGeneralForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Balance General - Finance Manager";
        this.panelEncabezado.ResumeLayout(false);
        this.panelEncabezado.PerformLayout();
        this.grpDatos.ResumeLayout(false);
        this.grpDatos.PerformLayout();
        this.tabDatos.ResumeLayout(false);
        this.tabActivos.ResumeLayout(false);
        this.grpActivosNoCorrientes.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.numOtrosActivosNoCorrientes)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numActivosIntangibles)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numDepreciacionAcumulada)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numPropiedadPlantaEquipo)).EndInit();
        this.grpActivosCorrientes.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.numOtrosActivosCorrientes)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numInventario)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numCuentasPorCobrar)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numEfectivo)).EndInit();
        this.tabPasivos.ResumeLayout(false);
        this.grpPasivosNoCorrientes.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.numOtrosPasivosNoCorrientes)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numPrestamosLargoPlazo)).EndInit();
        this.grpPasivosCorrientes.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.numOtrosPasivosCorrientes)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numObligacionesCortoPlazo)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numImpuestosPorPagar)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numCuentasPorPagar)).EndInit();
        this.tabPatrimonio.ResumeLayout(false);
        this.grpPatrimonio.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.numUtilidadEjercicio)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numResultadosAcumulados)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numReservas)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numCapitalSocial)).EndInit();
        this.grpResumen.ResumeLayout(false);
        this.panelEstado.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel panelEncabezado;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label lblSubtitulo;
    private System.Windows.Forms.Button btnCerrar;
    private System.Windows.Forms.GroupBox grpDatos;
    private System.Windows.Forms.Label lblEmpresa;
    private System.Windows.Forms.TextBox txtEmpresa;
    private System.Windows.Forms.Label lblFechaCorte;
    private System.Windows.Forms.DateTimePicker dtpFechaCorte;
    private System.Windows.Forms.Label lblMoneda;
    private System.Windows.Forms.TabControl tabDatos;
    private System.Windows.Forms.TabPage tabActivos;
    private System.Windows.Forms.TabPage tabPasivos;
    private System.Windows.Forms.TabPage tabPatrimonio;
    private System.Windows.Forms.GroupBox grpActivosCorrientes;
    private System.Windows.Forms.Label lblEfectivo;
    private System.Windows.Forms.NumericUpDown numEfectivo;
    private System.Windows.Forms.Label lblCuentasPorCobrar;
    private System.Windows.Forms.NumericUpDown numCuentasPorCobrar;
    private System.Windows.Forms.Label lblInventario;
    private System.Windows.Forms.NumericUpDown numInventario;
    private System.Windows.Forms.Label lblOtrosActivosCorrientes;
    private System.Windows.Forms.NumericUpDown numOtrosActivosCorrientes;
    private System.Windows.Forms.GroupBox grpActivosNoCorrientes;
    private System.Windows.Forms.Label lblPropiedadPlantaEquipo;
    private System.Windows.Forms.NumericUpDown numPropiedadPlantaEquipo;
    private System.Windows.Forms.Label lblDepreciacionAcumulada;
    private System.Windows.Forms.NumericUpDown numDepreciacionAcumulada;
    private System.Windows.Forms.Label lblActivosIntangibles;
    private System.Windows.Forms.NumericUpDown numActivosIntangibles;
    private System.Windows.Forms.Label lblOtrosActivosNoCorrientes;
    private System.Windows.Forms.NumericUpDown numOtrosActivosNoCorrientes;
    private System.Windows.Forms.GroupBox grpPasivosCorrientes;
    private System.Windows.Forms.Label lblCuentasPorPagar;
    private System.Windows.Forms.NumericUpDown numCuentasPorPagar;
    private System.Windows.Forms.Label lblImpuestosPorPagar;
    private System.Windows.Forms.NumericUpDown numImpuestosPorPagar;
    private System.Windows.Forms.Label lblObligacionesCortoPlazo;
    private System.Windows.Forms.NumericUpDown numObligacionesCortoPlazo;
    private System.Windows.Forms.Label lblOtrosPasivosCorrientes;
    private System.Windows.Forms.NumericUpDown numOtrosPasivosCorrientes;
    private System.Windows.Forms.GroupBox grpPasivosNoCorrientes;
    private System.Windows.Forms.Label lblPrestamosLargoPlazo;
    private System.Windows.Forms.NumericUpDown numPrestamosLargoPlazo;
    private System.Windows.Forms.Label lblOtrosPasivosNoCorrientes;
    private System.Windows.Forms.NumericUpDown numOtrosPasivosNoCorrientes;
    private System.Windows.Forms.Label lblAyudaPasivos;
    private System.Windows.Forms.GroupBox grpPatrimonio;
    private System.Windows.Forms.Label lblCapitalSocial;
    private System.Windows.Forms.NumericUpDown numCapitalSocial;
    private System.Windows.Forms.Label lblReservas;
    private System.Windows.Forms.NumericUpDown numReservas;
    private System.Windows.Forms.Label lblResultadosAcumulados;
    private System.Windows.Forms.NumericUpDown numResultadosAcumulados;
    private System.Windows.Forms.Label lblUtilidadEjercicio;
    private System.Windows.Forms.NumericUpDown numUtilidadEjercicio;
    private System.Windows.Forms.Button btnUsarUtilidad;
    private System.Windows.Forms.Label lblAyudaUtilidad;
    private System.Windows.Forms.Button btnCalcular;
    private System.Windows.Forms.Button btnLimpiar;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.GroupBox grpResumen;
    private System.Windows.Forms.Label lblEncabezado;
    private System.Windows.Forms.Label lblTituloActivosCorrientes;
    private System.Windows.Forms.Label lblActivosCorrientes;
    private System.Windows.Forms.Label lblTituloActivosNoCorrientes;
    private System.Windows.Forms.Label lblActivosNoCorrientes;
    private System.Windows.Forms.Label lblTituloTotalActivo;
    private System.Windows.Forms.Label lblTotalActivo;
    private System.Windows.Forms.Label lblTituloPasivosCorrientes;
    private System.Windows.Forms.Label lblPasivosCorrientes;
    private System.Windows.Forms.Label lblTituloPasivosNoCorrientes;
    private System.Windows.Forms.Label lblPasivosNoCorrientes;
    private System.Windows.Forms.Label lblTituloTotalPasivo;
    private System.Windows.Forms.Label lblTotalPasivo;
    private System.Windows.Forms.Label lblTituloPatrimonio;
    private System.Windows.Forms.Label lblPatrimonio;
    private System.Windows.Forms.Label lblTituloPasivoPatrimonio;
    private System.Windows.Forms.Label lblTotalPasivoPatrimonio;
    private System.Windows.Forms.Panel panelEstado;
    private System.Windows.Forms.Label lblTituloDiferencia;
    private System.Windows.Forms.Label lblDiferencia;
    private System.Windows.Forms.Label lblEstado;
    private System.Windows.Forms.Label lblNotaBalance;
}
