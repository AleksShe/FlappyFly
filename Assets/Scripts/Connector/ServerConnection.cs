using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEditor.PackageManager;

public class ServerConnection
{
    const string ip = "192.168.11.129";
    const int port = 8080;
    IPEndPoint tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
    Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


    public void SentPlayerToAdd(Player player)
    {
        var clientToAdd = JsonConvert.SerializeObject(player);
        var bytesData = Encoding.UTF8.GetBytes(clientToAdd);
        if (!tcpSocket.Connected)
        {
            tcpSocket.Connect(tcpEndPoint);
        }
        tcpSocket.Send(bytesData);
    }
    public List<Player> Get()
    {
        List<Player> ClientsAnswer = new List<Player>();
        string temp = "Get";
        var bytesData = Encoding.UTF8.GetBytes(temp);
        if (!tcpSocket.Connected)
        {
            tcpSocket.Connect(tcpEndPoint);
        }

        tcpSocket.Send(bytesData);
        var buffer = new byte[256];
        var size = 0;
        var answer = new StringBuilder();
        do
        {
            size = tcpSocket.Receive(buffer);
            answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
        }
        while (tcpSocket.Available > 0);
        ClientsAnswer = JsonConvert.DeserializeObject<Player[]>(answer.ToString()).ToList();

        return ClientsAnswer;
    }
}