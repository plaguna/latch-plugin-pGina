using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace latch_plugin_pGina
{
    class Util
    {
        internal static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        internal static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        internal static string GetSettingsString(string o)
        {
            // We can increase security adding some entropy but we are not that paranoid, are we? :)
            return Util.GetString(ProtectedData.Unprotect(Util.GetBytes((string)o), null, DataProtectionScope.LocalMachine));
        }

        internal static string SetSettingsString(string setting)
        {
            return Util.GetString(ProtectedData.Protect(Util.GetBytes(setting), null, DataProtectionScope.LocalMachine));
        }
    }
}
