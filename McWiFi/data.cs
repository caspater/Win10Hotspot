using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McWiFi
{
    class data
    {
        FileStream file;
        String[] content;
        command commander;
        public data()
        {
           content = new String[3];
            commander = new command();
        }
        public String[] read()
        {
            if (File.Exists("data.mcw"))
            {
                file = new FileStream("data.mcw", FileMode.Open, FileAccess.ReadWrite);
                StreamReader reader = new StreamReader(file);

                content[0]=reader.ReadLine();
                content[1] = reader.ReadLine();
                content[2] = reader.ReadLine();
                reader.Close();
                file.Close();
            }
            else
            {
                content[0] = "0";
                content[1] = "KapsataWiFi";
                content[2] = "freeWiFi99";
                writeData(content);
                commander.setCredentials(content);
            }
            return content;
        }
        public void writeData(String[] updates )
        {
            
            file = new FileStream("data.mcw", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            foreach (String update in updates)
            {
                writer.WriteLine(update);
            }
            writer.Close();
            file.Close();
            
        }
    }
}

