using FinanceManager.Forms;

namespace FinanceManager;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void btnEstadoResultados_Click(object? sender, EventArgs e)
    {
        using var formulario = new EstadoResultadosForm();
        formulario.ShowDialog(this);
    }

    private void btnBalanceGeneral_Click(object? sender, EventArgs e)
    {
        using var formulario = new BalanceGeneralForm();
        formulario.ShowDialog(this);
    }

    private void btnSalir_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
