using System;
using System.Collections.Generic;
using System.Text;

namespace Utilisateurs
{//définition de l'activité complémentaire
    //Channa
    class ActiviteComplementaire
    {
        private int ac_id;
        private DateTime ac_date;
        private string ac_lieu;
        private string ac_theme;
        private string ac_motif;


        public int Ac_id
        {
            get { return ac_id; }
            set { ac_id = value ;}    

        }

        public int Ac_date
        {
            get { return ac_date; }
            set { ac_date = value ;}    

        }

        public int Ac_lieu
        {
            get { return ac_lieu; }
            set { ac_lieu = value ;}    

        }

        public int Ac_theme
        {
            get { return ac_theme; }
            set { ac_theme = value ;}    

        }

        public int Ac_motif
        {
            get { return ac_motif; }
            set { ac_motif = value ;}    

        }

        // contructeur : 
        public ActiviteComplementaire(Ac_id ac_id,Ac_date ac_date, Ac_lieu ac_lieu,Ac_theme ac_theme, Ac_motif ac_motif)
        {
            this.ac_id = ac_id;
            this.ac_date = ac_date;
            this.ac_lieu = ac_lieu;
            this.ac_theme = ac_theme;
            this.ac_motif = ac_motif;
        }
    }
}
