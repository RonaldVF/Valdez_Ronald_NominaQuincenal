namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Constantes
        private const int HORAS_REGULARES_MAX = 88;
        private const int HORAS_MAXIMAS = 120;
        private const int HORAS_MINIMAS = 1;
        private const double FACTOR_EXTRA = 1.35;
        private const double INCENTIVO_TRANSPORTE = 1500.0;
        private const double TASA_AFP = 0.0287;
        private const double TASA_SFS = 0.0304;
        private const double TARIFA_AUXILIAR = 180.0;
        private const double TARIFA_TECNICO = 250.0;
        private const double TARIFA_SUPERVISOR = 350.0;
        private const double TARIFA_GERENTE = 500.0;

        // Acumuladores de resultados
        private int totalEmpleados = 0;
        private double acumBruto = 0.0;
        private double acumDeducciones = 0.0;
        private double acumNeto = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void LimpiarEtiquetasResumen()
        {
            lblEmpleados.Text = "";
            lblBruto.Text = "";
            lblDeducciones.Text = "";
            lblNeto.Text = "";
        }

        private double ObtenerTarifa(string cargo)
        {
            switch (cargo)
            {
                case "Auxiliar":
                    return TARIFA_AUXILIAR;
                case "Tecnico":
                    return TARIFA_TECNICO;
                case "Supervisor":
                    return TARIFA_SUPERVISOR;
                case "Gerente":
                    return TARIFA_GERENTE;
                default:
                    return 0.0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.Items.Clear();
            cmbCargo.Items.Add("Auxiliar");
            cmbCargo.Items.Add("Tecnico");
            cmbCargo.Items.Add("Supervisor");
            cmbCargo.Items.Add("Gerente");
            cmbCargo.SelectedIndex = -1;

            rdbFijo.Checked = true;
            rdbTemporal.Checked = false;
            chkTransporte.Checked = false;

            LimpiarEtiquetasResumen();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtEmpleado.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe ingresar el nombre del empleado.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpleado.Focus();
                return;
            }

            if (!rdbFijo.Checked && !rdbTemporal.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de contrato.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cargo.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCargo.Focus();
                return;
            }

            if (!int.TryParse(txtHoras.Text.Trim(), out int horas) || horas < HORAS_MINIMAS || horas > HORAS_MAXIMAS)
            {
                MessageBox.Show("Ingrese una cantidad entera de horas entre 1 y 120.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoras.Focus();
                return;
            }

            string cargo = cmbCargo.SelectedItem.ToString();
            double tarifa = ObtenerTarifa(cargo);

            int horasNormales;
            int horasExtra;

            if (horas <= HORAS_REGULARES_MAX)
            {
                horasNormales = horas;
                horasExtra = 0;
            }
            else
            {
                horasNormales = HORAS_REGULARES_MAX;
                horasExtra = horas - HORAS_REGULARES_MAX;
            }

            double salarioRegular = horasNormales * tarifa;
            double pagoExtra = horasExtra * tarifa * FACTOR_EXTRA;

            double incentivo;
            if (chkTransporte.Checked)
            {
                incentivo = INCENTIVO_TRANSPORTE;
            }
            else
            {
                incentivo = 0.0;
            }

            double bruto = salarioRegular + pagoExtra + incentivo;

            double deducciones = 0.0;
            if (rdbFijo.Checked)
            {
                deducciones = (salarioRegular + pagoExtra) * (TASA_AFP + TASA_SFS);
            }

            double neto = bruto - deducciones;

            totalEmpleados++;
            acumBruto += bruto;
            acumDeducciones += deducciones;
            acumNeto += neto;

            lstNomina.Items.Add($"{nombre} · {cargo} · RD$ {neto:N2}");
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            if (totalEmpleados == 0)
            {
                MessageBox.Show("No hay empleados registrados para mostrar el resumen.", "Resumen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lblEmpleados.Text = totalEmpleados.ToString();
            lblBruto.Text = $"RD$ {acumBruto:N2}";
            lblDeducciones.Text = $"RD$ {acumDeducciones:N2}";
            lblNeto.Text = $"RD$ {acumNeto:N2}";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEmpleado.Clear();
            txtHoras.Clear();
            rdbFijo.Checked = true;
            rdbTemporal.Checked = false;
            cmbCargo.SelectedIndex = -1;
            chkTransporte.Checked = false;
            txtEmpleado.Focus();
            lblNeto.Text = "";
            lblDeducciones.Text = "";
            lblBruto.Text = "";
            lblEmpleados.Text = "";
            lstNomina.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
