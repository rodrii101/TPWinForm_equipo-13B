using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionComercio
{
    public class Articulo
    {
        public int Id { get; set; }
        [DisplayName("Código de artículo")]
        public string Codigo { get; set; }
        public string  Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public List<Imagenes> Imagenes { get; set; } = new List<Imagenes>();
        public decimal Precio { get; set; }

    }
}
