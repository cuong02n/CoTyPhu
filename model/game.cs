using System.Numerics;

namespace CoTyPhu.Model; 

public class game {
    public int STT_PLAYER;
    public int player_number;
    public int size_plot;
    public Vector<int> alive_player = new Vector<int>();
    public info_player[] Players = new info_player[6];
    public int turn;
    
}