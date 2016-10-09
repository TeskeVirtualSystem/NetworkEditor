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
using System.Windows.Forms;

namespace NetworkEditor {
  public partial class MainForm : Form {
    List<NetworkProfile> profiles;
    public MainForm() {
      InitializeComponent();
      profiles = NetworkProfile.ListNetworkProfiles();
      profiles.ForEach(a => networkList.Items.Add(a.ProfileName));
    }

    private void RefreshNetworkList() {
      networkList.Items.Clear();
      profiles = NetworkProfile.ListNetworkProfiles();
      profiles.ForEach(a => networkList.Items.Add(a.ProfileName));
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
      AboutDialog ad = new AboutDialog();
      ad.ShowDialog();
    }

    private void networkList_SelectedIndexChanged(object sender, EventArgs e) {
      if (networkList.SelectedIndex != -1) {
        networkProfileBox.Visible = true;
        NetworkProfile network = profiles[networkList.SelectedIndex];
        networkProfileBox.Text = network.ProfileName;
        networkCategoryBox.SelectedIndex = (int) network.Category;
        networkProfileNameBox.Text = network.ProfileName;
        networkCreatedLabel.Text = network.DateCreated.ToString();
        networkLastConnectedLabel.Text = network.DateLastConnected.ToString();
        networkDescriptionBox.Text = network.Description;
      }
    }

    private void saveButton_Click(object sender, EventArgs e) {
      if (networkProfileBox.Text.Length == 0) {
        MessageBox.Show("Profile name cannot be empty!");
        return;
      }

      NetworkProfile network = profiles[networkList.SelectedIndex];
      network.ProfileName = networkProfileBox.Text;
      network.Description = networkDescriptionBox.Text;
      network.Category = (NetworkCategory)networkCategoryBox.SelectedIndex;
      network.Save();
      MessageBox.Show("Network profile saved.\nYou may need to log-in and out again.");
    }

    private void reloadNetworksToolStripMenuItem_Click(object sender, EventArgs e) {
      RefreshNetworkList();
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
      Close();
    }
  }
}
