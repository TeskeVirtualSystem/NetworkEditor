using Microsoft.Win32;

namespace NetworkEditor {
  public static class Utils {
    public static void WriteReg(string SubKey, string KeyName, object Value) {
      RegistryKey rk = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
      RegistryKey sk1 = rk.CreateSubKey(SubKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
      sk1.SetValue(KeyName.ToUpper(), Value);
    }
    public static object ReadReg(string SubKey, string KeyName) {
      RegistryKey rk = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
      RegistryKey sk1 = rk.OpenSubKey(SubKey);
      return sk1.GetValue(KeyName);
    }
    public static string[] ReadSubkeysName(string SubKey) {
      RegistryKey rk = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
      RegistryKey sk1 = rk.OpenSubKey(SubKey);
      return sk1.GetSubKeyNames();
    }
  }
}
