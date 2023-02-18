using System.Net;
using System.Net.Sockets;
using CoTyPhu.control.client;

namespace CoTyPhu.control; 

public class control_server : control_client{
    public List<Socket> SK_connected = new();
    private IPEndPoint IpEndPoint = new IPEndPoint(IPAddress.Any, 9999);
    
    public void Accept_client() {
        Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Server.Bind(IpEndPoint);
        Thread accept = new Thread(() => {
            
            while (true) {
                try {
                    Server.Listen(10);
                    Socket s = Server.Accept();
                    SK_connected.Add(s);

                    Thread receive = new Thread(this.receive);
                    receive.IsBackground = true;
                    receive.Start();
                } catch (Exception e) {
                    Console.WriteLine(e);
                    throw;
                }
            }
        });
        accept.IsBackground = true;
        accept.Start();
    }

    
    //receive data from a client
    public void receive(Socket client) {
        
    }

    public void SEND_ACTION() {
        
    }

    public control_server() {
        Accept_client();
    }
    
}