using System.Net;
using System.Security.AccessControl;

class Program {
    static void Main(string[] args) {
        string url = "https://www.devbg.org/img/Logo-BASD.jpg";

        // Xác định đường dẫn tới tập tin để lưu trữ ảnh
        string dir = @$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\image";

        // Tải ảnh từ URL và lưu nó vào tập tin

        try
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(url, dir);
            }
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message.ToString());   
        }
        Console.ReadLine();

    }
}