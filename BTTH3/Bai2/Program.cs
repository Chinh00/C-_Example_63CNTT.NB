using System;
public class Tester
{
    public static void Main()
    {
        
            uint so1 = 0;
            int so2, so3;


            try
            {
            checked
            {
                so2 = -10;
                so3 = 0;
                // tính giá trị lại
                so1 -= 5;
                so2 = 5 / so3;
                Console.WriteLine("So 1: {0}, So 2:{1}", so1, so2);
            }

        }

        catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        // xuất kết quả
    }
}