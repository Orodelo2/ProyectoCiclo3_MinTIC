namespace Dominio
{
    public class Directivo : Persona
    {
        public int IdDirectivo { get; set; }
        public string Categoria { get; set; }
        public int CantidadEmpleados { get; set; }
        public int Salario { get; set; }
    
    }
}