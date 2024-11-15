using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tAG_DMX
{
    public class SingleFunction
    {
        public string Name { get; set; }
        public string Type { get; set; } // scene, chaser, effect, music, rgbmatrix
        public List<DeviceFunction> Devices { get; set; }
    }

    public class DeviceFunction
    {
        public Device Device { get; set; }
        public List<ChannelValue> ChannelValues { get; set; }
    }

    public class ChannelValue
    {
        public Channel Channel { get; set; }
        public int ChannelStart { get; set; }
        public int Value { get; set; } // 0-255
        public bool Active { get; set; }
    }
}
