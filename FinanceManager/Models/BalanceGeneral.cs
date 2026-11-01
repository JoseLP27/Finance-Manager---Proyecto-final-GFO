namespace FinanceManager.Models;

public sealed class BalanceGeneral
{
    public string Empresa { get; init; } = string.Empty;
    public DateTime FechaCorte { get; init; }

    public decimal Efectivo { get; init; }
    public decimal CuentasPorCobrar { get; init; }
    public decimal Inventario { get; init; }
    public decimal OtrosActivosCorrientes { get; init; }

    public decimal PropiedadPlantaEquipo { get; init; }
    public decimal DepreciacionAcumulada { get; init; }
    public decimal ActivosIntangibles { get; init; }
    public decimal OtrosActivosNoCorrientes { get; init; }

    public decimal CuentasPorPagar { get; init; }
    public decimal ImpuestosPorPagar { get; init; }
    public decimal ObligacionesCortoPlazo { get; init; }
    public decimal OtrosPasivosCorrientes { get; init; }

    public decimal PrestamosLargoPlazo { get; init; }
    public decimal OtrosPasivosNoCorrientes { get; init; }

    public decimal CapitalSocial { get; init; }
    public decimal Reservas { get; init; }
    public decimal ResultadosAcumulados { get; init; }
    public decimal UtilidadEjercicio { get; init; }

    public decimal TotalActivosCorrientes =>
        Efectivo + CuentasPorCobrar + Inventario + OtrosActivosCorrientes;

    public decimal TotalActivosNoCorrientes =>
        PropiedadPlantaEquipo - DepreciacionAcumulada + ActivosIntangibles + OtrosActivosNoCorrientes;

    public decimal TotalActivo => TotalActivosCorrientes + TotalActivosNoCorrientes;

    public decimal TotalPasivosCorrientes =>
        CuentasPorPagar + ImpuestosPorPagar + ObligacionesCortoPlazo + OtrosPasivosCorrientes;

    public decimal TotalPasivosNoCorrientes => PrestamosLargoPlazo + OtrosPasivosNoCorrientes;

    public decimal TotalPasivo => TotalPasivosCorrientes + TotalPasivosNoCorrientes;

    public decimal TotalPatrimonio =>
        CapitalSocial + Reservas + ResultadosAcumulados + UtilidadEjercicio;

    public decimal TotalPasivoYPatrimonio => TotalPasivo + TotalPatrimonio;

    public decimal Diferencia => TotalActivo - TotalPasivoYPatrimonio;

    public bool Cuadra => Math.Abs(Diferencia) < 0.01m;
}
