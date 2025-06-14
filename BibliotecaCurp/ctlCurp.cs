namespace BibliotecaCurp
{
    public partial class ctlCurp : UserControl
    {
        private string curpGenerada;
        private List<string> estadosAbreviacion = new List<string>
        {
            "AS - Aguascalientes", "BC - Baja California", "BS - Baja California Sur", "CC - Campeche", "CL - Coahuila", "CM - Colima", "CS - Chiapas", "CH - Chihuahua", "DF - Ciudad de México", "DG - Durango", "GT - Guanajuato",
            "GR- Guerrero", "HG - Hidalgo", "JC - Jalisco", "MC - Estado de México", "MN - Michoacán", "MS - Morelos", "NT - Nayarit","NL - Nuevo León", "OC - Oaxaca", "PL - Puebla", "QT - Querétaro",
            "QR - Quintana Roo", "SP - San Luis Potosí", "SL- - Sinaloa", "SR - Sonora", "TC - Tabasco", "TS - Tamaulipas", "TL - Tlaxcala", "VZ - Veracruz", "YN - Yucatán", "ZS - Zacatecas"
        };
        public ctlCurp()
        {
            InitializeComponent();
            cboSexo.SelectedIndex = 0;
            cboEstado.DataSource = estadosAbreviacion;
        }

        public string CurpGenerada
        {
            get { return curpGenerada; }
            set { curpGenerada = value; }
        }

        public string Nombre
        {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value; }
        }

        public string PrimerApellido
        {
            get { return txtPrimerApellido.Text; }
            set { txtPrimerApellido.Text = value; }
        }

        public string SegundoApellido
        {
            get { return txtSegundoApellido.Text; }
            set { txtSegundoApellido.Text = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return dtpFechaNac.Value; }
            set { dtpFechaNac.Value = value; }
        }

        public string Genero
        {
            get { return cboSexo.SelectedItem.ToString(); }
            set { cboSexo.SelectedItem = value; }
        }

        public string Estado
        {
            get { return cboEstado.SelectedItem.ToString(); }
            set { cboEstado.SelectedItem = value; }
        }

        private void MostrarCurp()
        {
            lblCurpGenerada.Text = curpGenerada;
        }

        private void GenerarCurp()
        {
            if (string.IsNullOrWhiteSpace(PrimerApellido) || PrimerApellido.Length < 2 ||
                string.IsNullOrWhiteSpace(SegundoApellido) || SegundoApellido.Length < 1 ||
                string.IsNullOrWhiteSpace(Nombre) || Nombre.Length < 1)
            {
                curpGenerada = string.Empty;
                return;
            }

            string primerLetraApellido = PrimerApellido.Substring(0, 1).ToUpper();
            char primerVocal = PrimerApellido.Substring(1).ToUpper()
                .FirstOrDefault(c => "AEIOU".Contains(c));

            if (primerVocal == '\0') primerVocal = 'X';

            string primerLetraSegundoApellido = SegundoApellido.Substring(0, 1).ToUpper();
            string primerLetraNombre = Nombre.Substring(0, 1).ToUpper();

            string fechaNacimiento = FechaNacimiento.ToString("yyMMdd");
            string genero = (Genero == "Masculino") ? "H" : "M";


            string estado = "NE";
            if (!string.IsNullOrWhiteSpace(Estado) && Estado.Length >= 2)
                estado = Estado.Substring(0, 2).ToUpper();

            char primerApellidoConsonanteInterna = PrimerApellido.Substring(1).ToUpper()
                .FirstOrDefault(c => "BCDFGHJKLMNÑPQRSTVWXYZ".Contains(c));

            if (primerApellidoConsonanteInterna == '\0' || primerApellidoConsonanteInterna=='Ñ') primerApellidoConsonanteInterna = 'X';

            char segundoApellidoConsonanteInterna = SegundoApellido.Substring(1).ToUpper()
                .FirstOrDefault(c => "BCDFGHJKLMNÑPQRSTVWXYZ".Contains(c));

            if (segundoApellidoConsonanteInterna == '\0' || segundoApellidoConsonanteInterna=='Ñ') segundoApellidoConsonanteInterna = 'X';

            char nombresConsonanteInterna = Nombre.Substring(1).ToUpper()
                .FirstOrDefault(c => "BCDFGHJKLMNPQRSTVWXYZ".Contains(c));

            curpGenerada = $"{primerLetraApellido}{primerVocal}{primerLetraSegundoApellido}{primerLetraNombre}{fechaNacimiento}{genero}{estado}{primerApellidoConsonanteInterna}{segundoApellidoConsonanteInterna}{nombresConsonanteInterna}00";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            GenerarCurp();
            MostrarCurp();

        }

        private void txtPrimerApellido_TextChanged(object sender, EventArgs e)
        {
            GenerarCurp();
            MostrarCurp();
        }

        private void txtSegundoApellido_TextChanged(object sender, EventArgs e)
        {
            GenerarCurp();
            MostrarCurp();
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            GenerarCurp();
            MostrarCurp();
        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarCurp();
            MostrarCurp();
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarCurp();
            MostrarCurp();
        }
    }
}
