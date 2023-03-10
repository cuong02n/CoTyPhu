using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using CoTyPhu.control.client;
using CoTyPhu.model;

namespace CoTyPhu.control;

public class control_server {
    public List<Socket> SK_connected = new();
    private IPEndPoint IpEndPoint = new(IPAddress.Any, 9999);
    public int room;
    public Socket Server;

    public void Accept_client() {
        Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Server.Bind(IpEndPoint);
        Thread accept = new Thread(() => {
            try {
                while (true) {
                    Server.Listen(100);
                    Socket s = Server.Accept(); // client
                    // SK_connected.Add(s);

                    Thread th = new Thread(receive);
                    th.IsBackground = true;
                    th.Start(s);
                }
            } catch (Exception e) {
                IpEndPoint = new IPEndPoint(IPAddress.Any, 9999);
                Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                MessageBox.Show(e.ToString());
                throw;
            }
        });
        accept.IsBackground = true;
        accept.Start();
    }

    public void receive(object obj) {
        // receive(Socket client)
        Socket client = obj as Socket;
        try {
            while (true) {
                byte[] type = new byte[50];
                client.Receive(type);
                byte[] data = new byte[1024 * 5];
                client.Receive(data);
                action_server.process(client, type.ToString(), control_client.Deserialize(data));
                // TODO
            }
        } catch (Exception e) {
            Console.WriteLine(e);
            throw;
        }
    }

    //receive data from a client
    public void send(object obj) {
        try {
            foreach (Socket client in SK_connected) {
                client.Send(Serialize(obj));
            }
        } catch (Exception e) {
            Console.WriteLine(e);
            throw;
        }
    }

    public void single_send(Socket sk, object obj) {
        try {
            sk.Send(Serialize(obj));
        } catch (Exception e) {
            Console.WriteLine(e);
            throw;
        }
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

    public control_server() {
        main.is_server = true;
        main.my_STT = 0;

        main.l = new lobby();
        Player host = new Player(main.name, null, 0, main.money_Start);
        main.l.Players.Add(host);

        

        Accept_client();
    }
}