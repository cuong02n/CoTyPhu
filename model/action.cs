using System.Runtime.CompilerServices;
using CoTyPhu.view;

namespace CoTyPhu.model;

public class action {
    public static lobby l;

    public static void process(string type, object obj) {
        switch (type) {
            
            case "lobby":
                get_lobby((lobby)obj);
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
        }
    }

    public static void get_lobby(lobby l) {
        action.l = l;
        control_view.display_lobby(l);
    }
}