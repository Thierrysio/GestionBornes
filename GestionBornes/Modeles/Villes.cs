using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBornes.Modeles
{
    public class Villes
    {
        #region Attributs
        private int _id;
        private string _nom;
        private List<Bornes> _lesBornes;
        
        #endregion

        #region Constructeurs

        public Villes()
        {
        }



        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        [OneToMany]
        public List<Bornes> LesBornes { get => _lesBornes; set => _lesBornes = value; }
        #endregion

        #region Methodes
        public Villes AjoutVille(string nom)
        {
            this.Id = 0;
            this.Nom = nom;
            this.LesBornes = new List<Bornes>();
            return this;
            
        }
        #endregion
    }
}
