using System;
using System.Collections.Generic;
using System.Text;

namespace Utilisateurs
{//Channa
    class Rapport_Visite
    {
        private int id;
        private string vis_matricule;
        private int rap_num;
        private int pra_num;
        private DateTime rap_date;
        private string rap_bilan;
        private string rap_motif;

    }

     public int Id
        {
            get { return id; }
            set { id = value ;}    

        }

     public string Vis_matricule
        {
            get { return vis_matricule; }
            set { vis_matricule = value ;}    

        }

     public string Rap_num
        {
            get { return rap_num; }
            set { rap_num = value ;}    

        }

     public string Pra_num
        {
            get { return pra_num; }
            set { pra_num = value ;}    

        }

     public string Rap_date
        {
            get { return rap_date; }
            set { rap_date = value ;}    

        }

     public string Rap_bilan
        {
            get { return rap_bilan; }
            set { rap_bilan = value ;}    

        }

     public string Rap_motif
        {
            get { return rap_motif; }
            set { rap_motif = value ;}    

        }

    
        // contructeur : 
      public Rapport_Visite(Rap_id rap_id,Vis_matricule vis_matricule,Rap_num rap_num,Pra_num pra_num, Rap_date rap_date, Rap_bilan rap_bilan, Rap_motif rap_motif)
     
        {
           
        this.rap_id = rap_id;
        this.vis_matricule = vis_matricule;
        this.rap_num = rap_num;
        this.pra_num= pra_num;
        this.rap_date = rap_date;
        this.rap_bilan = rap_bilan;
        this.rap_motif = rap_motif;

       }
}
