using Baza.Baza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    class Program
    {
        static void Main(string[] args)
        {



            using (var context = new BankaContext())
            {
                char[] temp ={ 'B', '-' };
                context.Pacijenti.Add(new CrveniKrst.Pacijent("ime", temp, "prezime"));
                context.SaveChanges();
            }

            using (var context = new BankaContext())
            {

                foreach (var item in context.Pacijenti)
                {
                    Console.WriteLine(item.ToString());
                }
                
            }
            Console.Read();
        }
    }
}
