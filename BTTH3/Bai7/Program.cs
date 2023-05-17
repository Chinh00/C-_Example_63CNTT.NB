
using System.IO;

class Program {
    static void Main(String[] args) {
        try
        {
            string path = "C:\\Users\\Ching\\Downloads\\Untitled (1).sql";
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
        }
        catch (FileNotFoundException ex) {
            Console.WriteLine("Khong tim thay file can doc");
        }

    }
}