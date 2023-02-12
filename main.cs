namespace CoTyPhu;
using CoTyPhu.view;
class Program {
    public const string ip = "192.168.1.1";
    [STAThread]
    static void Main() {
        ApplicationConfiguration.Initialize();
        Application.Run(new mainForm());
    }
}