// Template Method

// HairCut is the base class with template method make_style.
// Method make_style uses the base alghoritm: make_process, print_process.
// However, method make_process is unique for every child class

using ex_06;

namespace ex_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HairCut straight_hair = new StraightHairCut();
            HairCut curly_hair = new CurlyHairCut();

            straight_hair.make_style(0);
            curly_hair.make_style(0);

            Console.WriteLine("------------------------------------------");

            straight_hair.make_style(1);
            curly_hair.make_style(1);

            Console.WriteLine("------------------------------------------");

            straight_hair.make_style(2);
            curly_hair.make_style(2);

            Console.WriteLine("------------------------------------------");

            straight_hair.make_style(3);
            curly_hair.make_style(3);
        }
    }
}

/*
Here is the process for StraightHairCut to create 'long hair' style
        1.Rinse
        2.Dry
        3.Extend
Here is the process for CurlyHairCut to create 'long hair' style
        1.Rinse
        2.Dry
        3.Extend
------------------------------------------
Here is the process for StraightHairCut to create 'short hair' style
        1.Rinse
        2.Trim
        3.Dry
Here is the process for CurlyHairCut to create 'short hair' style
        1.Rinse
        2.Trim
        3.Straighten
        4.Dry
------------------------------------------
Here is the process for StraightHairCut to create 'curly hair' style
        1.Rinse
        2.Dry
        3.Curl
Here is the process for CurlyHairCut to create 'curly hair' style
        1.The hair is already curly!
------------------------------------------
Here is the process for StraightHairCut to create 'bald' style
        1.Shave
Here is the process for CurlyHairCut to create 'bald' style
        1.Shave
*/