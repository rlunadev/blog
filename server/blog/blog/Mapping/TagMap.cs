using blog.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Mapping
{
    public class TagMap : ClassMap<Tag>
    {
      public TagMap()
      {
        Id(x => x.Id);
        Map(x => x.Nombre);
        Table("Tags");
      }
    }
}
