using blog.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Mapping
{
    public class UsuarioMap : ClassMap<Usuario>
    {
      public UsuarioMap()
      {
        Id(x => x.Id);
        Map(x => x.Nombre);
        Map(x => x.Apellidos);
        Map(x => x.Estado);
        Map(x => x.NombreUsuario);
        Map(x => x.Password);
      Table("Usuarios");
      }
    }
}
