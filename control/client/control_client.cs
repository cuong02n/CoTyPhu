using CoTyPhu.model;
using CoTyPhu.view;

namespace CoTyPhu.client;

public class control_client {
    public int[] map = {
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
        -1, -1, -1, -1
    };

    //init plot TODO

    public KeyValuePair<int, int> random_dice() {
        Random r = new Random();
        int x = r.Next(1, 6);
        int y = r.Next(1, 6);
        return new KeyValuePair<int, int>(x, y);
    }

    public void imprison(int STT) {
        // TODO
    }

    public ticket random_ticket() {
        Random r = new Random();
        int t = r.Next(0, 5);
        return new ticket();
        // TODO
    }

    public int get_turn(int player_turn, int dice1, int dice2) {
        if (dice1 == dice2) {
            return player_turn;
        }

        for (int i = player_turn; i < game.number_of_players + player_turn; i++) {
            if (game.alive[i]) {
                return i % game.number_of_players;
            }
        }

        return -1;
    }

    public void startgame() {
    }

    public void endgame() {
    }


    public void auction() {
    }

    public void bet() {
    }

    public void handle_map() {
        for (int i = 0; i < 32; i++) {
            if (map[i] < 0) {
                break;
            }

            int same = 0;
            for (int j = i + 1; j < 32; j++) {
                if (map[i] == map[j]) {
                    same++;
                } else {
                    // het lien tuc roi
                    if (same >= 3) {
                        for (int k = i; k < j; k++) {
                            game.Plots[k].multiple = 0.7f;
                        }
                    }

                    break;
                }
            }
        }
    }

    public void transfer(int money, int player_from, int player_to) {
        if (player_from >= 0) {
        }
        // TODO
    }

    public void handle_move() {
        // 4 consecutive move : imprison
        // goto auction plot: auction or not
        // goto imprison: imprison
        // handle imprison
        // out of plot 0: reward
        // other plot: 
        // my plot
        // random event
        // teleport
    }
}