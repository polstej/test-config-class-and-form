using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace test_config_class_and_form
{
    
    static class FileClerk //Class to work with files. made static for fun
    {
        //ctor
        static FileClerk()
        {

        }

        //methods

        static public void CreateDirectory()
        {
            GlobalVariables gv = new GlobalVariables();
            Directory.CreateDirectory(gv.directoryName);
        }
        
        static public void SerializeAndSaveToFile(Dictionary<string,
            WordObject> dictWordObjects, string filename)
        {
            GlobalVariables gv = new GlobalVariables();
            BinaryFormatter bformatter = new BinaryFormatter();
            //filename parameter is name only without directory 
            //or extension so I add these parts below (.REdit extension)

            using (FileStream fstream = new FileStream(gv.directoryName+
                @"\"+ filename+".REdit", FileMode.Create, 
                FileAccess.ReadWrite, FileShare.None))
            {
                bformatter.Serialize(fstream, dictWordObjects);

            }
        }

        static public Dictionary<string, WordObject> DeserializeReadFromFile
            (string filePath)
        {
            BinaryFormatter bformatter = new BinaryFormatter();
            using (FileStream fstream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                Dictionary<string, WordObject> dictionary = new Dictionary<string, WordObject>();
                dictionary = (Dictionary<string, WordObject>)bformatter.Deserialize(fstream);
                return dictionary;
            }
        }

        static public string[] ReadTextFromFile(string filename)
        {
            GlobalVariables gv = new GlobalVariables();
            string[] words = File.ReadAllLines(filename);
            return words;

        }
        static public bool CheckIFSettingsFileExist ()
        {
            
            GlobalVariables gv = new GlobalVariables();
            string pathname = gv.directoryName + gv.settingsFile;
            return File.Exists(pathname);

        }
        
        static public string[] ReadConfigurationFile()
            
        {
            GlobalVariables gv = new GlobalVariables();
            string pathname = gv.directoryName + gv.settingsFile;
            string[] configurationInfo = File.ReadAllLines(pathname);
            return configurationInfo;
         

        }
        static public void SaveToConfigurationFile( 
            string technique, string comparison, string body,
            string impression)
            
            //Saves info from ConfigurationForm to file
        {
            string directoryName = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+ 
                @"\REdit Files";
            string fileName = @"\REdit_Settings.txt";
            string pathname = directoryName + fileName;
            string[] keywords = {technique, comparison, body, impression };

            if (Directory.Exists(directoryName))
            {
              
                File.WriteAllLines(pathname, keywords);
            }
            else //if the directory does NOT exist, make the directory and
            //save info to a new settings file
            {
                FileClerk.CreateDirectory(); 
                File.WriteAllLines(pathname, keywords);
                               
            }
            
            
        }

        static public void InitializeVocabularyFiles (string pathname)
        {
            GlobalVariables gv = new GlobalVariables();

            //loop through the text vocab files to create binary files
            string[] filesToConvert= Directory.GetFiles(gv.sourceFilesDirectory);
            foreach (string filepath in filesToConvert)
            {
                //readtext from file to array or list
                string[] words = ReadTextFromFile(filepath);
                
                //initialize dictionary
                Dictionary <string, WordObject> dictionary = new Dictionary<string, WordObject> ();

                //initialize the reference object 
                WordObject word = new WordObject();
                word.Word = "xxxInitialiazerWord";
                word.Count = 10;
                word.DateLastUsed = DateTime.Today;

                //add initializer word to dictionary
                dictionary.Add(word.Word, word);

                //loop through string[], create WordObjects and add to Dict
                foreach (string txtword in words)
                {
                    WordObject wo = new WordObject();
                    wo.Word = txtword;
                    wo.Count = 10;
                    wo.DateLastUsed = DateTime.Today;
                    dictionary.Add(wo.Word, wo);
                }

                //serialize and save file to user drive
                //==>call method and send dictionary as parameter
                string filename = Path.GetFileNameWithoutExtension(filepath);
                SerializeAndSaveToFile(dictionary, filename);

                
                 
            }

        }
        




    }
}
