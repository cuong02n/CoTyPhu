using CoTyPhu.Model;

namespace CoTyPhu.client;

public class control_client {
    public KeyValuePair<int,int> random_dice() {
        Random r = new Random();
        int x = r.Next(1, 6);
        int y = r.Next(1, 6);
        return new KeyValuePair<int, int>(x,y);
    }

    public void imprison() {
        //TODO
    }

    public ticket random_ticket() {
        Random r = new Random();
        int t = r.Next(0, 5);
        return new ticket();
        // TODO
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

    public void receive(int money,int player_from,int player_to) {
        if (player_from >= 0) {
           
        }
    }
}