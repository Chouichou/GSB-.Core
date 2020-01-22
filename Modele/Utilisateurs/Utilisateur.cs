using Medicaments;
using System;
using System.Collections.Generic;
using System.Text;
using Utilisateurs;

namespace Utilisateurs
{
    public abstract class Utilisateur : IUtilisateur
    {//Anna
        private int Id_Util;
        private string Nom;
        private string Prenom;
        private string Adresse;
        private int Cp;
        private string Ville;
        private DateTime DateEmbauche;
        private int Code_Secteur;
        private int Code_Lab;

        public void Connecter()
        {
            
        }

        public void Consulter()
        {
            
        }

        public void Inviter()
        {
            
        }



        public void Posseder()
        {
            
        }


        public void Travailler()
        {
          
        }

        void IUtilisateur.Offrir()
        {
            
        }

        void IUtilisateur.Realiser()
        {
            
        }
    }
}
