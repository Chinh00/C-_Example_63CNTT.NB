class Program {
    static void Main(String[] args) {
        double a, b;
        try
        {

            try
            {
                Console.Write("Nhap vao chieu dai: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap vao chieu rong: ");
                b = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e) {
                throw new Exception("Du lieu nhap vao khong hop le");
            }
            if (a < 0 || b < 0) throw new Exception("Do dai khong duoc la so am");
            if (a < b) throw new Exception("Chieu dai khong duoc be hon chieu rong");
        }
        catch (Exception e) {
            Console.WriteLine(e.Message.ToString());    
        }


    }
}