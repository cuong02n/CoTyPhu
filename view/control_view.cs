using CoTyPhu.control;
using CoTyPhu.control.client;
using CoTyPhu.model;

namespace CoTyPhu.view; 

public class control_view {
    public static void roll_Dice(int STT_player,int dice1,int dice2)
    {

    }
    public static void jail()
    {

    }
    public static void imprison(int STT, int plot) {
        
    }
    public static void randomEvent() {

    }
    public static void turn() { 
    
    }
    public static void position() { 
    
    }
    public static void move(int stt,int before,int after) { 
    
    }
    public static void transfer() { 
    
    }
    public static void auction() { 
    
    }
    public static void item() { 
    
    }
    public static void teleport() { 
    
    }
    public static void changeColor(int color) {
    
    }
    public static void render() { 
    
    }

    
    public static void endGame() { 
    
    }
    public static void sellPlot() {
    
    }

    public static void change_multiple(int plot,float f) {
        
    }

    public static KeyValuePair<string,int> get_name_room() {
        return new KeyValuePair<string, int>(mainForm.user.tbUserName.Text,Int32.Parse(mainForm.user.tbRoomId.Text));
    }
    
    public static void error(string a) {
        
    }

    public static void display_lobby(lobby l ) {
        // vào phòng chờ 
        mainForm.showWaitingForm( l.room, l.Players[0].name);
    }

    public static void display_game(game g) {
        
    }
    public static void goToWaitPlayer(int roomId,string name)
    {
        // vao phong cho`
        main.ControlServer = new control_server();
        display_lobby(main.l);
    }
    public static void goToRoom(int roomId, string name) {
        main.ControlClient = new control_client();
        main.ControlClient.send("request_room");
        main.ControlClient.send(new KeyValuePair<string,int>(name,roomId));
    }
    public static void message(String mess)
    {
        MessageBox.Show(mess);
    }
}