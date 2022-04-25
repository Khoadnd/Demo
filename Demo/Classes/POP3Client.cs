using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO;

namespace Demo.Classes
{
    public class POP3Client
    {
        TcpClient _popClient;
        StreamReader _sr;
        StreamWriter _sw;
        IPAddress _server;
        int _port = 110;
        string _serverIP = "127.0.0.1";

        public POP3Client() {
            IPAddress.TryParse(_serverIP, out _server);
            IPEndPoint iep = new IPEndPoint(_server, _port);

            _popClient = new TcpClient();
            _popClient.Connect(iep);

            _sr = new StreamReader(_popClient.GetStream());
            _sw = new StreamWriter(_popClient.GetStream());
            Auth();
        }

        ~POP3Client()
        {
            _popClient.Close();
            _sw.Close();
            _sr.Close(); 
        }

        public void Auth()
        {
            _sr.ReadLine();
            string data = "";

            data = "USER mailtest@nhom10.nt106";
            _sw.WriteLine(data);
            _sw.Flush();
            _sr.ReadLine();

            data = "PASS Ivagrentina123";
            _sw.WriteLine(data);
            _sw.Flush();
            _sr.ReadLine();
        }

        public void GetMailFromFolder(string folder, ref ListBox lsbMessage)
        {
            string data = "";
            data = "LIST";
            _sw.WriteLine(data);
            _sw.Flush();

            lsbMessage.Items.Clear();
            string s = _sr.ReadLine();
            while ((s = _sr.ReadLine()) != ".")
                lsbMessage.Items.Add(s);
        }

        public string GetMessageAt(int index)
        {
            string data = "RETR " + index.ToString();
            _sw.WriteLine(data);
            _sw.Flush();
            string s;
            string html = "";

            while ((s = _sr.ReadLine().Trim()) != null)
            {
                if (s.Length == 0) break;
                if (s.ToUpper().StartsWith("FROM"))
                    html += "FROM: " + s.Substring(5, s.Length - 5);
                if (s.ToUpper().StartsWith("TO"))
                    html += "TO: " + s.Substring(3, s.Length - 3);
                if (s.ToUpper().StartsWith("SUBJECT"))
                    html += "SUBJECT: " + s.Substring(8, s.Length - 8);
            }

            while (!_sr.EndOfStream)
            {
                s = _sr.ReadLine().Trim();
                if (s.Equals("."))
                    break;
                html += s + "\r\n";
            }

            return html;
        }
    }
}
