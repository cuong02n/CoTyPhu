using System.Net;
using CoTyPhu.control;
using CoTyPhu.control.client;

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

        new control_server().SEND_ACTION("!2e");
    }
}