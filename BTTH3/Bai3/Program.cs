class Program {
    static void Main(string[] args)
    {
        double a, b;
        try
        {
            Console.Write("Nhap vao so a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao so b: ");
            b = Convert.ToDouble(Console.ReadLine());
            if (b == 0) throw new DivideByZeroException();  
            Console.WriteLine($"Tong cua 2 so la: {a + b}");
            Console.WriteLine($"Hieu cua 2 so la: {a - b}");
            Console.WriteLine($"Tich cua 2 so la: {a * b}");
            Console.WriteLine($"Thuong cua 2 so la: {a / b}");


        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Khong chia duoc cho 0");
        }
        catch (Exception ex) {
            Console.WriteLine("Du lieu nhap vao khong hop le");
        }

    }
}