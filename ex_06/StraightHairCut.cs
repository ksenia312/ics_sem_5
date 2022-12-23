using System;

namespace ex_06
{
    internal class StraightHairCut : HairCut
    {
        public StraightHairCut() : base()
        {
        }

        public override void make_process(int preferred_style_index)
        {
            switch (preferred_style_index)
            {
                case 0: // long hair
                    style_steps.AddRange(new List<string> { "Rinse", "Dry", "Extend" });
                    break;
                case 1: // short hair
                    style_steps.AddRange(new List<string> { "Rinse", "Trim", "Dry" });
                    break;
                case 2: // curly hair
                    style_steps.AddRange(new List<string> { "Rinse", "Dry", "Curl" });
                    break;
                case 3: // bald
                    style_steps.AddRange(new List<string> { "Shave" });
                    break;
                default: 
                    style_steps.AddRange(new List<string> { "We don't know this style ((" });
                    break;
            }
        }
    }
}
