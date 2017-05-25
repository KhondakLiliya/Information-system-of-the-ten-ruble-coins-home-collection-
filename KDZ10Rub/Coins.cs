using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDZ10Rub
{
    public class Coins
    {
        private string _mint;

        public string Mint
        {
            get { return _mint; }
            set { _mint = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private int _year;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        

        public Coins(string mint, string description, int year)
        {
            _mint = mint;
            _description = description;
            _year = year;
        }

        public string Information
        {
            get
            {
                return $"{_mint}-{_description}-{_year}";
            }
        }

        #region DynamicSearch
        public string InfMint
        {
            get { return $"{_mint}"; }
        }

        public string InfDescription
        {
            get { return $"{_description}"; }
        }

        public string InfYear
        {
            get { return $"{_year}"; }
        }
        
        #endregion
        
    }
}
