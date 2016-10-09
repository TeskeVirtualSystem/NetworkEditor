namespace NetworkEditor {
  partial class AboutDialog {
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
      this.tvsLogo = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.tvsLogo)).BeginInit();
      this.SuspendLayout();
      // 
      // tvsLogo
      // 
      this.tvsLogo.Image = global::NetworkEditor.Resources.logo_new_256;
      this.tvsLogo.Location = new System.Drawing.Point(101, 12);
      this.tvsLogo.Name = "tvsLogo";
      this.tvsLogo.Size = new System.Drawing.Size(256, 106);
      this.tvsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.tvsLogo.TabIndex = 0;
      this.tvsLogo.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(107, 135);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(245, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Network Editor by Teske Virtual System Ltda. - ME";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(119, 152);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(221, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Made by Lucas Teske and Shared as GPLv3";
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Location = new System.Drawing.Point(97, 177);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(265, 13);
      this.linkLabel1.TabIndex = 3;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "https://github.com/TeskeVirtualSystem/NetworkEditor";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(192, 237);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Close";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // AboutDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(459, 272);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tvsLogo);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = global::NetworkEditor.Resources.logoTVS_480;
      this.Name = "AboutDialog";
      this.Text = "About";
      ((System.ComponentModel.ISupportInitialize)(this.tvsLogo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox tvsLogo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.Button button1;
  }
}