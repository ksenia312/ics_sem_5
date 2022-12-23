using System;

namespace ex_06
{
    internal class CurlyHairCut : HairCut
    {
        public CurlyHairCut() : base()
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
                    style_steps.AddRange(new List<string> { "Rinse", "Trim", "Straighten", "Dry" });
                    break;
                case 2: // curly hair
                    style_steps.AddRange(new List<string> { "The hair is already curly!" });
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
