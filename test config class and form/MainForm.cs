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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //button click opens settings form
            ConfigurationForm cf = new ConfigurationForm();
            cf.Show();
         
        }

        private void btnCheckReport_Click(object sender, EventArgs e)
        {
            GlobalVariables gv = new GlobalVariables();
            string settingsFilePath = gv.directoryName + gv.settingsFile;

            //if the settings file does NOT exist then force initial settings
            //tell with MessageBox and open a ConfigurationForm
            if (!File.Exists(settingsFilePath))
            {
                MessageBox.Show("Looks like this is your first time using the" +
                    "program since I can't find your settings.  Fill out the " +
                    "settings form once and you should be good to go!");

               
                //open configuration form and initialize Vocab files
                //to users network drive
                ConfigurationForm cf = new ConfigurationForm();
                cf.ShowDialog();
        
                FileClerk.CreateDirectory();
                FileClerk.InitializeVocabularyFiles(gv.sourceFilesDirectory);
                
            }
            else  //if the settings file exists then go ahead with report check
            {
                //code for checking report
            }
        }
    }
}
