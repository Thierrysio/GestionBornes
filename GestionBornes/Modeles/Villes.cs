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
         #endregion

        #region Methodes

        #endregion
    }
}
