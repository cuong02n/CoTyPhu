using System.Net;
using CoTyPhu.control;
using CoTyPhu.control.client;
using CoTyPhu.model;

namespace CoTyPhu;
using CoTyPhu.view;

class main {
    public static int room_receive_from_server;
    public static lobby l;
    public static game g;
    public static bool is_server = false;

    public static control_server ControlServer;
    public static control_client ControlClient;

    public static Thread thresh_receive;
    [STAThread]
    static void Main() {

        ApplicationConfiguration.Initialize();
        Application.Run(new mainForm());
        
        
    }
}