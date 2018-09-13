using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McWiFi
{
    class settings
    {
        private Boolean passChar;
        private String ssid;
        private String key;

        public settings(String[] content)
        {
            passChar = content[0].Equals("1")? true : false ;
            ssid = content[1];
            key = content[2];
        }
        

        public Boolean PassChar
        {
            set
            {
                passChar = value;
            }
            get
            {
                return passChar;
            }
        }
        public String SSID
        {
            set
            {
                ssid = value;
            }
            get
            {
                return ssid;
            }
        }

        public String Key
        {
            set
            {
                key= value;
            }
            get
            {
                return key;
            }
        }




    }
}
