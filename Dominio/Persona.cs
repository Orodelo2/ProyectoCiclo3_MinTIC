using System.ComponentModel.DataAnnotations;
namespace Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        //[Required(ErrorMessage ="Campo requerido")]
        public string Nombre { get; set; }
        //[Required(ErrorMessage ="Campo requerido")]
        public string Apellido { get; set; }
        //[Required(ErrorMessage ="Campo requerido")]
        public string Edad { get; set; }
        //[Required(ErrorMessage ="Campo requerido")]
        public string TipoDocumento { get; set; }
        //[Required(ErrorMessage ="Campo requerido")]
        public int NumeroDocumento { get; set; }
        //[Required(ErrorMessage ="Campo requerido")]
        public string Telefono { get; set; }
        //[Required(ErrorMessage ="Campo requerido")]
        public string Correo { get; set; }
    }
}