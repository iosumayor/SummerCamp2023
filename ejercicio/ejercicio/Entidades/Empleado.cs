namespace Entidades
{
    //public - Visible en todo el proyecto
    //private - No es visible
    //protected - 
    //internal
    public class Empleado
    {
        public enum Nivel
        {
            nomal,
            bueno,
            excelente
        }
        private Nivel _nivel;

        public void FijarNivel(Nivel nivel)
        {
            this._nivel = nivel;
        }

        public Empleado()
        {

        }

        public Empleado(string Nombre, double Salario, DateTime FechaAlta, bool Alta)
        {
            this.Nombre = Nombre;
            this.Salario = Salario;
            this.FechaAlta = FechaAlta;
            this.Alta = Alta;
        }

        public string Nombre { get; set; }

        public double Salario { get; set; }

        public DateTime FechaAlta { get; set; } = DateTime.Now;

        public bool Alta { get; set; }

        public void CalcularAumentoSlario()
        {
            throw new NotImplementedException();
        }

    }
}
