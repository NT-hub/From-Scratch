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
            if (base.CreativityLevel >= 50 & base.Energy >= 50) {
            this.BrainstormVideoIdeas();
            this.CreateScript();
            this.VideotapeScript();
            this.EditingVideo();
            this.RenderingVideo();
            }
            else
            {
                throw new Exception("Cannot create a video.Out of ideas and/or tired ");
            }
        }
        //---Encapsilation(it is hiding these methods)---
        // these private access modifier just exposing these
        //functions inside of Youtuber class(in this case).
        private void BrainstormVideoIdeas()
        {
            base.CreativityLevel = base.CreativityLevel - 5;
            base.Energy = base.Energy - 5;
            Console.WriteLine("Brainstorming video ideas...");
        }
        private void CreateScript()
        {
            base.CreativityLevel = base.CreativityLevel - 5;
            base.Energy = base.Energy - 5;
            Console.WriteLine("Creating video script...");
        }
        private void VideotapeScript()
        {
            base.CreativityLevel = base.CreativityLevel - 1;
            base.Energy = base.Energy - 10;
            Console.WriteLine("Videotaping myself executing the script...");
        }
        private void EditingVideo()
        {
            base.CreativityLevel = base.CreativityLevel - 5;
            base.Energy = base.Energy - 5;
            Console.WriteLine("Editing the video...");
        }
        private void RenderingVideo()
        {
            base.CreativityLevel = base.CreativityLevel - 1;
            base.Energy = base.Energy - 1;
            Console.WriteLine("Rendering the video...");
        }
    }
}
