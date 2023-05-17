using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH2
{
    
    public class Xe 
    {
        public string myName { get; set; }

        public virtual void Who() => Console.WriteLine(myName);

    }

    class Xe_Toyota : Xe {
        public override void Who()
        {
            myName = "Toi la Toyota";
            base.Who();
        }
    }
    class Xe_Dream : Xe
    {
        public override void Who()
        {
            myName = "Toi la Dream";
            base.Who();
        }
    }
    class Xe_DuLich : Xe
    {
        public override void Who()
        {
            myName = "Toi la DuLich";
            base.Who();
        }
    }

    class Tester {
        /*public static void Main(string[] args)
        {
            ICollection<Xe> list = new List<Xe>();
            Console.WriteLine("\t 0 - Xe Toyota \n\t 1 - Xe Dream \n\t 2 - Xe Du Lich");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Nhap lua chon them xe: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Xe xe;
                switch (n)
                {
                    case 0:
                        {
                            xe = new Xe_Toyota();
                            list.Add(xe);
                            break;
                        }
                    case 1:
                        {
                            xe = new Xe_Dream();
                            list.Add(xe);
                            break;
                        }
                    case 2:
                        {
                            xe = new Xe_DuLich();
                            list.Add(xe);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Vui long nhap lua chon!!!");
                            break;
                        }
                }

            }
            Console.WriteLine("Cac xe vua them la: ");
            foreach (Xe xe in list)
            {
                xe.Who();
            }


        }*/
    }

}
