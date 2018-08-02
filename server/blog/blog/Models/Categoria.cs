using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Models
{
  public class Categoria
  {
    public virtual Guid Id {get;set;}
    public virtual string Titulo { get; set; }
    public virtual string Texto { get; set; }
    public virtual DateTime Fecha { get; set; }
    public virtual int Estado { get; set; }
  }
}
