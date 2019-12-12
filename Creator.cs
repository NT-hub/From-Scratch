using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromScratch
{
    public  abstract class Creator
    {
        private int _creativitylevel = 100;
        private int _energy = 100;
        public int CreativityLevel
        {
            get
            {
                return _creativitylevel;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _creativitylevel = value;
                }
                else
                {
                    throw new Exception("Creativity level can only be a value between 0 and 100");
                }
            }
        }
        public int Energy
        {
            get
            {
                return _energy;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _energy = value;
                }
                else
                {
                    throw new Exception("Energy can only be a value between 0 and 100");
                }
            }
        }
        public abstract void Create();
    }
}
