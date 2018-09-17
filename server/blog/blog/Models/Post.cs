using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Models
{
  public class Post
  {
    public virtual Guid Id {get;set;}
    public virtual string Titulo { get; set; }
    public virtual string Contenido { get; set; }
    public virtual Guid CategoriaId { get; set; }
    public virtual DateTime Fecha { get; set; }
    public virtual UsuarioPerfil PerfilUsuario { get; set;   }
  }
}
