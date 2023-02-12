namespace CoTyPhu;

public class Control {
    public int handle_turn(int player, int dice1, int dice2) {
        return player + ((dice1 == dice2) ? 0 : 1);
    }
}