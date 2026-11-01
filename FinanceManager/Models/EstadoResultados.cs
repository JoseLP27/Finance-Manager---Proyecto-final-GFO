namespace FinanceManager.Models;

public sealed class EstadoResultados
{
    public string Empresa { get; init; } = string.Empty;
    public string Periodo { get; init; } = string.Empty;

    public decimal VentasNetas { get; init; }
    public decimal OtrosIngresos { get; init; }
    public decimal CostoVentas { get; init; }
    public decimal GastosAdministracion { get; init; }
    public decimal GastosVentas { get; init; }
    public decimal Depreciacion { get; init; }
    public decimal OtrosGastos { get; init; }
    public decimal TasaImpuesto { get; init; }

    public decimal TotalIngresos => VentasNetas + OtrosIngresos;

    public decimal UtilidadBruta => VentasNetas - CostoVentas;

    public decimal GastosOperativos => GastosAdministracion + GastosVentas + Depreciacion;

    public decimal UtilidadOperativa => UtilidadBruta + OtrosIngresos - GastosOperativos;

    public decimal UtilidadAntesImpuestos => UtilidadOperativa - OtrosGastos;

    public decimal Impuesto => UtilidadAntesImpuestos > 0
        ? Math.Round(UtilidadAntesImpuestos * TasaImpuesto / 100m, 2, MidpointRounding.AwayFromZero)
        : 0m;

    public decimal UtilidadNeta => UtilidadAntesImpuestos - Impuesto;
}
