using blog.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Mapping
{
    public class PostTagsMap : ClassMap<PostsTags>
    {
      public PostTagsMap()
      {
        Id(x => x.Id);
        Map(x => x.Post);
        Map(x => x.Tag);
        Table("PostTags");
      }
    }
}
