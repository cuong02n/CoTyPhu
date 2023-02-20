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
        mainForm.waiting.displayLobby(l);
    }

    public static void display_game(game g) {
        
    }
    public static void goToRoom(int roomId, string name) {

    }
    public static void message(String mess)
    {
        MessageBox.Show(mess);
    }
}