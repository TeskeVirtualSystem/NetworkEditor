using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
