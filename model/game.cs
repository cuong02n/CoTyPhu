using System.Numerics;
using System.Runtime.InteropServices;
using CoTyPhu.model;
[StructLayout(LayoutKind.Sequential)]
[SerializableAttribute]
public class game {
    
    public  int number_of_players;
    public  int number_of_alives;
    public  int number_of_plot;
    public  bool[] alive = new bool[10];
    public List<Player> players = new();
    public  plot[] Plots = new plot[32];
    public  int turn;

    public void transfer_player_to_player(int player_STT_send, int player_STT_receive, long money) {
        
    }

    public void transfer_player_to_bank(int player_STT, long money) {
        
    }

    public void transfer_bank_to_player(int player_STT, long money) {
        
    }
}