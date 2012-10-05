using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MediaSvc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MediaService : IService1
    {
        private System.Int32 iHandle;

        public void DoWork()
        {
        }

        public void Command(String Action, String Data)
        {
            iHandle = Win32.FindWindow("WMPlayerApp", "Windows Media Player"); 
            
            
            switch (Action)
            {
                case "Play":
                    {
                        if (iHandle == 0)
                        {
                            string FileName = @"wmplayer.exe";
                            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
                            myProcess.StartInfo.FileName = FileName;
                            myProcess.Start();
                        }

                        Win32.SendMessage(iHandle, Win32.WM_COMMAND, 0x00004978, 0x00000000);
                        break;
                    }
                case "Stop":
                    {
                        if (iHandle == 0)
                            return;
                        Win32.SendMessage(iHandle, Win32.WM_COMMAND, 0x00004979, 0x00000000);
                        break;
                    }
                    
            }

        }


    }
}
