using CoTyPhu.Model;
using CoTyPhu.view;
using CoTyPhu.Model.game;

namespace CoTyPhu.client;

public class control_client {
    public int[] map =
        { 0, 1, 1, 1, 2, 3, 3, 3, 4, 5, 5, 5, 6, 7, 7, 7, 8, 9, 9, 9, 10, 11, 11, 11, 12, 13, 13, 13, 14, 15, 15, 15 };

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
    }

    public void startgame(game g) {
    }

    public void endgame() {
    }

    public void sell() {
    }

    public void auction() {
    }

    public void bet() {
    }

    public void handle_map() {
    }

    public void transfer(int money, int player_from, int player_to) {
        if (player_from >= 0) {
        }
    }
}