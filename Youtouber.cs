using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromScratch
{
    public class Youtuber : Creator
    {
        public override void Create()
        {
            this.BrainstormSolutions();
            this.PickMostOptimalSolution();
            this.WriteCode();
            this.TestCode();
        }
        private void BrainstormSolutions()
        {
            base.CreativityLevel = base.CreativityLevel - 15;
            base.Energy = base.Energy - 10;
            Console.WriteLine("Brainstorming solution...");
        }
        private void PickMostOptimalSolution()
        {
            base.CreativityLevel = base.CreativityLevel - 5;
            base.Energy = base.Energy - 5;
            Console.WriteLine("Picking optimal solution...");
        }
        private void WriteCode()
        {
            base.CreativityLevel = base.CreativityLevel - 7;
            base.Energy = base.Energy - 5;
            Console.WriteLine("Writing Code...");
        }
        private void TestCode()
        {
            base.CreativityLevel = base.CreativityLevel - 3;
            base.Energy = base.Energy - 3;
            Console.WriteLine("Testing Code...");

        }
    }
}
