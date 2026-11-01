using ClosedXML.Excel;
using FinanceManager.Models;

namespace FinanceManager.Services;

public static class ExcelReporteService
{
    private const string FormatoMoneda = "\"C$\" #,##0.00";

    public static XLWorkbook CrearEstadoResultados(EstadoResultados estado)
    {
        var libro = new XLWorkbook();
        var hoja = libro.Worksheets.Add("Estado de Resultados");
        PrepararHoja(hoja, "ESTADO DE RESULTADOS");

        var fila = 3;
        EscribirDato(hoja, ref fila, "Empresa", estado.Empresa);
        EscribirDato(hoja, ref fila, "Período", estado.Periodo);
        EscribirDato(hoja, ref fila, "Moneda", "Córdobas (C$)");

        fila++;
        EscribirSeccion(hoja, ref fila, "INGRESOS");
        EscribirEncabezado(hoja, ref fila);
        EscribirFila(hoja, ref fila, "Ventas netas", estado.VentasNetas);
        EscribirFila(hoja, ref fila, "Otros ingresos", estado.OtrosIngresos);
        EscribirFila(hoja, ref fila, "Total ingresos", estado.TotalIngresos, true);

        fila++;
        EscribirSeccion(hoja, ref fila, "COSTOS Y GASTOS");
        EscribirFila(hoja, ref fila, "Costo de ventas", estado.CostoVentas);
        EscribirFila(hoja, ref fila, "Utilidad bruta", estado.UtilidadBruta, true);

        fila++;
        EscribirSeccion(hoja, ref fila, "GASTOS OPERATIVOS");
        EscribirFila(hoja, ref fila, "Gastos de administración", estado.GastosAdministracion);
        EscribirFila(hoja, ref fila, "Gastos de ventas", estado.GastosVentas);
        EscribirFila(hoja, ref fila, "Depreciación y amortización", estado.Depreciacion);
        EscribirFila(hoja, ref fila, "Total gastos operativos", estado.GastosOperativos, true);
        EscribirFila(hoja, ref fila, "Utilidad operativa", estado.UtilidadOperativa, true);

        fila++;
        EscribirSeccion(hoja, ref fila, "RESULTADOS");
        EscribirFila(hoja, ref fila, "Otros gastos", estado.OtrosGastos);
        EscribirFila(hoja, ref fila, "Utilidad antes de impuestos", estado.UtilidadAntesImpuestos, true);
        EscribirFila(hoja, ref fila,
            $"Impuesto sobre la renta ({Formato.Numero(estado.TasaImpuesto)} %)", estado.Impuesto);
        EscribirFila(hoja, ref fila, "UTILIDAD NETA", estado.UtilidadNeta, true, true);

        fila++;
        EscribirNota(hoja, ref fila);

        return libro;
    }

