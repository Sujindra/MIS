using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIIS.Model
{
    public class Product
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        private float _costPerUnit;

        public float CostPerUnit
        {
            get { return _costPerUnit; }
            set { _costPerUnit = value; }
        }

        private string _totalCost;

        public string TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

    }
}
