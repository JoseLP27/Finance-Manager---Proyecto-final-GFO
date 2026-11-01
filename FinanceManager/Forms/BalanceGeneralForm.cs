using FinanceManager.Models;
using FinanceManager.Services;

namespace FinanceManager.Forms;

public partial class BalanceGeneralForm : Form
{
    public BalanceGeneralForm()
    {
        InitializeComponent();
        dtpFechaCorte.Value = DateTime.Today;
        CargarUtilidadDeSesion();
        LimpiarResumen();
    }

    private void CargarUtilidadDeSesion()
    {
        var ultimo = SesionFinanciera.UltimoEstadoResultados;
        if (ultimo is null)
        {
            return;
        }

        txtEmpresa.Text = ultimo.Empresa;
        numUtilidadEjercicio.Value = AjustarAlRango(numUtilidadEjercicio, ultimo.UtilidadNeta);
        lblAyudaUtilidad.Text =
            $"Se aplicó la utilidad neta de {Formato.Moneda(ultimo.UtilidadNeta)} del período {ultimo.Periodo}.";
    }

    private static decimal AjustarAlRango(NumericUpDown control, decimal valor)
    {
        return Math.Min(control.Maximum, Math.Max(control.Minimum, valor));
    }

    private void btnUsarUtilidad_Click(object? sender, EventArgs e)
    {
        var ultimo = SesionFinanciera.UltimoEstadoResultados;
        if (ultimo is null)
        {
            MessageBox.Show(this, "Todavía no has calculado un estado de resultados en esta sesión.",
                "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        numUtilidadEjercicio.Value = AjustarAlRango(numUtilidadEjercicio, ultimo.UtilidadNeta);
        if (string.IsNullOrWhiteSpace(txtEmpresa.Text))
        {
            txtEmpresa.Text = ultimo.Empresa;
        }

        lblAyudaUtilidad.Text =
            $"Se aplicó la utilidad neta de {Formato.Moneda(ultimo.UtilidadNeta)} del período {ultimo.Periodo}.";
    }

    private BalanceGeneral? ConstruirBalance()
    {
        if (string.IsNullOrWhiteSpace(txtEmpresa.Text))
        {
            MessageBox.Show(this, "Ingresa el nombre de la empresa u organización.",
                "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEmpresa.Focus();
            return null;
        }

        return new BalanceGeneral
        {
            Empresa = txtEmpresa.Text.Trim(),
            FechaCorte = dtpFechaCorte.Value.Date,
            Efectivo = numEfectivo.Value,
            CuentasPorCobrar = numCuentasPorCobrar.Value,
            Inventario = numInventario.Value,
            OtrosActivosCorrientes = numOtrosActivosCorrientes.Value,
            PropiedadPlantaEquipo = numPropiedadPlantaEquipo.Value,
            DepreciacionAcumulada = numDepreciacionAcumulada.Value,
            ActivosIntangibles = numActivosIntangibles.Value,
            OtrosActivosNoCorrientes = numOtrosActivosNoCorrientes.Value,
            CuentasPorPagar = numCuentasPorPagar.Value,
            ImpuestosPorPagar = numImpuestosPorPagar.Value,
            ObligacionesCortoPlazo = numObligacionesCortoPlazo.Value,
            OtrosPasivosCorrientes = numOtrosPasivosCorrientes.Value,
            PrestamosLargoPlazo = numPrestamosLargoPlazo.Value,
            OtrosPasivosNoCorrientes = numOtrosPasivosNoCorrientes.Value,
            CapitalSocial = numCapitalSocial.Value,
            Reservas = numReservas.Value,
            ResultadosAcumulados = numResultadosAcumulados.Value,
            UtilidadEjercicio = numUtilidadEjercicio.Value
        };
    }

    private void MostrarResultados(BalanceGeneral balance)
    {
        lblEncabezado.Text = $"{balance.Empresa} · {Formato.Fecha(balance.FechaCorte)}";
        lblActivosCorrientes.Text = Formato.Moneda(balance.TotalActivosCorrientes);
        lblActivosNoCorrientes.Text = Formato.Moneda(balance.TotalActivosNoCorrientes);
        lblTotalActivo.Text = Formato.Moneda(balance.TotalActivo);
        lblPasivosCorrientes.Text = Formato.Moneda(balance.TotalPasivosCorrientes);
        lblPasivosNoCorrientes.Text = Formato.Moneda(balance.TotalPasivosNoCorrientes);
        lblTotalPasivo.Text = Formato.Moneda(balance.TotalPasivo);
        lblPatrimonio.Text = Formato.Moneda(balance.TotalPatrimonio);
        lblTotalPasivoPatrimonio.Text = Formato.Moneda(balance.TotalPasivoYPatrimonio);
        lblDiferencia.Text = Formato.Moneda(balance.Diferencia);

        if (balance.Cuadra)
        {
            panelEstado.BackColor = Color.FromArgb(236, 253, 245);
            lblDiferencia.ForeColor = Color.FromArgb(15, 118, 110);
            lblEstado.ForeColor = Color.FromArgb(21, 128, 61);
            lblEstado.Text = "El balance cuadra: Activo = Pasivo + Patrimonio.";
        }
        else
        {
            panelEstado.BackColor = Color.FromArgb(254, 242, 242);
            lblDiferencia.ForeColor = Color.FromArgb(185, 28, 28);
            lblEstado.ForeColor = Color.FromArgb(185, 28, 28);
            lblEstado.Text = $"El balance no cuadra. Diferencia: {Formato.Moneda(balance.Diferencia)}.";
        }
    }

    private void btnCalcular_Click(object? sender, EventArgs e)
    {
        var balance = ConstruirBalance();
        if (balance is null)
        {
            return;
        }

        MostrarResultados(balance);
    }

    private void btnLimpiar_Click(object? sender, EventArgs e)
    {
        txtEmpresa.Clear();
        dtpFechaCorte.Value = DateTime.Today;

        numEfectivo.Value = 0M;
        numCuentasPorCobrar.Value = 0M;
        numInventario.Value = 0M;
        numOtrosActivosCorrientes.Value = 0M;
        numPropiedadPlantaEquipo.Value = 0M;
        numDepreciacionAcumulada.Value = 0M;
        numActivosIntangibles.Value = 0M;
        numOtrosActivosNoCorrientes.Value = 0M;
        numCuentasPorPagar.Value = 0M;
        numImpuestosPorPagar.Value = 0M;
        numObligacionesCortoPlazo.Value = 0M;
        numOtrosPasivosCorrientes.Value = 0M;
        numPrestamosLargoPlazo.Value = 0M;
        numOtrosPasivosNoCorrientes.Value = 0M;
        numCapitalSocial.Value = 0M;
        numReservas.Value = 0M;
        numResultadosAcumulados.Value = 0M;
        numUtilidadEjercicio.Value = 0M;

        lblAyudaUtilidad.Text =
            "Si ya calculaste un estado de resultados, puedes trasladar automáticamente su utilidad neta al patrimonio.";

        LimpiarResumen();
        txtEmpresa.Focus();
    }

    private void LimpiarResumen()
    {
        lblEncabezado.Text = "Sin datos calculados";
        lblActivosCorrientes.Text = "—";
        lblActivosNoCorrientes.Text = "—";
        lblTotalActivo.Text = "—";
        lblPasivosCorrientes.Text = "—";
        lblPasivosNoCorrientes.Text = "—";
        lblTotalPasivo.Text = "—";
        lblPatrimonio.Text = "—";
        lblTotalPasivoPatrimonio.Text = "—";
        lblDiferencia.Text = "—";
        lblDiferencia.ForeColor = Color.FromArgb(100, 116, 139);
        panelEstado.BackColor = Color.FromArgb(248, 250, 252);
        lblEstado.ForeColor = Color.FromArgb(100, 116, 139);
        lblEstado.Text = "Completa los montos y presiona Calcular para verificar la ecuación contable.";
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        var balance = ConstruirBalance();
        if (balance is null)
        {
            return;
        }

        MostrarResultados(balance);
        var libro = ExcelReporteService.CrearBalanceGeneral(balance);
        ExportadorReporte.GuardarExcel(this, "Balance_General", libro);
    }

    private void btnCerrar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
