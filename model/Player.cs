using System.Net;
using System.Net.Sockets;
using System.Numerics;

namespace CoTyPhu.model; 

public class Player {
    public string name;
    public Socket client;
    public int STT;
    public long  money;
    public Color color;
    public int position;
    public int consecutive_dice =0;
    public Vector<int> plots = new();// pos
    public Vector<ticket> tickets = new();

    public Player(string name, Socket client, int STT, long money,Color color) {
        this.name = name;
        this.STT = STT;
        this.client = client;
        this.money = money;
        this.color = color;
        consecutive_dice = 0;
        position = 0;
    }

    public Player(string name, Socket client, int STT, long money) {
        this.name = name;
        this.client = client;
        this.STT = STT;
        this.money = money;
    }
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