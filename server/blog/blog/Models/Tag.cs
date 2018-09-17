using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Models
{
  public class Tag
  {
    public virtual Guid Id {get;set;}
    public virtual string Nombre { get; set; }
  }
}
