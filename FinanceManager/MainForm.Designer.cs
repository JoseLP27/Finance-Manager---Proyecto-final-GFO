#nullable disable

namespace FinanceManager;

partial class MainForm
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
        this.lblSubtitulo = new System.Windows.Forms.Label();
        this.lblTitulo = new System.Windows.Forms.Label();
        this.layoutOpciones = new System.Windows.Forms.TableLayoutPanel();
        this.panelEstado = new System.Windows.Forms.Panel();
        this.lblEstadoDescripcion = new System.Windows.Forms.Label();
        this.lblEstadoTitulo = new System.Windows.Forms.Label();
        this.btnEstadoResultados = new System.Windows.Forms.Button();
        this.panelBalance = new System.Windows.Forms.Panel();
        this.lblBalanceDescripcion = new System.Windows.Forms.Label();
        this.lblBalanceTitulo = new System.Windows.Forms.Label();
        this.btnBalanceGeneral = new System.Windows.Forms.Button();
        this.panelPie = new System.Windows.Forms.Panel();
        this.btnSalir = new System.Windows.Forms.Button();
        this.lblPie = new System.Windows.Forms.Label();
        this.panelEncabezado.SuspendLayout();
        this.layoutOpciones.SuspendLayout();
        this.panelEstado.SuspendLayout();
        this.panelBalance.SuspendLayout();
        this.panelPie.SuspendLayout();
        this.SuspendLayout();
        // 
        // panelEncabezado
        // 
        this.panelEncabezado.BackColor = System.Drawing.Color.FromArgb(20, 33, 61);
        this.panelEncabezado.Controls.Add(this.lblSubtitulo);
        this.panelEncabezado.Controls.Add(this.lblTitulo);
        this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
        this.panelEncabezado.Name = "panelEncabezado";
        this.panelEncabezado.Size = new System.Drawing.Size(900, 150);
        this.panelEncabezado.TabIndex = 0;
        // 
        // lblSubtitulo
        // 
        this.lblSubtitulo.AutoSize = true;
        this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(201, 211, 230);
        this.lblSubtitulo.Location = new System.Drawing.Point(43, 88);
        this.lblSubtitulo.Name = "lblSubtitulo";
        this.lblSubtitulo.Size = new System.Drawing.Size(523, 20);
        this.lblSubtitulo.TabIndex = 1;
        this.lblSubtitulo.Text = "Elabora tu estado de resultados y balance general de forma sencilla.";
        // 
        // lblTitulo
        // 
        this.lblTitulo.AutoSize = true;
        this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
        this.lblTitulo.ForeColor = System.Drawing.Color.White;
        this.lblTitulo.Location = new System.Drawing.Point(40, 34);
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.Size = new System.Drawing.Size(290, 47);
        this.lblTitulo.TabIndex = 0;
        this.lblTitulo.Text = "Finance Manager";
        // 
        // layoutOpciones
        // 
        this.layoutOpciones.ColumnCount = 2;
        this.layoutOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.layoutOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.layoutOpciones.Controls.Add(this.panelEstado, 0, 0);
        this.layoutOpciones.Controls.Add(this.panelBalance, 1, 0);
        this.layoutOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
        this.layoutOpciones.Location = new System.Drawing.Point(0, 150);
        this.layoutOpciones.Name = "layoutOpciones";
        this.layoutOpciones.Padding = new System.Windows.Forms.Padding(32, 24, 32, 24);
        this.layoutOpciones.RowCount = 1;
        this.layoutOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.layoutOpciones.Size = new System.Drawing.Size(900, 326);
        this.layoutOpciones.TabIndex = 1;
        // 
        // panelEstado
        // 
        this.panelEstado.BackColor = System.Drawing.Color.White;
        this.panelEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panelEstado.Controls.Add(this.lblEstadoDescripcion);
        this.panelEstado.Controls.Add(this.lblEstadoTitulo);
        this.panelEstado.Controls.Add(this.btnEstadoResultados);
        this.panelEstado.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panelEstado.Location = new System.Drawing.Point(40, 32);
        this.panelEstado.Margin = new System.Windows.Forms.Padding(8);
        this.panelEstado.Name = "panelEstado";
        this.panelEstado.Padding = new System.Windows.Forms.Padding(24);
        this.panelEstado.Size = new System.Drawing.Size(402, 262);
        this.panelEstado.TabIndex = 0;
        // 
        // lblEstadoDescripcion
        // 
        this.lblEstadoDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lblEstadoDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblEstadoDescripcion.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblEstadoDescripcion.Location = new System.Drawing.Point(24, 68);
        this.lblEstadoDescripcion.Name = "lblEstadoDescripcion";
        this.lblEstadoDescripcion.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
        this.lblEstadoDescripcion.Size = new System.Drawing.Size(352, 118);
        this.lblEstadoDescripcion.TabIndex = 1;
        this.lblEstadoDescripcion.Text = "Registra ingresos, costos y gastos para calcular la utilidad bruta, operativa y neta del período.";
        // 
        // lblEstadoTitulo
        // 
        this.lblEstadoTitulo.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblEstadoTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblEstadoTitulo.ForeColor = System.Drawing.Color.FromArgb(20, 33, 61);
        this.lblEstadoTitulo.Location = new System.Drawing.Point(24, 24);
        this.lblEstadoTitulo.Name = "lblEstadoTitulo";
        this.lblEstadoTitulo.Size = new System.Drawing.Size(352, 44);
        this.lblEstadoTitulo.TabIndex = 0;
        this.lblEstadoTitulo.Text = "Estado de Resultados";
        this.lblEstadoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btnEstadoResultados
        // 
        this.btnEstadoResultados.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        this.btnEstadoResultados.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnEstadoResultados.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.btnEstadoResultados.FlatAppearance.BorderSize = 0;
        this.btnEstadoResultados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 78, 216);
        this.btnEstadoResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnEstadoResultados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.btnEstadoResultados.ForeColor = System.Drawing.Color.White;
        this.btnEstadoResultados.Location = new System.Drawing.Point(24, 186);
        this.btnEstadoResultados.Name = "btnEstadoResultados";
        this.btnEstadoResultados.Size = new System.Drawing.Size(352, 50);
        this.btnEstadoResultados.TabIndex = 2;
        this.btnEstadoResultados.Text = "Crear estado de resultados";
        this.btnEstadoResultados.UseVisualStyleBackColor = false;
        this.btnEstadoResultados.Click += new System.EventHandler(this.btnEstadoResultados_Click);
        // 
        // panelBalance
        // 
        this.panelBalance.BackColor = System.Drawing.Color.White;
        this.panelBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panelBalance.Controls.Add(this.lblBalanceDescripcion);
        this.panelBalance.Controls.Add(this.lblBalanceTitulo);
        this.panelBalance.Controls.Add(this.btnBalanceGeneral);
        this.panelBalance.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panelBalance.Location = new System.Drawing.Point(458, 32);
        this.panelBalance.Margin = new System.Windows.Forms.Padding(8);
        this.panelBalance.Name = "panelBalance";
        this.panelBalance.Padding = new System.Windows.Forms.Padding(24);
        this.panelBalance.Size = new System.Drawing.Size(402, 262);
        this.panelBalance.TabIndex = 1;
        // 
        // lblBalanceDescripcion
        // 
        this.lblBalanceDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lblBalanceDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblBalanceDescripcion.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblBalanceDescripcion.Location = new System.Drawing.Point(24, 68);
        this.lblBalanceDescripcion.Name = "lblBalanceDescripcion";
        this.lblBalanceDescripcion.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
        this.lblBalanceDescripcion.Size = new System.Drawing.Size(352, 118);
        this.lblBalanceDescripcion.TabIndex = 1;
        this.lblBalanceDescripcion.Text = "Captura activos, pasivos y patrimonio para verificar que la ecuación contable cuadre.";
        // 
        // lblBalanceTitulo
        // 
        this.lblBalanceTitulo.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblBalanceTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblBalanceTitulo.ForeColor = System.Drawing.Color.FromArgb(20, 33, 61);
        this.lblBalanceTitulo.Location = new System.Drawing.Point(24, 24);
        this.lblBalanceTitulo.Name = "lblBalanceTitulo";
        this.lblBalanceTitulo.Size = new System.Drawing.Size(352, 44);
        this.lblBalanceTitulo.TabIndex = 0;
        this.lblBalanceTitulo.Text = "Balance General";
        this.lblBalanceTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btnBalanceGeneral
        // 
        this.btnBalanceGeneral.BackColor = System.Drawing.Color.FromArgb(15, 118, 110);
        this.btnBalanceGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnBalanceGeneral.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.btnBalanceGeneral.FlatAppearance.BorderSize = 0;
        this.btnBalanceGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(13, 100, 94);
        this.btnBalanceGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnBalanceGeneral.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.btnBalanceGeneral.ForeColor = System.Drawing.Color.White;
        this.btnBalanceGeneral.Location = new System.Drawing.Point(24, 186);
        this.btnBalanceGeneral.Name = "btnBalanceGeneral";
        this.btnBalanceGeneral.Size = new System.Drawing.Size(352, 50);
        this.btnBalanceGeneral.TabIndex = 2;
        this.btnBalanceGeneral.Text = "Crear balance general";
        this.btnBalanceGeneral.UseVisualStyleBackColor = false;
        this.btnBalanceGeneral.Click += new System.EventHandler(this.btnBalanceGeneral_Click);
        // 
        // panelPie
        // 
        this.panelPie.BackColor = System.Drawing.Color.White;
        this.panelPie.Controls.Add(this.btnSalir);
        this.panelPie.Controls.Add(this.lblPie);
        this.panelPie.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.panelPie.Location = new System.Drawing.Point(0, 476);
        this.panelPie.Name = "panelPie";
        this.panelPie.Size = new System.Drawing.Size(900, 84);
        this.panelPie.TabIndex = 2;
        // 
        // btnSalir
        // 
        this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSalir.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
        this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnSalir.FlatAppearance.BorderSize = 0;
        this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.btnSalir.Location = new System.Drawing.Point(760, 24);
        this.btnSalir.Name = "btnSalir";
        this.btnSalir.Size = new System.Drawing.Size(100, 36);
        this.btnSalir.TabIndex = 1;
        this.btnSalir.Text = "Salir";
        this.btnSalir.UseVisualStyleBackColor = false;
        this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
        // 
        // lblPie
        // 
        this.lblPie.AutoSize = true;
        this.lblPie.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblPie.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        this.lblPie.Location = new System.Drawing.Point(40, 32);
        this.lblPie.Name = "lblPie";
        this.lblPie.Size = new System.Drawing.Size(536, 17);
        this.lblPie.TabIndex = 0;
        this.lblPie.Text = "Los cálculos se realizan automáticamente y cada reporte se puede guardar en un archivo de texto.";
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.FromArgb(244, 246, 250);
        this.ClientSize = new System.Drawing.Size(900, 560);
        this.Controls.Add(this.layoutOpciones);
        this.Controls.Add(this.panelPie);
        this.Controls.Add(this.panelEncabezado);
        this.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.MinimumSize = new System.Drawing.Size(880, 580);
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Finance Manager";
        this.panelEncabezado.ResumeLayout(false);
        this.panelEncabezado.PerformLayout();
        this.layoutOpciones.ResumeLayout(false);
        this.panelEstado.ResumeLayout(false);
        this.panelBalance.ResumeLayout(false);
        this.panelPie.ResumeLayout(false);
        this.panelPie.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel panelEncabezado;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label lblSubtitulo;
    private System.Windows.Forms.TableLayoutPanel layoutOpciones;
    private System.Windows.Forms.Panel panelEstado;
    private System.Windows.Forms.Label lblEstadoTitulo;
    private System.Windows.Forms.Label lblEstadoDescripcion;
    private System.Windows.Forms.Button btnEstadoResultados;
    private System.Windows.Forms.Panel panelBalance;
    private System.Windows.Forms.Label lblBalanceTitulo;
    private System.Windows.Forms.Label lblBalanceDescripcion;
    private System.Windows.Forms.Button btnBalanceGeneral;
    private System.Windows.Forms.Panel panelPie;
    private System.Windows.Forms.Label lblPie;
    private System.Windows.Forms.Button btnSalir;
}
