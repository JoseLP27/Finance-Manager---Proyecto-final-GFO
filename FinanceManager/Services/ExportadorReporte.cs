using ClosedXML.Excel;

namespace FinanceManager.Services;

public static class ExportadorReporte
{
    public static void GuardarExcel(IWin32Window owner, string nombreBase, XLWorkbook libro)
    {
        try
        {
            using var dialogo = new SaveFileDialog
            {
                Filter = "Excel (*.xlsx)|*.xlsx",
                FileName = $"{nombreBase}_{DateTime.Now:yyyyMMdd_HHmm}.xlsx",
                Title = "Guardar reporte en Excel",
                DefaultExt = "xlsx",
                AddExtension = true,
                OverwritePrompt = true
            };

            if (dialogo.ShowDialog(owner) != DialogResult.OK)
            {
                return;
            }

            libro.SaveAs(dialogo.FileName);
            MessageBox.Show(owner, "Reporte guardado correctamente en Excel.", "Finance Manager",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(owner, $"No se pudo guardar el reporte.\n\n{ex.Message}", "Error al guardar",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            libro.Dispose();
        }
    }
}
