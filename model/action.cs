using System.Net.Sockets;
using System.Runtime.CompilerServices;
using CoTyPhu.control;
using CoTyPhu.view;

namespace CoTyPhu.model;

public class action {
    // process data 
    // with the client is received
    // with the server is sent
    public static void process(string type, object obj) {
        switch (type) {
            case "room":
                main.ControlServer.send("room");
                main.ControlServer.send(main.l.room);
                main.room_receive_from_server = (int)obj;
                break;
            case "STT":
                main.my_STT = (int)obj;
                break;
            case "lobby":
                main.l = (lobby)obj;
                control_view.display_lobby(main.l);
                break;
            case "start":
                control_view.start((int)obj);
                break;
            case "game":
                main.g = (game)obj;
                control_view.display_game(main.g);
                break;
            case "roll dice":
                KeyValuePair<int, KeyValuePair<int, int>> v = (KeyValuePair<int, KeyValuePair<int, int>>)obj;
                control_view.roll_Dice(v.Key, v.Value.Key, v.Value.Value);
                break;
            case "imprison":

                break;
            case "transfer":
                break;

            default:
                throw new Exception("Error");
        }
    }
}

public class action_server {
    public static void process(Socket client, string type, object obj) {
        // access the data receive 
        switch (type) {
            case "request_room":
                // return the main.l.room
                main.ControlServer.single_send(client, "room");
                main.ControlServer.single_send(client, main.l.room);
                break;
            case "request_lobby":
                main.ControlServer.send("lobby");
                main.ControlServer.send(main.l);
                break;
            case "request_STT":
                for (int i = 0; i < main.ControlServer.SK_connected.Count; i++) {
                    if (client == main.ControlServer.SK_connected[i]) {
                        main.ControlServer.send("STT");
                        main.ControlServer.send(i+1);
                        break;
                    }
                }

                break;
        }
    }
}