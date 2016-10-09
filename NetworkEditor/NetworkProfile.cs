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

using System;
using System.Collections.Generic;
using System.Linq;

namespace NetworkEditor {
  public class NetworkProfile {
    private readonly static string BaseRegistryPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles";
    public string ProfileKeyId { get; private set; }
    public NetworkCategory Category { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateLastConnected { get; set; }
    public string Description { get; set; }
    public int Managed { get; set; }
    public int NameType { get; set; }
    public string ProfileName { get; set; }

    public NetworkProfile(string profileKeyId) {
      ProfileKeyId = profileKeyId;
      Category = (NetworkCategory) Utils.ReadReg(BaseRegistryPath + "\\" + ProfileKeyId, "Category");
      byte[] dateCreatedBin = (byte[])Utils.ReadReg(BaseRegistryPath + "\\" + ProfileKeyId, "DateCreated");
      DateCreated = UnpackDateTime(dateCreatedBin);
      byte[] dateLastConnectedBin = (byte[])Utils.ReadReg(BaseRegistryPath + "\\" + ProfileKeyId, "DateLastConnected");
      DateLastConnected = UnpackDateTime(dateLastConnectedBin);
      Description = (string)Utils.ReadReg(BaseRegistryPath + "\\" + ProfileKeyId, "Description");
      Managed = (int)Utils.ReadReg(BaseRegistryPath + "\\" + ProfileKeyId, "Managed");
      NameType = (int)Utils.ReadReg(BaseRegistryPath + "\\" + ProfileKeyId, "NameType");
      ProfileName = (string)Utils.ReadReg(BaseRegistryPath + "\\" + ProfileKeyId, "ProfileName");
    }

    public void Save() {
      Utils.WriteReg(BaseRegistryPath + "\\" + ProfileKeyId, "Category", (int)Category);
      Utils.WriteReg(BaseRegistryPath + "\\" + ProfileKeyId, "ProfileName", ProfileName);
      Utils.WriteReg(BaseRegistryPath + "\\" + ProfileKeyId, "Description", Description);
    }

    private static DateTime UnpackDateTime(byte[] data) {
      int year = BitConverter.ToInt16(data, 0);
      int month = BitConverter.ToInt16(data, 2);
      // int ??? = BitConverter.ToInt16(data, 4); // Day of Week maybe?
      int day = BitConverter.ToInt16(data, 6);
      int hour = BitConverter.ToInt16(data, 8);
      int minutes = BitConverter.ToInt16(data, 10);
      int seconds = BitConverter.ToInt16(data, 12);
      return new DateTime(year, month, day, hour, minutes, seconds); 
    }

    public static List<NetworkProfile> ListNetworkProfiles() {
      return Utils.ReadSubkeysName(BaseRegistryPath).Select(a => new NetworkProfile(a)).ToList<NetworkProfile>();
    }
  }
}
