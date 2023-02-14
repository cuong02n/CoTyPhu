using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CoTyPhu;
using CoTyPhu.view;


// using Socket client = new Socket(
//     IPEndPoint.AddressFamily, 
//     SocketType.Stream, 
//     ProtocolType.Tcp);
//
// await client.ConnectAsync(ipEndPoint);
// while (true)
// {
//     // Send message.
//     var message = "Hi friends 👋!<|EOM|>";
//     var messageBytes = Encoding.UTF8.GetBytes(message);
//     _ = await client.SendAsync(messageBytes, SocketFlags.None);
//     Console.WriteLine($"Socket client sent message: \"{message}\"");
//
//     // Receive ack.
//     var buffer = new byte[1_024];
//     var received = await client.ReceiveAsync(buffer, SocketFlags.None);
//     var response = Encoding.UTF8.GetString(buffer, 0, received);
//     if (response == "<|ACK|>")
//     {
//         Console.WriteLine(
//             $"Socket client received acknowledgment: \"{response}\"");
//         break;
//     }
//     // Sample output:
//     //     Socket client sent message: "Hi friends 👋!<|EOM|>"
//     //     Socket client received acknowledgment: "<|ACK|>"
// }
// client.Shutdown(SocketShutdown.Both);

class Program {
    public static IPAddress ducmiip = IPAddress.Parse("26.89.162.172");
    public static IPAddress myip = IPAddress.Parse("26.52.142.16");
    public const int port = 2905;
    [STAThread]
    static void Main() {
        // send 
        // {
        //     IPEndPoint endPoint = new IPEndPoint(ducmiip, port);
        //     Socket sk = new Socket(AddressFamily.InterNetwork);
        // }
        ApplicationConfiguration.Initialize();
        Application.Run(new mainForm());
        
       
    }
}