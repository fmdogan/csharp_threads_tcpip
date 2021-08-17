using System;
/*
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
*/
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        int sonuc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadServer();
            button1.Enabled = false;
        }

        void ThreadServer()
        {
            Thread thread = new Thread(new ThreadStart(Hesapla));
            thread.Start();
        }

        void Hesapla()
        {
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 1234);

            // TCP/IP soket oluşturulur 
            Socket listener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {
                    Console.WriteLine("Bağlantı bekleniyor... ");

                    // Accept() metodu, Client ile bağlantı kurmayı bekler ve kurar
                    Socket clientSocket = listener.Accept();
                    label3.Text = "Bağlantı kuruldu.";
                    IP_label.Text = clientSocket.RemoteEndPoint.ToString();

                    // Data buffer 
                    byte[] bytes = new Byte[1024];
                    string data = null;

                    while (true)
                    {
                        int numByte = clientSocket.Receive(bytes);

                        data += Encoding.ASCII.GetString(bytes, 0, numByte);
                        // Mesajın sonundaki <EOF> alınınca bırak
                        if (data.IndexOf("<EOF>") > -1)
                            break;
                    }

                    Console.WriteLine("Alınan mesaj -> {0} ", data);

                    // Gelen mesaj sayı ve işlem parçalarına ayrılır
                    String[] textParcalari = data.Split('#');
                    if (textParcalari.Length == 4)
                        gelenMesajText.Text = textParcalari[0] + textParcalari[2] + textParcalari[1];
                    else gelenMesajText.Text = textParcalari[0] + textParcalari[1];

                    // Faktoriyel ve fibonacci işlemleri için threadler oluşturulur

                    switch (textParcalari[textParcalari.Length - 2])
                    {
                        case "+":
                            sonuc = int.Parse(textParcalari[0]) + int.Parse(textParcalari[1]);
                            break;
                        case "-":
                            sonuc = int.Parse(textParcalari[0]) - int.Parse(textParcalari[1]);
                            break;
                        case "*":
                            sonuc = int.Parse(textParcalari[0]) * int.Parse(textParcalari[1]);
                            break;
                        case "/":
                            sonuc = int.Parse(textParcalari[0]) / int.Parse(textParcalari[1]);
                            break;
                        case "faktoriyel":
                            // Faktoriyel hesabı için thread üretir ve çalıştırır ve sonrasında askıya alır
                            Thread thread1 = new Thread(new ThreadStart(faktoriyel));
                            thread1.Start();
                            break;
                        case "fibonacci":
                            // Fibonacci hesabı için thread üretir ve çalıştırır ve sonrasında askıya alır
                            Thread thread2 = new Thread(new ThreadStart(fibonacci));
                            thread2.Start();
                            break;
                        default: break;
                    }
                    // Client'e geri gönderilecek mesajı oluşturur ve gönderir
                    byte[] message = Encoding.ASCII.GetBytes(sonuc.ToString());
                    clientSocket.Send(message);

                    sonucText.Text = sonuc.ToString();

                    void faktoriyel()
                    {
                        int fakt = 1;
                        for (int i = 1; i <= int.Parse(textParcalari[0]); i++)
                        {
                            fakt *= i;
                        }
                        sonuc = fakt;
                    }

                    void fibonacci()
                    {
                        int birinciSayi = 0, ikinciSayi = 1, gecici;
                        for (int j = 0; j < int.Parse(textParcalari[0]); j++)
                        {
                            gecici = ikinciSayi;
                            ikinciSayi = birinciSayi + ikinciSayi;
                            birinciSayi = gecici;
                        }
                        sonuc = ikinciSayi;
                    }

                    // Soket kapatılır ve yeni Client ile bağlantı için beklenir
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                    label3.Text = "İşlem tamamlandı.";
                }
            }
            catch
            {
                Console.WriteLine("Başarısız");
            }
        }
    }
}