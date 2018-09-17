using blog.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Mapping
{
    public class PostMap : ClassMap<Post>
    {
      public PostMap()
      {
        Id(x => x.Id);
        Map(x => x.Titulo);
        Map(x => x.Contenido);
        Map(x => x.CategoriaId);
        Map(x => x.Fecha);
        Map(x => x.PerfilUsuario);
        Table("Posts");
      }
    }
}
