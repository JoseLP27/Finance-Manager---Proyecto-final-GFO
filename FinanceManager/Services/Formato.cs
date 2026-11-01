using System.Globalization;

namespace FinanceManager.Services;

public static class Formato
{
    public static CultureInfo Cultura { get; } = CultureInfo.GetCultureInfo("es-NI");

    public static string Moneda(decimal valor)
    {
        var redondeado = Math.Round(valor, 2, MidpointRounding.AwayFromZero);
        var texto = Math.Abs(redondeado).ToString("N2", Cultura);
        return redondeado < 0 ? $"-C$ {texto}" : $"C$ {texto}";
    }

    public static string Numero(decimal valor) => valor.ToString("N2", Cultura);

    public static string Fecha(DateTime valor) => valor.ToString("dd/MM/yyyy", Cultura);
}
