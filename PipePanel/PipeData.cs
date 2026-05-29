using System.Collections.Generic;

namespace PipePanel
{
    public static class PipeData
    {
        public static readonly IReadOnlyList<string> Diameters = new List<string>
        {
            "DN15 (1/2in)",
            "DN20 (3/4in)",
            "DN25 (1in)",
            "DN32 (1-1/4in)",
            "DN40 (1-1/2in)",
            "DN50 (2in)",
            "DN65 (2-1/2in)",
            "DN80 (3in)",
            "DN100 (4in)",
            "DN125 (5in)",
            "DN150 (6in)",
            "DN200 (8in)"
        };

        public static readonly IReadOnlyList<string> Systems = new List<string>
        {
            "Cold Water Supply (CWS)",
            "Hot Water Supply (HWS)",
            "Hot Water Return (HWR)",
            "Chilled Water Supply (CHWS)",
            "Chilled Water Return (CHWR)",
            "Cooling Tower Supply (CTS)",
            "Cooling Tower Return (CTR)",
            "Fire Protection (FPS)",
            "Sanitary Drain (SWD)",
            "Waste Drain (WWD)",
            "Storm Drain (RWD)",
            "Vent Pipe (VENT)"
        };
    }
}
