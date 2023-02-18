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
                int room = (int)obj;
                if (main.is_server) {
                    main.ControlServer.send("room");
                    main.ControlServer.send(main.l.room);
                } else {
                    main.l.room = room;
                    
                }
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
                control_view.roll_Dice(v.Key,v.Value.Key,v.Value.Value);
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