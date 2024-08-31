using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static System.Configuration.ConfigurationManager;

namespace Muscle_App_.NetFrameworks.Utils.WebConfigAppSettings
{
    public static class SettingValueAccessTool
    {

        public static int GetIntSafely(string key, int defaultValue)
        {
            int value;
            return Int32.TryParse(AppSettings[key], out value)
                ? value
                : defaultValue;
        }
        public static bool GetBoolSafely(string key)
        {
            var value = AppSettings[key];
            if (string.IsNullOrWhiteSpace(value))
                return false;
            return value.ToLower() == "true";
        }

        public static string GetStringSafely(string key, string defaultValue)
        {
            var value = AppSettings[key];
            return string.IsNullOrEmpty(value)
                ? defaultValue
                : value;
        }

    }
}