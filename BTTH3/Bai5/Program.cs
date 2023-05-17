class TamGiac
{
    public double a { get; set; }
    public double b { get; set; }
    public double c { get; set; }

    public void input()
    {
        try
        {
            Console.Write("Nhap vao canh 1: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao canh 2: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao canh 3: ");
            c = Convert.ToDouble(Console.ReadLine());
            if (a <= 0 || b <= 0 || c <= 0) throw new Exception("Canh khong duoc am");
            if (!((Math.Abs(a - b) < c && c < a + b && Math.Abs(b - c) < a && a < b + c && Math.Abs(c - a) < b && b < c + a))) throw new Exception("3 Canh vua nhap khong phai tam giac");
        }
        catch (Exception e) { Console.WriteLine(e.Message.ToString()); }
    }
    public double GetChuVi() => (a + b + c) / 2;

    static void Main(string[] args)
    {
        List<TamGiac> tamGiacs = new List<TamGiac>();
        for (int i = 0; i < 3; ++i)
        {
            TamGiac tamGiac = new TamGiac();
            Console.WriteLine($"Nhap vao tam giac {i + 1}");
            tamGiac.input();
            tamGiacs.Add(tamGiac);
        }
        Console.WriteLine("Chu vi cac tam giac vua nhap la: ");
        foreach (var tg in tamGiacs)
        {
            Console.WriteLine(tg.GetChuVi());
        }

    }

}