    public static XLWorkbook CrearBalanceGeneral(BalanceGeneral balance)
    {
        var libro = new XLWorkbook();
        var hoja = libro.Worksheets.Add("Balance General");
        PrepararHoja(hoja, "BALANCE GENERAL");

        var fila = 3;
        EscribirDato(hoja, ref fila, "Empresa", balance.Empresa);
        EscribirDato(hoja, ref fila, "Fecha de corte", Formato.Fecha(balance.FechaCorte));
        EscribirDato(hoja, ref fila, "Moneda", "Córdobas (C$)");

        fila++;
        EscribirSeccion(hoja, ref fila, "ACTIVOS");
        EscribirEncabezado(hoja, ref fila);

        EscribirSubseccion(hoja, ref fila, "Activos corrientes");
        EscribirFila(hoja, ref fila, "Efectivo y equivalentes", balance.Efectivo);
        EscribirFila(hoja, ref fila, "Cuentas por cobrar", balance.CuentasPorCobrar);
        EscribirFila(hoja, ref fila, "Inventario", balance.Inventario);
        EscribirFila(hoja, ref fila, "Otros activos corrientes", balance.OtrosActivosCorrientes);
        EscribirFila(hoja, ref fila, "Total activos corrientes", balance.TotalActivosCorrientes, true);

        fila++;
        EscribirSubseccion(hoja, ref fila, "Activos no corrientes");
        EscribirFila(hoja, ref fila, "Propiedad, planta y equipo", balance.PropiedadPlantaEquipo);
        EscribirFila(hoja, ref fila, "(-) Depreciación acumulada", -balance.DepreciacionAcumulada);
        EscribirFila(hoja, ref fila, "Activos intangibles", balance.ActivosIntangibles);
        EscribirFila(hoja, ref fila, "Otros activos no corrientes", balance.OtrosActivosNoCorrientes);
        EscribirFila(hoja, ref fila, "Total activos no corrientes", balance.TotalActivosNoCorrientes, true);
        EscribirFila(hoja, ref fila, "TOTAL ACTIVO", balance.TotalActivo, true, true);

        fila++;
        EscribirSeccion(hoja, ref fila, "PASIVOS");
        EscribirSubseccion(hoja, ref fila, "Pasivos corrientes");
        EscribirFila(hoja, ref fila, "Cuentas por pagar", balance.CuentasPorPagar);
        EscribirFila(hoja, ref fila, "Impuestos por pagar", balance.ImpuestosPorPagar);
        EscribirFila(hoja, ref fila, "Obligaciones a corto plazo", balance.ObligacionesCortoPlazo);
        EscribirFila(hoja, ref fila, "Otros pasivos corrientes", balance.OtrosPasivosCorrientes);
        EscribirFila(hoja, ref fila, "Total pasivos corrientes", balance.TotalPasivosCorrientes, true);

        fila++;
        EscribirSubseccion(hoja, ref fila, "Pasivos no corrientes");
        EscribirFila(hoja, ref fila, "Préstamos a largo plazo", balance.PrestamosLargoPlazo);
        EscribirFila(hoja, ref fila, "Otros pasivos no corrientes", balance.OtrosPasivosNoCorrientes);
        EscribirFila(hoja, ref fila, "Total pasivos no corrientes", balance.TotalPasivosNoCorrientes, true);
        EscribirFila(hoja, ref fila, "TOTAL PASIVO", balance.TotalPasivo, true, true);

        fila++;
        EscribirSeccion(hoja, ref fila, "PATRIMONIO");
        EscribirFila(hoja, ref fila, "Capital social", balance.CapitalSocial);
        EscribirFila(hoja, ref fila, "Reservas", balance.Reservas);
        EscribirFila(hoja, ref fila, "Resultados acumulados", balance.ResultadosAcumulados);
        EscribirFila(hoja, ref fila, "Utilidad del ejercicio", balance.UtilidadEjercicio);
        EscribirFila(hoja, ref fila, "TOTAL PATRIMONIO", balance.TotalPatrimonio, true, true);

        fila++;
        EscribirFila(hoja, ref fila, "TOTAL PASIVO + PATRIMONIO", balance.TotalPasivoYPatrimonio, true, true);
        EscribirFila(hoja, ref fila, "Diferencia (Activo - Pasivo - Patrimonio)", balance.Diferencia, true);

        fila++;
        EscribirMensaje(hoja, ref fila, balance.Cuadra
            ? "Resultado: el balance cuadra (Activo = Pasivo + Patrimonio)."
            : "Resultado: el balance no cuadra. Revisa los montos registrados.", balance.Cuadra);

        fila++;
        EscribirNota(hoja, ref fila);

        return libro;
    }

