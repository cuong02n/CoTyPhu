namespace CoTyPhu.view; 

public class control_view {
    public static void rollTheDice(int dice1,int dice2)
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
    public static void start(int numberPlayer) {
    
    }
    public static void endGame() { 
    
    }
    public static void sellPlot() {
    
    }

    public static void change_multiple(int plot,float f) {
        
    }

    public static void go_to_room(int room, int number_of_player) {
        
    }
    
    public static KeyValuePair<string,int> get_name_room() {
        return new KeyValuePair<string, int>(mainForm.user.tbUserName.Text,Int32.Parse(mainForm.user.tbRoomId.Text));
    }

    public static bool is_host(string name,int room) {
        // an nut create
        return true;
    }

    public static bool is_member(string name,int room) {
        // an nut play
        return true;
    }
}