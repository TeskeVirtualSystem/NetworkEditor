///    Network Editor - Windows Network Category / Name Editor
///    Copyright (C) 2016 Lucas Teske
///
///    This program is free software: you can redistribute it and/or modify
///    it under the terms of the GNU General Public License as published by
///    the Free Software Foundation, either version 3 of the License, or
///    (at your option) any later version.
///
///    This program is distributed in the hope that it will be useful,
///    but WITHOUT ANY WARRANTY; without even the implied warranty of
///    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
///    GNU General Public License for more details.
///
///    You should have received a copy of the GNU General Public License
///    along with this program.  If not, see <http://www.gnu.org/licenses/>.

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
