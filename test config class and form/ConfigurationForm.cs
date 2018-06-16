using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace test_config_class_and_form
{
    public partial class ConfigurationForm  : Form
    {

        public ConfigurationForm()
        {
            InitializeComponent();


        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void ConfigurationFrom_Load(object sender, EventArgs e)
        {
            //if settings file exists then prepopulate text fields in for form

            if (FileClerk.CheckIFSettingsFileExist())
            {
                //read text from file and put in known fields
                //indexes are the known order
                //alternative in future: could use key/value settings
                //so order won't matter
                string[] settings = FileClerk.ReadConfigurationFile();
                txtTechnique.Text = settings[0];
                txtComparison.Text = settings[1];
                txtBody.Text = settings[2];
                txtImpression.Text = settings[3];
            }     

        }

        private void txtBody_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            //data 'validation'..must add more eventually. this only
            //checks for empty fields
            if (txtBody.Text!=""& txtComparison.Text!=""
                &txtImpression.Text!="" & txtTechnique.Text!="")
            {
                //save to config file
                FileClerk.SaveToConfigurationFile(txtTechnique.Text,
                    txtComparison.Text, txtBody.Text, txtImpression.Text);
                this.Close();
                
            }
            else
            {
                MessageBox.Show("At least one field is blank.  Please fill it in");
            }
            
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfigurationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this is supposed to handle if one x's out the settings window
            //it works in that case,but if you Click Save Settings, then you

            ;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //closes ConfigurationForm
            
        }
    }
}
