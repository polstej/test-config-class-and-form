namespace test_config_class_and_form
{
    partial class ConfigurationForm
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
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtTechnique = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComparison = new System.Windows.Forms.TextBox();
            this.lblComparison = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtImpression = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(32, 208);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(256, 29);
            this.txtBody.TabIndex = 2;
            this.txtBody.TextChanged += new System.EventHandler(this.txtBody_TextChanged);
            // 
            // txtTechnique
            // 
            this.txtTechnique.Location = new System.Drawing.Point(32, 37);
            this.txtTechnique.Name = "txtTechnique";
            this.txtTechnique.Size = new System.Drawing.Size(250, 29);
            this.txtTechnique.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Keyword for Body of report (include punctuation like \"RESULT:\")";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Keyword to find Study Type (such as TECHNIQUE:\")";
            // 
            // txtComparison
            // 
            this.txtComparison.Location = new System.Drawing.Point(32, 115);
            this.txtComparison.Name = "txtComparison";
            this.txtComparison.Size = new System.Drawing.Size(244, 29);
            this.txtComparison.TabIndex = 1;
            // 
            // lblComparison
            // 
            this.lblComparison.AutoSize = true;
            this.lblComparison.Location = new System.Drawing.Point(34, 87);
            this.lblComparison.Name = "lblComparison";
            this.lblComparison.Size = new System.Drawing.Size(525, 25);
            this.lblComparison.TabIndex = 7;
            this.lblComparison.Text = "Keyword for Comparison Dates (such as COMPARISON:\")";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(39, 494);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(211, 116);
            this.btnSaveSettings.TabIndex = 4;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // txtImpression
            // 
            this.txtImpression.Location = new System.Drawing.Point(31, 301);
            this.txtImpression.Name = "txtImpression";
            this.txtImpression.Size = new System.Drawing.Size(245, 29);
            this.txtImpression.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Keyword for Impression (such as \"IMPRESSION:\")";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(336, 511);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 73);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ConfigurationForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 825);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImpression);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.lblComparison);
            this.Controls.Add(this.txtComparison);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTechnique);
            this.Controls.Add(this.txtBody);
            this.Name = "ConfigurationForm";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigurationForm_FormClosed);
            this.Load += new System.EventHandler(this.ConfigurationFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtTechnique;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComparison;
        private System.Windows.Forms.Label lblComparison;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtImpression;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
    }
}

