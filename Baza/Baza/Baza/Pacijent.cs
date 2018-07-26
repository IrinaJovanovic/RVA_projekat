///////////////////////////////////////////////////////////
//  Pacijent.cs
//  Implementation of the Class Pacijent
//  Generated by Enterprise Architect
//  Created on:      25-jul-2018 20:36:05
//  Original author: mixa
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace Baza.Baza {
	/// <summary>
	/// Primalac transfuzije
	/// </summary>
	public class Pacijent {

		private int id;
		private string ime;
		private char[] krvnaGrupa = new char[3];
		private string prezime;

		public Pacijent(){

		}

        public Pacijent( string ime, char[] krvnaGrupa, string prezime)
        {
            this.Ime = ime;
            this.KrvnaGrupa = krvnaGrupa;
            this.Prezime = prezime;
        }

        ~Pacijent(){

		}

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public char[] KrvnaGrupa { get => krvnaGrupa; set => krvnaGrupa = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        public override string ToString()
        {
            return Id + "  " + Ime + "  " + KrvnaGrupa.ToString() + "  " + Prezime;  
        }
       
    }//end Pacijent

}//end namespace CrveniKrst