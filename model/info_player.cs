using System.Numerics;

namespace CoTyPhu.Model; 

public class info_player {
    private string IP { get; set; }
    private string STT { get; set; }
    private string money { get; set; }
    private string color { get; set; }
    public Vector<plot> plots = new Vector<plot>();
}

public struct plot {
    public int STT;
    public int owner;
    public string name;
    public int level;
}