using blog.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Mapping
{
    public class UsuarioPerfilMap : ClassMap<UsuarioPerfil>
    {
      public UsuarioPerfilMap()
      {
        Id(x => x.Id);
        Map(x => x.Foto);
        Map(x => x.Descripcion);
        Map(x => x.Usuario);
      //References(x => x.Usuario)
      //  .Column("UsuarioId");

      Table("UsuarioPerfil");
      }
    }
}
