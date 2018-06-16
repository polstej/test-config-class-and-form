namespace test_config_class_and_form
{
    partial class MainForm
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
            this.btnCheckReport = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckReport
            // 
            this.btnCheckReport.Location = new System.Drawing.Point(22, 27);
            this.btnCheckReport.Name = "btnCheckReport";
            this.btnCheckReport.Size = new System.Drawing.Size(197, 129);
            this.btnCheckReport.TabIndex = 0;
            this.btnCheckReport.Text = "Check Report";
            this.btnCheckReport.UseVisualStyleBackColor = true;
            this.btnCheckReport.Click += new System.EventHandler(this.btnCheckReport_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(22, 193);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(197, 115);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 459);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnCheckReport);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckReport;
        private System.Windows.Forms.Button btnSettings;
    }
}