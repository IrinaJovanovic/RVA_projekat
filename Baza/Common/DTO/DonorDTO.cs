using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class DonorDTO
    {
        private int id;
        private string ime;
        private char[] krvnaGrupa = new char[3];
        private string prezime;

        public DonorDTO(int id, string ime, char[] krvnaGrupa, string prezime)
        {
            this.id = id;
            this.ime = ime;
            this.krvnaGrupa = krvnaGrupa;
            this.prezime = prezime;
        }

        public DonorDTO()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public char[] KrvnaGrupa { get => krvnaGrupa; set => krvnaGrupa = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(id);
            stringBuilder.Append("  ");
            stringBuilder.Append(ime);
            stringBuilder.Append("  ");
            stringBuilder.Append(prezime);
            stringBuilder.Append("  ");
            for (int i = 0; i < krvnaGrupa.Length; i++)
            {
                stringBuilder.Append(krvnaGrupa[i]);
            }

            return stringBuilder.ToString();
        }
    }
}
