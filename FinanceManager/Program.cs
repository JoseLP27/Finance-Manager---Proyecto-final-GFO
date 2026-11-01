using System.Globalization;

namespace FinanceManager;

static class Program
{
    [STAThread]
    static void Main()
    {
        var cultura = new CultureInfo("es-NI");
        CultureInfo.DefaultThreadCurrentCulture = cultura;
        CultureInfo.DefaultThreadCurrentUICulture = cultura;

        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}
