using blog.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Mapping
{
    public class CategoriaMap : ClassMap<Categoria>
    {
      public CategoriaMap()
      {
        Id(x => x.Id);
        Map(x => x.Titulo);
        Map(x => x.Texto);
        Map(x => x.Fecha);
        Map(x => x.Estado);
      References(x => x.Usuario)
        .Column("UsuarioId")
        .Cascade.All();

        Table("Categorias");
      }
    }
}
