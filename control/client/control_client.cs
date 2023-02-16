using System.Net;
using System.Net.Sockets;
using System.Text;
using CoTyPhu.model;
using CoTyPhu.view;

namespace CoTyPhu.client;

public class control_client {
    public static void init_UDP_client() {
        UdpClient client = new UdpClient(9999);
        IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
        Socket sk = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.udp);
        byte[] sender = Encoding.ASCII.GetBytes(control_view.get_name_room());
        sk.SendTo(sender, ipEndPoint);
    }

    public static void init_UDP_server() {
        UdpClient client = new UdpClient(9999);
    }

    // TODO
    // nhan dc du lieu tu ng choi 1
    // tung xx dc 5,5
    // frontend.tungxx()
    public static KeyValuePair<int, int> random_dice() {
        Random r = new Random();
        int x = r.Next(1, 6);
        int y = r.Next(1, 6);
        return new KeyValuePair<int, int>(x, y);
    }

    public static void imprison(int STT) {
        // TODO
        control_view.imprison(STT, game.Players[STT].position);
    }

    public static ticket random_ticket() {
        Random r = new Random();
        int t = r.Next(0, 5);
        return new ticket();
        // TODO
    }

    public static int get_turn(int player_turn, int dice1, int dice2) {
        if (dice1 == dice2) {
            return player_turn;
        }

        for (int i = player_turn; i < game.number_of_players + player_turn; i++) {
            if (game.alive[i]) {
                return i % game.number_of_players;
            }
        }

        return -1;
    }

    public static void startgame() {
        control_view.start(game.number_of_players);
    }

    public static void endgame() {
        control_view.endGame();
    }


    public static void auction() {
    }

    public static void bet() {
    }

    public static void handle_map() {
        for (int i = 0; i < 32; i++) {
            if (game.Plots[i].owner < 0) {
                break;
            }

            int same = 0;
            for (int j = i + 1; j < 32; j++) {
                if (game.Plots[i].owner == game.Plots[j].owner) {
                    same++;
                } else {
                    // het lien tuc roi
                    if (same >= 3) {
                        for (int k = i; k < j; k++) {
                            game.Plots[k].multiple = 0.7f;
                            control_view.change_multiple(i, 0.7f);
                        }
                    } else {
                        for (int k = i; k < j; k++) {
                            game.Plots[k].multiple = 1;
                            control_view.change_multiple(i, 1);
                        }
                    }

                    i = j;
                    break;
                }
            }
        }
        // DONE
    }

    public static void transfer(int money, int player_from, int player_to) {
        if (player_from >= 0) {
        }
        // TODO
    }

    public bool check_room(int ID_room, string name) {
        return true;
    }


    public static void handle_move() {
        // 4 consecutive move : imprison
        // goto auction plot: auction or not
        // goto imprison: imprison
        // handle imprison
        // out of plot 0: reward
        // other plot: 
        // my plot
        // random event
        // teleport

        // TODO
    }
}