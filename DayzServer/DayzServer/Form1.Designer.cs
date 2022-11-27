﻿namespace DayzServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dayzExePath = new System.Windows.Forms.TextBox();
            this.modPath = new System.Windows.Forms.TextBox();
            this.DayzExeDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.DayzExeButton = new System.Windows.Forms.Button();
            this.PathButton = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.DayZFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.launchParamBox = new System.Windows.Forms.TextBox();
            this.lauchParamLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dayzExePath
            // 
            this.dayzExePath.Location = new System.Drawing.Point(120, 41);
            this.dayzExePath.Name = "dayzExePath";
            this.dayzExePath.Size = new System.Drawing.Size(270, 23);
            this.dayzExePath.TabIndex = 3;
            // 
            // modPath
            // 
            this.modPath.Location = new System.Drawing.Point(120, 70);
            this.modPath.Name = "modPath";
            this.modPath.ReadOnly = true;
            this.modPath.Size = new System.Drawing.Size(270, 23);
            this.modPath.TabIndex = 4;
            this.modPath.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DayzExeDialog
            // 
            this.DayzExeDialog.FileName = "DayzExeDialog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "DayZ_x64.exe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mods Directory";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalExtent = 1;
            this.checkedListBox1.Location = new System.Drawing.Point(13, 222);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(400, 220);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 7;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(154, 193);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 23);
            this.searchBox.TabIndex = 8;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // DayzExeButton
            // 
            this.DayzExeButton.Location = new System.Drawing.Point(393, 40);
            this.DayzExeButton.Name = "DayzExeButton";
            this.DayzExeButton.Size = new System.Drawing.Size(28, 23);
            this.DayzExeButton.TabIndex = 9;
            this.DayzExeButton.Text = "~";
            this.DayzExeButton.UseVisualStyleBackColor = true;
            this.DayzExeButton.Click += new System.EventHandler(this.DayzExeButton_Click);
            // 
            // PathButton
            // 
            this.PathButton.Location = new System.Drawing.Point(393, 72);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(25, 23);
            this.PathButton.TabIndex = 10;
            this.PathButton.Text = "~";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(106, 196);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(42, 15);
            this.SearchLabel.TabIndex = 11;
            this.SearchLabel.Text = "Search";
            // 
            // launchParamBox
            // 
            this.launchParamBox.Location = new System.Drawing.Point(120, 108);
            this.launchParamBox.Name = "launchParamBox";
            this.launchParamBox.Size = new System.Drawing.Size(270, 23);
            this.launchParamBox.TabIndex = 12;
            // 
            // lauchParamLabel
            // 
            this.lauchParamLabel.AutoSize = true;
            this.lauchParamLabel.Location = new System.Drawing.Point(6, 111);
            this.lauchParamLabel.Name = "lauchParamLabel";
            this.lauchParamLabel.Size = new System.Drawing.Size(108, 15);
            this.lauchParamLabel.TabIndex = 13;
            this.lauchParamLabel.Text = "Launch Parameters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 494);
            this.Controls.Add(this.lauchParamLabel);
            this.Controls.Add(this.launchParamBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.PathButton);
            this.Controls.Add(this.DayzExeButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modPath);
            this.Controls.Add(this.dayzExePath);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "DayZ Server Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox dayzExePath;
        private TextBox modPath;
        private OpenFileDialog DayzExeDialog;
        private Label label1;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private TextBox searchBox;
        private Button DayzExeButton;
        private Button PathButton;
        private Label SearchLabel;
        private FolderBrowserDialog DayZFolderBrowser;
        private TextBox launchParamBox;
        private Label lauchParamLabel;
    }
}