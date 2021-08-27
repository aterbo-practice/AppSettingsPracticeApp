using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSettingsPractice.Objects
{
    public class SubSettingsObject
    {
        public string SubLevelString { get; set; }
        public int SubLevelInt { get; set; }
        public bool SubLevelBool { get; set; }
        public List<string> SubLevelStringList { get; set; }

    }
}
