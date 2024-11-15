using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tAG_DMX
{
    public class Fixture
    {
        public string Model { get; set; }
        public string Vendor { get; set; }
        public string FixtureType { get; set; }
        public List<Mode> Modes { get; set; } = new List<Mode>();
    }

    public class Mode
    {
        public string Name { get; set; }
        public int NumberOfChannels => Channels.Count;
        public List<Channel> Channels { get; set; } = new List<Channel>();
    }

    public class Channel
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }
}
