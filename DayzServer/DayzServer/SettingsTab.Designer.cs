namespace DayzServer
{
    partial class SettingsTab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dayzAsHiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.updateModCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayzAsHiddenCheckBox
            // 
            this.dayzAsHiddenCheckBox.AutoSize = true;
            this.dayzAsHiddenCheckBox.Location = new System.Drawing.Point(33, 66);
            this.dayzAsHiddenCheckBox.Name = "dayzAsHiddenCheckBox";
            this.dayzAsHiddenCheckBox.Size = new System.Drawing.Size(200, 19);
            this.dayzAsHiddenCheckBox.TabIndex = 0;
            this.dayzAsHiddenCheckBox.Text = "Launch DayzServer.exe as hidden";
            this.dayzAsHiddenCheckBox.UseVisualStyleBackColor = true;
            // 
            // updateModCheckBox
            // 
            this.updateModCheckBox.AutoSize = true;
            this.updateModCheckBox.Location = new System.Drawing.Point(33, 91);
            this.updateModCheckBox.Name = "updateModCheckBox";
            this.updateModCheckBox.Size = new System.Drawing.Size(164, 19);
            this.updateModCheckBox.TabIndex = 1;
            this.updateModCheckBox.Text = "Update mod from modlist";
            this.updateModCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "These options are experiemental and may cause unwanted behaviour";
            // 
            // SettingsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 151);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateModCheckBox);
            this.Controls.Add(this.dayzAsHiddenCheckBox);
            this.Name = "SettingsTab";
            this.Text = "Dayz-Server-Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox dayzAsHiddenCheckBox;
        private CheckBox updateModCheckBox;
        private Label label1;
    }
}