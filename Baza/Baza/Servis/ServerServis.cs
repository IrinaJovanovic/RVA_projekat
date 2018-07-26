using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza.Baza;
using Common.DTO;


namespace Baza.Servis
{
    public class ServerServis : IDonorServis
    {


        

        public DonorDTO CreateDonor(DonorDTO donorDTO)
        {
            Donor retVal = null;
            using (var context = new BankaContext()) //citava baza mi je u prom context sada 
            {
                retVal = new Donor(donorDTO);
                context.Donori.Add(retVal);
                context.SaveChanges();
                                


            }
            if(retVal==null)
            {
                return null;
            }
            return new DonorDTO(retVal.Id, retVal.Ime, retVal.KrvnaGrupa, retVal.Prezime);
        }

        public DonorDTO DeleteDonor(DonorDTO donorDTO)
        {
            // throw new NotImplementedException();
            Donor retVal = null;
            using (var context = new BankaContext())
            {
                foreach (var item in context.Donori)
                {
                    if(item.Id.Equals(donorDTO.Id))
                    {
                        retVal = item;
                        break;
                    }
                }
                if(retVal==null)
                {
                    return null;
                }


         
                context.Donori.Remove(retVal);
                context.SaveChanges();
            }
            
                 return new DonorDTO(retVal.Id, retVal.Ime, retVal.KrvnaGrupa, retVal.Prezime);
        }

        public List<DonorDTO> ReadAllDonor()
        {
            // throw new NotImplementedException();
            List<DonorDTO> povratna = new List<DonorDTO>();
            using (var context = new BankaContext())
            {
                foreach (var item in context.Donori)
                {
                    povratna.Add(new DonorDTO(item.Id, item.Ime, item.KrvnaGrupa, item.Prezime));
                }
            }
            return povratna;

           
        }

        public List<DonorDTO> ReadByFilterDonor(DonorDTO donorDTO)
        {
            // throw new NotImplementedException();
            List<DonorDTO> povratna = new List<DonorDTO>();
            using (var context = new BankaContext())
            {
                foreach (var item in context.Donori)
                {
                    if (item.MatchesFilter(donorDTO))
                    {
                        povratna.Add(new DonorDTO(item.Id, item.Ime, item.KrvnaGrupa, item.Prezime));
                    }
                }
            }
            return povratna;

        }

        public bool UpdateDonor(DonorDTO donorDTO)
        {
            using (var context = new BankaContext())
            {
                Donor noviDonor = new Donor(donorDTO);
                Donor stariDonor =null;
                foreach (var item in context.Donori)
                {
                    if (item.Id.Equals(donorDTO.Id))
                    {
                        stariDonor = item;
                        break;
                    }
                }
                if (stariDonor != null)
                {
                    stariDonor = noviDonor;
                }

                

                
                context.SaveChanges();
            }
            return true;
        }

        public void ObrisiBazuJerJeEntityRetardiran()
        {
            using (var context = new BankaContext())
            {
                context.Database.Delete();
            }
                
        }
    }
}
