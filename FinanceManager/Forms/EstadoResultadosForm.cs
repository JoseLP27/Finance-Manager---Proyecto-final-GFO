using FinanceManager.Models;
using FinanceManager.Services;

namespace FinanceManager.Forms;

public partial class EstadoResultadosForm : Form
{
    public EstadoResultadosForm()
    {
        InitializeComponent();
        LimpiarResultados();
    }

    private void btnCalcular_Click(object? sender, EventArgs e)
    {
        var estado = ConstruirEstado();
        if (estado is null)
        {
            return;
        }

        MostrarResultados(estado);
    }

    private EstadoResultados? ConstruirEstado()
    {
        if (string.IsNullOrWhiteSpace(txtEmpresa.Text))
        {
            SolicitarDato("Ingresa el nombre de la empresa u organización.", txtEmpresa);
            return null;
        }

        if (string.IsNullOrWhiteSpace(txtPeriodo.Text))
        {
            SolicitarDato("Ingresa el período que cubre el estado de resultados.", txtPeriodo);
            return null;
        }

        return new EstadoResultados
        {
            Empresa = txtEmpresa.Text.Trim(),
            Periodo = txtPeriodo.Text.Trim(),
            VentasNetas = numVentas.Value,
            OtrosIngresos = numOtrosIngresos.Value,
            CostoVentas = numCostoVentas.Value,
            GastosAdministracion = numGastosAdministracion.Value,
            GastosVentas = numGastosVentas.Value,
            Depreciacion = numDepreciacion.Value,
            OtrosGastos = numOtrosGastos.Value,
            TasaImpuesto = numTasa.Value
        };
    }

    private void SolicitarDato(string mensaje, Control control)
    {
        MessageBox.Show(this, mensaje, "Datos incompletos",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        control.Focus();
    }

    private void MostrarResultados(EstadoResultados estado)
    {
        lblResumenEncabezado.Text = $"{estado.Empresa} · {estado.Periodo}";
        lblIngresosTotales.Text = Formato.Moneda(estado.TotalIngresos);
        lblCostoVentasResumen.Text = Formato.Moneda(estado.CostoVentas);
        lblUtilidadBruta.Text = Formato.Moneda(estado.UtilidadBruta);
        lblGastosOperativos.Text = Formato.Moneda(estado.GastosOperativos);
        lblUtilidadOperativa.Text = Formato.Moneda(estado.UtilidadOperativa);
        lblOtrosGastosResumen.Text = Formato.Moneda(estado.OtrosGastos);
        lblUtilidadAntes.Text = Formato.Moneda(estado.UtilidadAntesImpuestos);
        lblImpuesto.Text = Formato.Moneda(estado.Impuesto);
        lblUtilidadNeta.Text = Formato.Moneda(estado.UtilidadNeta);

        if (estado.UtilidadNeta >= 0)
        {
            cardUtilidad.BackColor = Color.FromArgb(15, 118, 110);
            lblMensaje.ForeColor = Color.FromArgb(21, 128, 61);
            lblMensaje.Text = $"El período cierra con una utilidad neta de {Formato.Moneda(estado.UtilidadNeta)}.";
        }
        else
        {
            cardUtilidad.BackColor = Color.FromArgb(153, 27, 27);
            lblMensaje.ForeColor = Color.FromArgb(185, 28, 28);
            lblMensaje.Text = $"El período cierra con una pérdida neta de {Formato.Moneda(Math.Abs(estado.UtilidadNeta))}.";
        }

        SesionFinanciera.UltimoEstadoResultados = estado;
    }

    private void btnLimpiar_Click(object? sender, EventArgs e)
    {
        txtEmpresa.Clear();
        txtPeriodo.Clear();
        numVentas.Value = 0M;
        numOtrosIngresos.Value = 0M;
        numCostoVentas.Value = 0M;
        numGastosAdministracion.Value = 0M;
        numGastosVentas.Value = 0M;
        numDepreciacion.Value = 0M;
        numOtrosGastos.Value = 0M;
        numTasa.Value = 30M;

        LimpiarResultados();
        txtEmpresa.Focus();
    }

    private void LimpiarResultados()
    {
        lblResumenEncabezado.Text = "Sin datos calculados";
        lblIngresosTotales.Text = "—";
        lblCostoVentasResumen.Text = "—";
        lblUtilidadBruta.Text = "—";
        lblGastosOperativos.Text = "—";
        lblUtilidadOperativa.Text = "—";
        lblOtrosGastosResumen.Text = "—";
        lblUtilidadAntes.Text = "—";
        lblImpuesto.Text = "—";
        lblUtilidadNeta.Text = "—";
        lblMensaje.Text = "Completa los datos y presiona Calcular para ver el resumen.";
        lblMensaje.ForeColor = Color.FromArgb(71, 85, 105);
        cardUtilidad.BackColor = Color.FromArgb(15, 118, 110);
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        var estado = ConstruirEstado();
        if (estado is null)
        {
            return;
        }

        MostrarResultados(estado);
        var libro = ExcelReporteService.CrearEstadoResultados(estado);
        ExportadorReporte.GuardarExcel(this, "Estado_Resultados", libro);
    }

    private void btnCerrar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
