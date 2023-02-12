using System.Numerics;

namespace CoTyPhu.Model; 

public class info_player {
    private string IP { get; set; }
    private string STT { get; set; }
    private string money { get; set; }
    private string color { get; set; }
    public int position;
    public int consecutive_dice;
    public Vector<plot> plots = new Vector<plot>();
    public Vector<ticket> tickets = new Vector<ticket>();
}

public struct plot {
    public int STT;
    public int owner;
    public string name;
    public int level;
}

public struct ticket {
    public string type;

    public ticket(string t) {
        type = t;
    }
}