using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archerisms_Windows8
{
    public class Character
    {
        public string Name { get; set; }
        public List<SoundByte> SoundBytes { get; set; }
        public string ImageLocation { get; set; }
        public string HeadLocation { get; set; }
        public int SortOrder { get; set; }

        public Character()
        {
            SoundBytes = new List<SoundByte>();
        }
    }
}
