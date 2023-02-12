namespace CoTyPhu;

public class control {
    public static int player = 0;
    public int handle_turn(int player_turn, int dice1, int dice2) {
        return player_turn + (dice1 == dice2 ? 0 : 1);
    }
    
}