    private static void PrepararHoja(IXLWorksheet hoja, string titulo)
    {
        hoja.Style.Font.FontName = "Segoe UI";
        hoja.Style.Font.FontSize = 11;
        hoja.Style.Font.FontColor = XLColor.FromHtml("#1E293B");
        hoja.Column(1).Width = 52;
        hoja.Column(2).Width = 22;
        hoja.Column(1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
        hoja.Column(2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

        hoja.Cell(1, 1).Value = titulo;
        var rango = hoja.Range(1, 1, 1, 2);
        rango.Merge();
        rango.Style.Font.Bold = true;
        rango.Style.Font.FontSize = 16;
        rango.Style.Font.FontColor = XLColor.White;
        rango.Style.Fill.BackgroundColor = XLColor.FromHtml("#0F766E");
        rango.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
        rango.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
        hoja.Row(1).Height = 28;
    }

    private static void EscribirDato(IXLWorksheet hoja, ref int fila, string etiqueta, string valor)
    {
        hoja.Cell(fila, 1).Value = etiqueta;
        hoja.Cell(fila, 1).Style.Font.Bold = true;
        hoja.Cell(fila, 2).Value = valor;
        hoja.Cell(fila, 2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
        fila++;
    }

    private static void EscribirSeccion(IXLWorksheet hoja, ref int fila, string titulo)
    {
        hoja.Cell(fila, 1).Value = titulo;
        var rango = hoja.Range(fila, 1, fila, 2);
        rango.Merge();
        rango.Style.Font.Bold = true;
        rango.Style.Font.FontSize = 12;
        rango.Style.Fill.BackgroundColor = XLColor.FromHtml("#E2E8F0");
        rango.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
        hoja.Row(fila).Height = 20;
        fila++;
    }

    private static void EscribirSubseccion(IXLWorksheet hoja, ref int fila, string titulo)
    {
        hoja.Cell(fila, 1).Value = titulo;
        hoja.Cell(fila, 1).Style.Font.Bold = true;
        hoja.Cell(fila, 1).Style.Font.Italic = true;
        fila++;
    }

    private static void EscribirEncabezado(IXLWorksheet hoja, ref int fila)
    {
        hoja.Cell(fila, 1).Value = "Concepto";
        hoja.Cell(fila, 2).Value = "Monto (C$)";
        var rango = hoja.Range(fila, 1, fila, 2);
        rango.Style.Font.Bold = true;
        rango.Style.Font.FontColor = XLColor.White;
        rango.Style.Fill.BackgroundColor = XLColor.FromHtml("#0F766E");
        rango.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
        hoja.Cell(fila, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
        hoja.Cell(fila, 2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
        fila++;
    }

    private static void EscribirFila(IXLWorksheet hoja, ref int fila, string etiqueta, decimal valor,
        bool destacar = false, bool rellenar = false)
    {
        hoja.Cell(fila, 1).Value = etiqueta;
        var celda = hoja.Cell(fila, 2);
        celda.Value = valor;
        celda.Style.NumberFormat.Format = FormatoMoneda;

        if (destacar)
        {
            var rango = hoja.Range(fila, 1, fila, 2);
            rango.Style.Font.Bold = true;
            rango.Style.Border.TopBorder = XLBorderStyleValues.Thin;

            if (rellenar)
            {
                rango.Style.Fill.BackgroundColor = XLColor.FromHtml("#D1FAE5");
            }
        }

        fila++;
    }

    private static void EscribirMensaje(IXLWorksheet hoja, ref int fila, string texto, bool correcto)
    {
        hoja.Cell(fila, 1).Value = texto;
        var rango = hoja.Range(fila, 1, fila, 2);
        rango.Merge();
        rango.Style.Font.Bold = true;
        rango.Style.Font.FontColor = correcto
            ? XLColor.FromHtml("#15803D")
            : XLColor.FromHtml("#B91C1C");
        rango.Style.Fill.BackgroundColor = correcto
            ? XLColor.FromHtml("#ECFDF5")
            : XLColor.FromHtml("#FEF2F2");
        rango.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
        rango.Style.Alignment.WrapText = true;
        hoja.Row(fila).Height = 30;
        fila++;
    }

    private static void EscribirNota(IXLWorksheet hoja, ref int fila)
    {
        hoja.Cell(fila, 1).Value =
            $"Generado el {DateTime.Now:dd/MM/yyyy HH:mm} por Finance Manager.";
        var rango = hoja.Range(fila, 1, fila, 2);
        rango.Merge();
        rango.Style.Font.Italic = true;
        rango.Style.Font.FontSize = 9;
        rango.Style.Font.FontColor = XLColor.FromHtml("#64748B");
        fila++;
    }
}
