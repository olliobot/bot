using System.Collections.Generic;
using ConfigModels = Ollio.Common.Models.Config;

namespace Ollio.State
{
    public class ConfigState
    {
        public static List<ConfigModels.Bot> Bots { get; set; }

        public static void Set(ConfigModels.Root configRoot)
        {
            Bots = configRoot.Bots;
        }
    }
}
