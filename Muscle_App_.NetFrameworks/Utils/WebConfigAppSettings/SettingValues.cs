using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Muscle_App_.NetFrameworks.Utils.WebConfigAppSettings.SettingValueAccessTool;
using static Muscle_App_.NetFrameworks.Utils.HashService;

namespace Muscle_App_.NetFrameworks.Utils.WebConfigAppSettings
{
    public static class SettingValues
    {
        public static bool IsDevelopmentMode => GetBoolSafely(Keys.IS_DEVELOPMENT_MODE);

        public static string Salt => GetStringSafely(Keys.SALT, DefaultValues.SALT);
        public static int Streach => GetIntSafely(Keys.STREACH, DefaultValues.STREACH);
    }
}