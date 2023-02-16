using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace CoTyPhu;
using CoTyPhu.view;

class Program {
    public static IPAddress ducmiip = IPAddress.Parse("26.89.162.172");
    public static IPAddress myip = IPAddress.Parse("26.52.142.16");
    public const int port = 2905;
    [STAThread]
    static void Main() {

        ApplicationConfiguration.Initialize();
        Application.Run(new mainForm());
        
        
    }
}