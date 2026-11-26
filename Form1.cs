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
    }
}
