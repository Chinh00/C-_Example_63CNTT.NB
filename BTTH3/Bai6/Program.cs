class Program {
    static double ReadNumber(int start, int end) {
        if (start > end) throw new Exception("Gia tri start va end khong hop le");
        double result;
        try {
            Console.Write($"Nhap vao so trong khoang {start} den {end}: ");
            result = Convert.ToDouble(Console.ReadLine());
            if (result > end || result < start) throw new Exception("Gia tri khong nam trong khoang da cho");
            return result;
        } catch (Exception ex) { 
            Console.WriteLine(ex.Message.ToString()); 
            throw new Exception("Chuong trinh dung");
        }
    }
    static void Main(string[] args) {
        try
        {

            var tmp = Double.MinValue;
            for (int i = 0; i < 5; i++)
            {
                var res = ReadNumber(1, 100);
                if (tmp < res)
                {
                    tmp = res;
                }
                else {
                    throw new Exception("So vua nhap khong lon hon so truoc do");
                }

            }
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message.ToString());
        }
    }
}