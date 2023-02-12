using CoTyPhu.Model;

namespace CoTyPhu.client;

public class control {
    public static int player = 0;

    public KeyValuePair<int,int> random_dice() {
        return new KeyValuePair<int, int>(1, 1);
    }

    public void imprison() {
        
    }

    public ticket random_ticket() {
        
    }
    public int handle_turn(int player_turn, int dice1, int dice2) {
        return player_turn + (dice1 == dice2 ? 0 : 1);
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

    public void send() {

    }

    public void receive() {
        
    }
}