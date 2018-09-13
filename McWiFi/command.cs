using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McWiFi
{
    class command
    {
        public String setCredentials(String[] content)
        {
            try
            {
                //create the processStartInfo using cmd as the program to be run
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd.exe", "/C netsh wlan set hostednetwork mode=allow ssid="+content[1]+" key="+content[2]);
                //redirect output
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;

                //do not create window
                procStartInfo.CreateNoWindow = true;

                //procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                //create the process
                Process process = new Process();
                //assign start info
                process.StartInfo = procStartInfo;

                //start processkjk
                process.Start();

                //read output
                return process.StandardOutput.ReadToEnd();
                
            }catch(Exception e)
            {
                return "Ooops!! There was an error";
            }
        }
        public String startNetwork()
        {
            try
            {
                //create the processStartInfo using cmd as the program to be run
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd.exe", "/C netsh wlan start hostednetwork");
                //redirect output
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;

                //do not create window
                procStartInfo.CreateNoWindow = true;

                //procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                //create the process
                Process process = new Process();
                //assign start info
                process.StartInfo = procStartInfo;

                //start processkjk
                process.Start();

                //read output
                return process.StandardOutput.ReadToEnd();

            }
            catch (Exception e)
            {
                return "Ooops!! There was an error ";
            }
        }
        public String stopNetwork()
        {
            try
            {
                //create the processStartInfo using cmd as the program to be run
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd.exe", "/C netsh wlan stop hostednetwork");
                //redirect output
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;

                //do not create window
                procStartInfo.CreateNoWindow = true;

                //procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                //create the process
                Process process = new Process();
                //assign start info
                process.StartInfo = procStartInfo;

                //start processkjk
                process.Start();

                //read output
                return process.StandardOutput.ReadToEnd();

            }
            catch (Exception e)
            {
                return "Ooops!! There was an error";
            }
        }
        public String NetworkStatus()
        {
            try
            {
                //create the processStartInfo using cmd as the program to be run
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd.exe", "/C netsh wlan show hostednetwork");
                //redirect output
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;

                //do not create window
                procStartInfo.CreateNoWindow = true;

                //procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                //create the process
                Process process = new Process();
                //assign start info
                process.StartInfo = procStartInfo;

                //start processkjk
                process.Start();

                //read output
                return process.StandardOutput.ReadToEnd();

            }
            catch (Exception e)
            {
                return "Oops!! There was an error";
            }
        }
    }
}
