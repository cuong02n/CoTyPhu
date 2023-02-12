using System.Numerics;

namespace CoTyPhu.model; 

public class player {
    private string IP { get; set; }
    private string STT { get; set; }
    private string money { get; set; }
    private string color { get; set; }
    public int position;
    public int consecutive_dice;
    public Vector<int> plots = new();// pos
    public Vector<ticket> tickets = new();
}   

public struct plot {
    public int STT;
    public int owner;
    public string name;
    public int level;
    public float multiple;

    public plot(int STT, int owner, string name, int level, float multiple) {
        this.STT = STT;
        this.owner = owner;
        this.name = name;
        this.level = level;
        this.multiple = multiple;
    }
}

public struct ticket {
    public string type;

    public ticket(string t) {
        type = t;
    }
}