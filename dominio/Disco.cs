using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Disco
    {
        public int Id { get; set; }

        [DisplayName("Título")]
        public string Titulo { get; set; }

        public DateTime Fecha { get; set; }

        [DisplayName("Cantidad de canciones")]
        public int CantidadCanciones { get; set; }

        public string UrlImagen { get; set; }

        [DisplayName("Género")]
        public Estilo Genero { get; set; }
        
        public Edicion Formato { get; set; }
    }
}
