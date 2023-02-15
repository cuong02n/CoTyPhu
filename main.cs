using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CoTyPhu;
using CoTyPhu.view;

class Program {
    public static IPAddress ducmiip = IPAddress.Parse("26.89.162.172");
    public static IPAddress myip = IPAddress.Parse("26.52.142.16");
    public const int port = 2905;
    [STAThread]
    static void Main() {
        
        // client
        // Socket socket = new Socket(SocketType.Stream,ProtocolType.Tcp);
        // IPEndPoint ip = new IPEndPoint(ducmiip,port);
        // socket.Connect(ip);
        
        
        
        ApplicationConfiguration.Initialize();
        Application.Run(new mainForm());
    }
}