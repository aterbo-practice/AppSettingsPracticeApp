using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppSettingsPractice.Objects;

namespace AppSettingsPractice.Pages
{
    public class MainSettingsObject
    {
        public string MainLevelString { get; set; }
        public SubSettingsObject SubLevel { get; set; }
    }
}
