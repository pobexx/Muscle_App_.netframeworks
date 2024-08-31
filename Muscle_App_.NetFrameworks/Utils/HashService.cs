using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Muscle_App_.NetFrameworks.Utils.WebConfigAppSettings;
using System.Web;

namespace Muscle_App_.NetFrameworks.Utils
{
    public static class HashService
    {
        public static class Algorithm
        {
            public const string SHA256 = "SHA256";
            public const string SHA512 = "SHA512";
            public const string SHA384 = "SHA384";
            public const string SHA1 = "SHA1";
        }

        public static class DefaultValues
        {
            public const string SALT = "okw8c9av";
            public const int STREACH = 8;
        }
        public static string GetHashForPassword(string password)
        {
            return ComputeHashAndStretch(
                Algorithm.SHA256,
                password,
                SettingValues.Salt,
                SettingValues.Streach);
        }
        public static string ComputeHash(string algorithm, byte[] data)
        {
            HashAlgorithm sha;
            switch (algorithm)
            {
                case Algorithm.SHA256:
                    sha = new SHA256Managed();
                    break;
                case Algorithm.SHA512:
                    sha = new SHA512Managed();
                    break;
                case Algorithm.SHA384:
                    sha = new SHA384Managed();
                    break;
                case Algorithm.SHA1:
                    sha = new SHA1Managed();
                    break;
                default:
                    sha = new SHA256Managed();
                    break;
            }

            byte[] bs = sha.ComputeHash(data);
            return BitConverter.ToString(bs).ToLower().Replace("-", string.Empty);
        }

        public static string ComputeHash(string algorithm, string str)
        {
            byte[] data = Encoding.UTF8.GetBytes(str);
            return ComputeHash(algorithm, data);
        }

        public static string ComputeHashAndStretch(string algorithm, string str, string salt, int loop)
        {
            //if(string.IsNullOrEmpty(salt))
            //{

            //}
            string result = string.Empty;
            while (loop-- > 0)
            {
                result = ComputeHash(algorithm, result + str + salt);
            }
            return result;
        }
    }
}