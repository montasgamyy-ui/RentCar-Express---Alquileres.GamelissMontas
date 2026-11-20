using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace RentCar_Express___Alquileres
{
    // Formulario construido 100% por código: no necesita Designer.
    // Si el proyecto trae frmAlquiler.Designer.cs, bórralo (o usa solo la lógica).
    public class frmAlquiler : Form
    {
        // ---------- Constantes (reglas de negocio) ----------
        private const decimal RECARGO_SEGURO_COMPLETO = 300m;
        private const decimal RECARGO_GPS = 100m;
        private const decimal PORCENTAJE_DESCUENTO_CORPORATIVO = 0.15m;
        private const decimal COSTO_DOMICILIO = 500m;
        private const decimal PORCENTAJE_ITBIS = 0.18m;

        // ---------- Anchos de columnas del ListBox ----------
        private const int ANCHO_DIAS = 6;
        private const int ANCHO_VEHICULO = 24;
        private const int ANCHO_TARIFA = 10;
        private const int ANCHO_TOTAL = 12;

        private const string FORMATO_MONEDA = "RD$ ";

        // ---------- Acumulador ----------
        private decimal subtotalAcumulado = 0m;

        // ---------- Controles ----------
        private TextBox txtCliente, txtVehiculo, txtTarifa;
        private DateTimePicker dtpSalida;
        private CheckBox chkCorporativo, chkGps;
        private NumericUpDown nudDias;
        private GroupBox grpSeguro, grpEntrega;
        private RadioButton rbtBasico, rbtCompleto, rbtSucursal, rbtDomicilio;
        private Label lblEncabezado, lblSubtotal, lblDescuento, lblDomicilio, lblItbis, lblTotal;
        private ListBox lstAlquileres;
        private Button btnAgregar, btnCalcular, btnLimpiar, btnSalir;

        public frmAlquiler()
        {
            ConstruirInterfaz();
            Load += frmAlquiler_Load;
            btnAgregar.Click += btnAgregar_Click;
            btnCalcular.Click += btnCalcular_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnSalir.Click += btnSalir_Click;
        }

        // =====================================================
        //  PARTE I - INTERFAZ
        // =====================================================
        private void ConstruirInterfaz()
        {
            Text = "RentaCar Express - Alquileres";
            ClientSize = new Size(760, 520);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Controls.Add(Etiqueta("Cliente:", 20, 23));
            txtCliente = new TextBox { Name = "txtCliente", Location = new Point(110, 20), Width = 260 };
            Controls.Add(txtCliente);

            chkCorporativo = new CheckBox { Name = "chkCorporativo", Text = "Cliente corporativo", Location = new Point(20, 55), AutoSize = true };
            Controls.Add(chkCorporativo);

            Controls.Add(Etiqueta("Salida:", 20, 93));
            dtpSalida = new DateTimePicker { Name = "dtpSalida", Format = DateTimePickerFormat.Short, Location = new Point(110, 90), Width = 260 };
            Controls.Add(dtpSalida);

            Controls.Add(Etiqueta("Vehículo:", 20, 128));
            txtVehiculo = new TextBox { Name = "txtVehiculo", Location = new Point(110, 125), Width = 260 };
            Controls.Add(txtVehiculo);

            Controls.Add(Etiqueta("Tarifa:", 20, 163));
            txtTarifa = new TextBox { Name = "txtTarifa", Location = new Point(110, 160), Width = 260 };
            Controls.Add(txtTarifa);

            Controls.Add(Etiqueta("Días:", 20, 198));
            nudDias = new NumericUpDown { Name = "nudDias", Minimum = 1, Maximum = 30, Value = 1, Location = new Point(110, 195), Width = 80 };
            Controls.Add(nudDias);

            grpSeguro = new GroupBox { Name = "grpSeguro", Text = "Seguro", Location = new Point(20, 235), Size = new Size(170, 85) };
            rbtBasico = new RadioButton { Name = "rbtBasico", Text = "Básico", Checked = true, Location = new Point(12, 25), AutoSize = true };
            rbtCompleto = new RadioButton { Name = "rbtCompleto", Text = "Completo (+RD$300)", Location = new Point(12, 52), AutoSize = true };
            grpSeguro.Controls.AddRange(new Control[] { rbtBasico, rbtCompleto });
            Controls.Add(grpSeguro);

            grpEntrega = new GroupBox { Name = "grpEntrega", Text = "Entrega", Location = new Point(200, 235), Size = new Size(170, 85) };
            rbtSucursal = new RadioButton { Name = "rbtSucursal", Text = "En sucursal", Checked = true, Location = new Point(12, 25), AutoSize = true };
            rbtDomicilio = new RadioButton { Name = "rbtDomicilio", Text = "Domicilio (+RD$500)", Location = new Point(12, 52), AutoSize = true };
            grpEntrega.Controls.AddRange(new Control[] { rbtSucursal, rbtDomicilio });
            Controls.Add(grpEntrega);

            chkGps = new CheckBox { Name = "chkGps", Text = "GPS (+RD$100 por día)", Location = new Point(20, 335), AutoSize = true };
            Controls.Add(chkGps);

            btnAgregar = new Button { Name = "btnAgregar", Text = "Agregar al alquiler", Location = new Point(390, 15), Size = new Size(350, 40) };
            Controls.Add(btnAgregar);

            Font fuenteMono = new Font("Consolas", 9.5f);
            lblEncabezado = new Label { Name = "lblEncabezado", Font = fuenteMono, Location = new Point(390, 68), AutoSize = true };
            Controls.Add(lblEncabezado);

            lstAlquileres = new ListBox { Name = "lstAlquileres", Font = fuenteMono, Location = new Point(390, 90), Size = new Size(350, 230) };
            Controls.Add(lstAlquileres);

            lblSubtotal = CrearResultado("Subtotal", 390, 335, "lblSubtotal");
            lblDescuento = CrearResultado("Descuento", 390, 365, "lblDescuento");
            lblDomicilio = CrearResultado("Domicilio", 390, 395, "lblDomicilio");
            lblItbis = CrearResultado("ITBIS (18 %)", 390, 425, "lblItbis");
            lblTotal = CrearResultado("TOTAL A PAGAR", 390, 455, "lblTotal");
            lblTotal.Font = new Font(Font, FontStyle.Bold);

            btnCalcular = new Button { Name = "btnCalcular", Text = "Calcular total", Location = new Point(20, 440), Size = new Size(110, 40) };
            btnLimpiar = new Button { Name = "btnLimpiar", Text = "Nuevo alquiler", Location = new Point(140, 440), Size = new Size(110, 40) };
            btnSalir = new Button { Name = "btnSalir", Text = "Salir", Location = new Point(260, 440), Size = new Size(110, 40) };
            Controls.AddRange(new Control[] { btnCalcular, btnLimpiar, btnSalir });
        }

        private Label Etiqueta(string texto, int x, int y)
        {
            return new Label { Text = texto, Location = new Point(x, y), AutoSize = true };
        }

        // Crea el rótulo + el Label de resultado con formato RD$ 0.00
        private Label CrearResultado(string rotulo, int x, int y, string nombre)
        {
            Controls.Add(new Label { Text = rotulo, Location = new Point(x, y + 4), AutoSize = true });
            Label lbl = new Label
            {
                Name = nombre,
                Location = new Point(x + 130, y),
                Size = new Size(200, 24),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleRight
            };
            Controls.Add(lbl);
            return lbl;
        }

        // =====================================================
        //  PARTE II - EVENTOS
        // =====================================================

        // Load: valores iniciales y encabezado de columnas
        private void frmAlquiler_Load(object sender, EventArgs e)
        {
            dtpSalida.Value = DateTime.Now;
            lblEncabezado.Text = FormatearLinea("Días", "Vehículo", "Tarifa", "Total");
            ReiniciarResultados();
            lstAlquileres.Items.Clear();
            subtotalAcumulado = 0m;
            txtCliente.Focus();
        }

        // Agregar al alquiler
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarVehiculo(out decimal tarifaDigitada))
                return;

            int dias = (int)nudDias.Value;
            decimal tarifaDiaria = CalcularTarifaDiaria(tarifaDigitada);
            decimal totalLinea = tarifaDiaria * dias;

            lstAlquileres.Items.Add(FormatearLinea(
                dias.ToString(),
                $"{txtVehiculo.Text.Trim()} ({ObtenerEtiquetaSeguro()})",
                tarifaDiaria.ToString("N2", CultureInfo.InvariantCulture),
                totalLinea.ToString("N2", CultureInfo.InvariantCulture)));

            subtotalAcumulado += totalLinea;
            lblSubtotal.Text = Moneda(subtotalAcumulado);

            // Reiniciar solo los controles del vehículo
            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 1;
            rbtBasico.Checked = true;
            chkGps.Checked = false;
            txtVehiculo.Focus();
        }

        // Calcular total
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstAlquileres.Items.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un vehículo antes de calcular.",
                    "Sin vehículos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal descuento = chkCorporativo.Checked
                ? subtotalAcumulado * PORCENTAJE_DESCUENTO_CORPORATIVO : 0m;
            decimal domicilio = rbtDomicilio.Checked ? COSTO_DOMICILIO : 0m;
            decimal baseImponible = subtotalAcumulado - descuento + domicilio;
            decimal itbis = baseImponible * PORCENTAJE_ITBIS;
            decimal total = baseImponible + itbis;

            lblSubtotal.Text = Moneda(subtotalAcumulado);
            lblDescuento.Text = Moneda(descuento);
            lblDomicilio.Text = Moneda(domicilio);
            lblItbis.Text = Moneda(itbis);
            lblTotal.Text = Moneda(total);
        }

        // Nuevo alquiler
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            chkCorporativo.Checked = false;
            dtpSalida.Value = DateTime.Now;
            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 1;
            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;
            chkGps.Checked = false;
            lstAlquileres.Items.Clear();
            subtotalAcumulado = 0m;
            ReiniciarResultados();
            txtCliente.Focus();
        }

        // Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Close();
        }

        // =====================================================
        //  MÉTODOS AUXILIARES
        // =====================================================

        // Regla 1: tarifa diaria = tarifa + 300 (seguro completo) + 100 (GPS)
        private decimal CalcularTarifaDiaria(decimal tarifaBase)
        {
            decimal tarifa = tarifaBase;
            if (rbtCompleto.Checked) tarifa += RECARGO_SEGURO_COMPLETO;
            if (chkGps.Checked) tarifa += RECARGO_GPS;
            return tarifa;
        }

        private string ObtenerEtiquetaSeguro()
        {
            if (rbtCompleto.Checked && chkGps.Checked) return "Completo+GPS";
            if (rbtCompleto.Checked) return "Completo";
            if (chkGps.Checked) return "GPS";
            return "Básico";
        }

        // Validaciones de cliente, vehículo y tarifa
        private bool ValidarVehiculo(out decimal tarifa)
        {
            tarifa = 0m;

            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Digite el nombre del cliente.", "Dato requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtVehiculo.Text))
            {
                MessageBox.Show("Digite el nombre del vehículo.", "Dato requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVehiculo.Focus();
                return false;
            }
            if (!decimal.TryParse(txtTarifa.Text.Trim(), NumberStyles.Number,
                    CultureInfo.InvariantCulture, out tarifa) || tarifa <= 0)
            {
                MessageBox.Show("La tarifa debe ser un número mayor que cero.", "Tarifa inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTarifa.Focus();
                txtTarifa.SelectAll();
                return false;
            }
            return true;
        }

        // Da formato de columnas con PadRight/PadLeft
        private string FormatearLinea(string dias, string vehiculo, string tarifa, string total)
        {
            return dias.PadRight(ANCHO_DIAS)
                 + vehiculo.PadRight(ANCHO_VEHICULO)
                 + tarifa.PadLeft(ANCHO_TARIFA)
                 + total.PadLeft(ANCHO_TOTAL);
        }

        private string Moneda(decimal valor)
        {
            return FORMATO_MONEDA + valor.ToString("N2", CultureInfo.InvariantCulture);
        }

        private void ReiniciarResultados()
        {
            string cero = Moneda(0m);
            lblSubtotal.Text = cero;
            lblDescuento.Text = cero;
            lblDomicilio.Text = cero;
            lblItbis.Text = cero;
            lblTotal.Text = cero;
        }
    }
}