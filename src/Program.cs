namespace CoTyPhu;

class Program {
    public KeyValuePair<int, string>[] player = new KeyValuePair<int,string>[6];
    [STAThread]
    static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}