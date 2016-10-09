namespace NetworkEditor {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.label1 = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.reloadNetworksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.networkProfileBox = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.saveButton = new System.Windows.Forms.Button();
      this.networkCategoryBox = new System.Windows.Forms.ComboBox();
      this.networkProfileNameBox = new System.Windows.Forms.TextBox();
      this.networkDescriptionBox = new System.Windows.Forms.TextBox();
      this.networkCreatedLabel = new System.Windows.Forms.Label();
      this.networkLastConnectedLabel = new System.Windows.Forms.Label();
      this.networkList = new System.Windows.Forms.ListBox();
      this.menuStrip1.SuspendLayout();
      this.networkProfileBox.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(66, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Network List";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(577, 24);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadNetworksToolStripMenuItem,
            this.closeToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // reloadNetworksToolStripMenuItem
      // 
      this.reloadNetworksToolStripMenuItem.Name = "reloadNetworksToolStripMenuItem";
      this.reloadNetworksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
      this.reloadNetworksToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
      this.reloadNetworksToolStripMenuItem.Text = "Reload Networks";
      this.reloadNetworksToolStripMenuItem.Click += new System.EventHandler(this.reloadNetworksToolStripMenuItem_Click);
      // 
      // closeToolStripMenuItem
      // 
      this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
      this.closeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
      this.closeToolStripMenuItem.Text = "Close";
      this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.aboutToolStripMenuItem.Text = "Help";
      // 
      // aboutToolStripMenuItem1
      // 
      this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
      this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
      this.aboutToolStripMenuItem1.Text = "About";
      this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // networkProfileBox
      // 
      this.networkProfileBox.Controls.Add(this.tableLayoutPanel1);
      this.networkProfileBox.Location = new System.Drawing.Point(202, 42);
      this.networkProfileBox.Name = "networkProfileBox";
      this.networkProfileBox.Size = new System.Drawing.Size(365, 290);
      this.networkProfileBox.TabIndex = 3;
      this.networkProfileBox.TabStop = false;
      this.networkProfileBox.Text = "No Selected Profile";
      this.networkProfileBox.Visible = false;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
      this.tableLayoutPanel1.Controls.Add(this.saveButton, 1, 6);
      this.tableLayoutPanel1.Controls.Add(this.networkCategoryBox, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.networkProfileNameBox, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.networkDescriptionBox, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.networkCreatedLabel, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.networkLastConnectedLabel, 1, 5);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 7;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 265);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 23);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(99, 35);
      this.label2.TabIndex = 0;
      this.label2.Text = "Category:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 58);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(99, 35);
      this.label3.TabIndex = 1;
      this.label3.Text = "Profile Name:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 93);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(99, 35);
      this.label4.TabIndex = 2;
      this.label4.Text = "Description";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label5
      // 
      this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(3, 128);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(99, 35);
      this.label5.TabIndex = 3;
      this.label5.Text = "Created:";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label6
      // 
      this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(3, 163);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(99, 35);
      this.label6.TabIndex = 4;
      this.label6.Text = "Last Connected:";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // saveButton
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.saveButton, 2);
      this.saveButton.Location = new System.Drawing.Point(3, 236);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(347, 25);
      this.saveButton.TabIndex = 5;
      this.saveButton.Text = "Save";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // networkCategoryBox
      // 
      this.networkCategoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.networkCategoryBox.FormattingEnabled = true;
      this.networkCategoryBox.Items.AddRange(new object[] {
            "Public Network",
            "Private Network",
            "Domain Network"});
      this.networkCategoryBox.Location = new System.Drawing.Point(108, 26);
      this.networkCategoryBox.Name = "networkCategoryBox";
      this.networkCategoryBox.Size = new System.Drawing.Size(242, 21);
      this.networkCategoryBox.TabIndex = 6;
      // 
      // networkProfileNameBox
      // 
      this.networkProfileNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.networkProfileNameBox.Location = new System.Drawing.Point(108, 61);
      this.networkProfileNameBox.Name = "networkProfileNameBox";
      this.networkProfileNameBox.Size = new System.Drawing.Size(242, 21);
      this.networkProfileNameBox.TabIndex = 7;
      // 
      // networkDescriptionBox
      // 
      this.networkDescriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.networkDescriptionBox.Location = new System.Drawing.Point(108, 96);
      this.networkDescriptionBox.Name = "networkDescriptionBox";
      this.networkDescriptionBox.Size = new System.Drawing.Size(242, 21);
      this.networkDescriptionBox.TabIndex = 8;
      // 
      // networkCreatedLabel
      // 
      this.networkCreatedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.networkCreatedLabel.AutoSize = true;
      this.networkCreatedLabel.Location = new System.Drawing.Point(108, 128);
      this.networkCreatedLabel.Name = "networkCreatedLabel";
      this.networkCreatedLabel.Size = new System.Drawing.Size(242, 35);
      this.networkCreatedLabel.TabIndex = 9;
      this.networkCreatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // networkLastConnectedLabel
      // 
      this.networkLastConnectedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.networkLastConnectedLabel.AutoSize = true;
      this.networkLastConnectedLabel.Location = new System.Drawing.Point(108, 163);
      this.networkLastConnectedLabel.Name = "networkLastConnectedLabel";
      this.networkLastConnectedLabel.Size = new System.Drawing.Size(242, 35);
      this.networkLastConnectedLabel.TabIndex = 10;
      this.networkLastConnectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // networkList
      // 
      this.networkList.FormattingEnabled = true;
      this.networkList.Location = new System.Drawing.Point(15, 42);
      this.networkList.Name = "networkList";
      this.networkList.Size = new System.Drawing.Size(181, 290);
      this.networkList.TabIndex = 0;
      this.networkList.SelectedIndexChanged += new System.EventHandler(this.networkList_SelectedIndexChanged);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.ClientSize = new System.Drawing.Size(577, 344);
      this.Controls.Add(this.networkList);
      this.Controls.Add(this.networkProfileBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = global::NetworkEditor.Resources.logoTVS_480;
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.Text = "Network Editor";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.networkProfileBox.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem reloadNetworksToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    private System.Windows.Forms.GroupBox networkProfileBox;
    private System.Windows.Forms.ListBox networkList;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.ComboBox networkCategoryBox;
    private System.Windows.Forms.TextBox networkProfileNameBox;
    private System.Windows.Forms.TextBox networkDescriptionBox;
    private System.Windows.Forms.Label networkCreatedLabel;
    private System.Windows.Forms.Label networkLastConnectedLabel;
  }
}

