using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using CoTyPhu.model;
using CoTyPhu.view;

namespace CoTyPhu.control.client;

public class control_client {
    public lobby l = new lobby();
    public int room;
    public IPEndPoint IpServer;
    public Socket sk;

    public void Connect_to_server() {
        sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        sk.SendTimeout= 10000;
        
        IpServer = new IPEndPoint(IPAddress.Loopback, 9999);
        try {
            sk.Connect(IpServer);
        } catch (Exception) {
            control_view.error("Cannot connect to Host");
            throw;
        }
    }

    public void SEND_ACTION(string action) {
        try {
            sk.Send(Serialize(action));
        } catch (Exception e) {
            Console.WriteLine(e);
            throw;
        }
    }

    public void receive() {
        
    }

    

    public static object Deserialize(byte[] data) {
        BinaryFormatter formatter = new BinaryFormatter();
        MemoryStream stream = new MemoryStream(data);

#pragma warning disable SYSLIB0011
        return formatter.Deserialize(stream);
#pragma warning restore SYSLIB0011
    }
 
    public static byte[] Serialize(object obj) {
        BinaryFormatter formatter = new BinaryFormatter();
        MemoryStream stream = new MemoryStream();
#pragma warning disable SYSLIB0011
        formatter.Serialize(stream, obj);
#pragma warning restore SYSLIB0011

        return stream.ToArray();
    }

    
}