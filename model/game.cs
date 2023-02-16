using System.Numerics;
using System.Runtime.InteropServices;
using CoTyPhu.model;
[StructLayout(LayoutKind.Sequential)]
[SerializableAttribute]
public class game {
    public static string[] Event = new string[10];
    public static int STT_PLAYER;
    public static int number_of_players;
    public static int number_of_alives;
    public static int size_plot;
    public static bool[] alive = new bool[6];
    public static player[] Players = new player[6];
    public static plot[] Plots = new plot[32];
    public static int turn;
}