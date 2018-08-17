using blog.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Mapping
{
    public class UsuarioMap : ClassMap<Categoria>
    {
      public UsuarioMap()
      {
        Id(x => x.Id);
        Map(x => x.Titulo);
        Map(x => x.Texto);
        Map(x => x.Fecha);
        Map(x => x.Estado);
        Table("Categorias");
      }
    }
}
