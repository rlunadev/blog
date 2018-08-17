using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Models
{
  public class Usuario
  {
    public virtual Guid Id {get;set;}
    public virtual string Nombre { get; set; }
    public virtual string Apellidos { get; set; }
    public virtual int Estado { get; set; }
    public virtual string NombreUsuario { get; set; }
    public virtual string Password { get; set; }
  }
}
