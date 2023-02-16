using System.Net;
using CoTyPhu.control.client;

namespace CoTyPhu;
using CoTyPhu.view;

public struct Pair<T1,T2> {
    public T1 Key;
    public T2 Value;

    public Pair(T1 Key, T2 Value) {
        this.Key = Key;
        this.Value = Value;
    }

    public override string ToString() {
        return $"{Key},{Value}";
    }

    public static Pair<T1, T2> Parse(string t) {
        string[] arr = t.Split(',');
        return new Pair<T1, T2>((T1)Convert.ChangeType(arr[0],typeof(T1)), (T2)Convert.ChangeType(arr[1],typeof(T2)));
    }
}

class Program {
    
    
    public static IPAddress ducmiip = IPAddress.Parse("26.89.162.172");
    public static IPAddress myip = IPAddress.Parse("26.52.142.16");
    public const int port = 2905;
    [STAThread]
    static void Main() {

        ApplicationConfiguration.Initialize();
        Application.Run(new mainForm());

        control_client.init_UDP();
    }
}