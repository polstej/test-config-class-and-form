using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_config_class_and_form
{
    [Serializable]
    class WordObject
    {
        public string Word { get; set; }
        public int Count { get; set; }
        public DateTime DateLastUsed { get; set; }
    }
}
