using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Models
{
  public class PostsTags
  {
    public virtual Guid Id {get;set;}
    public virtual Post Post { get; set; }
    public virtual Tag Tag { get; set; }
  }
}
