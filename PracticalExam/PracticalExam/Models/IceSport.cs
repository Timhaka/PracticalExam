using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExam.Models
{
    class IceSport : Sport
    {
        public bool HasAStick { get; set; }
        public int IceSize { get; set; }
        

        public IceSport(string name, string description, bool hasAStick, int iceSize)
        {
            Name = name;
            Description = description;
            HasAStick = hasAStick;
            IceSize = iceSize;

        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Ice size is: {IceSize} Meters \n";
        }


    }
}
