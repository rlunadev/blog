using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace blog
{
  static class ConfigurationManager
  {
    public static IConfiguration AppSetting { get; }
    static ConfigurationManager()
    {
      AppSetting = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appconfig.json")
              .Build();
    }
  }
}
