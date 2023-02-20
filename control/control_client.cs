using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using CoTyPhu.model;
using CoTyPhu.view;

namespace CoTyPhu.control.client;

public class control_client {
    public int room;
    public IPEndPoint IpServer;
    public Socket sk;

    public void Connect_to_server() {
        sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        // MessageBox.Show("123123");
        IpServer = new IPEndPoint(IPAddress.Loopback, 9999);
        try {
            sk.Connect(IpServer);
            if (sk.Connected) {
                control_view.message("connected");
            } else {
                MessageBox.Show("not connect");
            }
            main.thresh_receive = new Thread(receive);
            main.thresh_receive.IsBackground = true;
            main.thresh_receive.Start();
        } catch (Exception e) {
            MessageBox.Show(e.ToString());
            throw;
        }
    }
    

    public void send(object action) {
        try {
            sk.Send(Serialize(action));
        } catch (Exception e) {
            Console.WriteLine(e);
            throw;
        }
    }

    public void receive() {
        try {
            while (true) {
                byte[] type = new byte[50];
                sk.Receive(type);
                byte[] data = new byte[1024 * 5];
                sk.Receive(data);
                action.process(type.ToString(),Deserialize(data));
            }
        } catch (Exception e) {
            Console.WriteLine(e);
            throw;
        }
    }

    public control_client() {
        Connect_to_server();
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