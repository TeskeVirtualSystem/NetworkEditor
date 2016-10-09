﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
