using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TCPClient
{
    public partial class Form1 : Form
    {
        string mesaj_text = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (islemler.SelectedIndex < 4) // 4 işlemden biri seçilmiş ise 2. sayı da dahil edilecek
            {
                mesaj_text = sayi1_text.Text + "#" + sayi2_text.Text + "#" + islemler.SelectedItem + "#";
                Console.WriteLine(mesaj_text);
            }
            else
            {
                mesaj_text = sayi1_text.Text + "#" + islemler.SelectedItem + "#";
                Console.WriteLine(mesaj_text);
            }

            // Server ile bağlantı kurulacak
            try
            {
                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddr = ipHost.AddressList[0];
                IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 1234);

                // TCP/IP soketi oluşturulur 
                Socket socketSender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    Console.WriteLine("deneme1");

                    // Soket, Connect() metodu ile hedefe bağlanır
                    socketSender.Connect(localEndPoint);
                    Console.WriteLine("deneme2");
                    IP_label.Text = socketSender.RemoteEndPoint.ToString();
                    
                    // Server'e gönderilecek mesaj oluşturulur ve gönderilir
                    byte[] messageSent = Encoding.ASCII.GetBytes(mesaj_text + "<EOF>");
                    int byteSent = socketSender.Send(messageSent);

                    // Data buffer 
                    byte[] messageReceived = new byte[1024];

                    // Receive() metodu ile mesajı alıyoruz
                    // Bu metod, sting'e çevireceğimiz byte'ların sayısını döndürür 
                    int byteRecv = socketSender.Receive(messageReceived);
                    
                    sonuc_text.Text = Encoding.ASCII.GetString(messageReceived, 0, byteRecv);
                    
                    // Close() metodu ile soket kapatılır 
                    socketSender.Shutdown(SocketShutdown.Both);
                    socketSender.Close();
                }
                // Soket işlemindeki istisnalar yakalanır 
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                    sonuc_text.Text = "Sonuç alınamadı.";
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                    sonuc_text.Text = "Sonuç alınamadı.";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    sonuc_text.Text = "Sonuç alınamadı.";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                sonuc_text.Text = "Sonuç alınamadı.";
            }
        }

        private void islemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 4 işlem seçilmemişse 2. sayı kutusunu saklar
            if (islemler.SelectedIndex < 4) sayi2_text.Visible = true;
            else
            {
                sayi2_text.Visible = false;
                sayi2_text.Text = "1";
            }

            int sayi1, sayi2;
            bool isSayi1 = Int32.TryParse(sayi1_text.Text, out sayi1);
            bool isSayi2 = Int32.TryParse(sayi2_text.Text, out sayi2);

            // Sayı girilmemişse veya işlem seçilmemişse buton aktif olmaz
            if (isSayi1 && isSayi2 && islemler.SelectedIndex != null)
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void sayi1_text_TextChanged(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            bool isSayi1 = Int32.TryParse(sayi1_text.Text, out sayi1);
            bool isSayi2 = Int32.TryParse(sayi2_text.Text, out sayi2);
            // Sayı girilmemişse veya işlem seçilmemişse buton aktif olmaz
            if (isSayi1 && isSayi2 && islemler.SelectedIndex != null)
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void sayi2_text_TextChanged(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            bool isSayi1 = Int32.TryParse(sayi1_text.Text, out sayi1);
            bool isSayi2 = Int32.TryParse(sayi2_text.Text, out sayi2);
            // Sayı girilmemişse veya işlem seçilmemişse buton aktif olmaz
            if (isSayi1 && isSayi2 && islemler.SelectedIndex != null)
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }
    }
}

