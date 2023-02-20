using CoTyPhu.model;
using CoTyPhu.view;

namespace CoTyPhu.control;

public class process_game {

    // TODO
    public static KeyValuePair<int, int> random_dice() {
        Random r = new Random();
        int x = r.Next(1, 6);
        int y = r.Next(1, 6);
        return new KeyValuePair<int, int>(x, y);
    }

    public static void imprison(int STT) {
        // TODO
        control_view.imprison(STT, main.g.players[STT].position);
    }

    public static ticket random_ticket() {
        Random r = new Random();
        int t = r.Next(0, 5);
        return new ticket();
        // TODO
    }

    public static int get_turn(int player_turn, int dice1, int dice2) {
        if (dice1 == dice2) {
            return player_turn;
        }

        for (int i = player_turn; i < main.g.number_of_players + player_turn; i++) {
            if (main.g.alive[i]) {
                return i % main.g.number_of_players;
            }
        }

        return -1;
    }

    public static void startgame(game g) {
        // control_view.start(g);
    }

    public static void endgame() {
        control_view.endGame();
    }


    public static void auction() {
    }

    public static void bet() {
    }

    public static void handle_map() {
        for (int i = 0; i < 32; i++) {
            if (main.g.Plots[i].owner < 0) {
                break;
            }

            int same = 0;
            for (int j = i + 1; j < 32; j++) {
                if (main.g.Plots[i].owner == main.g.Plots[j].owner) {
                    same++;
                } else {
                    // het lien tuc roi
                    if (same >= 3) {
                        for (int k = i; k < j; k++) {
                            main.g.Plots[k].multiple = 0.7f;
                            control_view.change_multiple(i, 0.7f);
                        }
                    } else {
                        for (int k = i; k < j; k++) {
                            main.g.Plots[k].multiple = 1;
                            control_view.change_multiple(i, 1);
                        }
                    }

                    i = j;
                    break;
                }
            }
        }
        // DONE
    }


    // public bool check(int room) {
    //     // if client
    //     try {
    //         main.thresh_receive.Suspend();
    //         main.ControlClient.send(room);
    //         Thread.Sleep(100); // 100 ping maximum
    //         main.thresh_receive.Resume();
    //     } catch (Exception e) {
    //         Console.WriteLine(e);
    //     }
    //
    //     if (main.room_receive_from_server == main.l.room) {
    //         // room ok 
    //         // request lobby
    //         
    //         return true;
    //     }
    //
    //     return false;
    // }
    

    public static void handle_move() {
        // 4 consecutive move : imprison
        // goto auction plot: auction or not
        // goto imprison: imprison
        // handle imprison
        // out of plot 0: reward
        // other plot: 
        // my plot
        // random event
        // teleport

        // TODO
    }
}