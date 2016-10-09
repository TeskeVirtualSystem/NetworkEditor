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
using System.Windows.Forms;

namespace NetworkEditor {
  public partial class AboutDialog : Form {
    public AboutDialog() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      Close();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      System.Diagnostics.Process.Start(linkLabel1.Text);
    }
  }
}
