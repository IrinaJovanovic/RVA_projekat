using Baza.Baza;
<<<<<<< HEAD
using Baza.Servis;
using Common.DTO;
=======
>>>>>>> 3391f6091eefa9c4d3d6dfa8d784624df25b3975
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    class Program
    {
        private static ServerServis serverServis = new ServerServis();
        static void Main(string[] args)
        {
<<<<<<< HEAD
            insertData();
            test2();
            test1();
            test2();
           // insertData();

            
            Console.Read();
            serverServis.ObrisiBazuJerJeEntityRetardiran();
        }

        private static void test2()
        {
            foreach (var item in serverServis.ReadAllDonor())
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void test1()
        {
               
            char[] krvnaGrupa = { 'A' };

            DonorDTO donorDTO = new DonorDTO();
            donorDTO.Id = 1;
            donorDTO.KrvnaGrupa = krvnaGrupa;
            serverServis.UpdateDonor(donorDTO);
            

            return;
        }

        private static void insertData()
        {
            
            char[] krvnaGrupa = { 'A' };

            DonorDTO donorDTO = new DonorDTO();
            donorDTO.Ime = "Ime";
            donorDTO.KrvnaGrupa = krvnaGrupa;
            donorDTO.Prezime = "prezime";
            DonorDTO retVal = serverServis.CreateDonor(donorDTO);

            
=======



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
>>>>>>> 3391f6091eefa9c4d3d6dfa8d784624df25b3975
        }
    }
}
