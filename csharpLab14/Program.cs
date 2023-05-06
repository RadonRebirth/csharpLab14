using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string input = Console.ReadLine();
            //string pattern = @"((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9]?)|(:{1,2}[\da-fA-F]{1,4}|\d:{1,2}[\da-fA-F]{1,4}|{\da-fA-F]{1,4}:){1,7}[\da-fA-F]{0,4}";
            /// 2001:0db8:85a3:0000:0000:8a2e:0370:7334 
            Regex ip4 = new Regex("^((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9]?)$");
            Regex ip6 = new Regex(
                "^((([\\da-fA-F]{1,4}:){7}[\\da-fA-F]{1,4})$|"+
                "^(([\\da-fA-F]{1,4}:){1,7}:)$|"+
                "[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|" +
                "^(([\\da-fA-F]{1,4}:){1,2}(:[\\da-fA-F]{1,4}){1,5})$|"+
                "^(([\\da-fA-F]{1,4}:){1,3}(:[\\da-fA-F]{1,4}){1,4})$|"+
                "^(([\\da-fA-F]{1,4}:){1,4}(:[\\da-fA-F]{1,4}){1,3})$|"+
                "^(([\\da-fA-F]{1,4}:){1,5}(:[\\da-fA-F]{1,4}){1,2})4|"+
                "^(:(((:([\\da-fA-F]){1,4}){1,7})|:)))$");
            //Match match = Regex.Match(input, pattern);
            Match matchip4 = ip4.Match(input);
            Match matchip6 = ip6.Match(input);
            if (matchip4.Success)
            {
                Console.WriteLine("Найден IP-адрес: " + matchip4.Value);
            }
            else if (matchip6.Success)
            {
                Console.WriteLine("Найден IP-адрес: " + matchip6.Value);
            }
            else
            {
                Console.WriteLine("IP-адрес не найден.");
            }
        }
    }
}

/// 1.2.3.4.5.6.7