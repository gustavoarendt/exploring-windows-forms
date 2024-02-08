using System.IO;
using System.Net;
using System.Text;

namespace Utils
{
    public static class Network
    {
        public static string GetAddressJsonViaCep(string cep)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://viacep.com.br/ws/{cep}/json/");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            int cont;
            byte[] buffer = new byte[1024];
            StringBuilder sb = new StringBuilder();
            string temp;
            Stream stream = response.GetResponseStream();
            do
            {
                cont = stream.Read(buffer, 0, buffer.Length);
                temp = Encoding.Default.GetString(buffer, 0, cont).Trim();
                sb.Append(temp);
            } while (cont > 0);
            return sb.ToString();
        }
    }
}
