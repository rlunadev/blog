using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Models
{
  public class UsuarioPerfil
  {
    public virtual Guid Id { get; set; }
    public virtual Usuario Usuario { get; set; }
    public virtual byte Foto { get; set; }
    public virtual string Descripcion { get; set; }
  }
}
