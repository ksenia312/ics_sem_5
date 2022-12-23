using System;

namespace ex_06
{
    abstract class HairCut
    {

        public List<string> style_steps = new List<string>();

        public List<string> style_variants = new List<string>()
                    {
                        "long hair",
                        "short hair",
                        "curly hair",
                        "bald"
                    };


        // it's a template method
        // method "cut" uses style via preferred style index for every instance
        public void make_style(int preferred_style_index)
        {
            clear_steps();
            make_process(preferred_style_index);
            print_process(preferred_style_index);
        }
        private void clear_steps()
        {
            style_steps.Clear();
        }
        public abstract void make_process(int preferred_style_index);

        private void print_process(int preferred_style_index)
        {
            Console.WriteLine($"Here is the process for {ToString().Split('.')[1]} to " +
                $"create '{style_variants[preferred_style_index]}' style");

            foreach (var step in style_steps)
            {
                Console.WriteLine($"\t{style_steps.IndexOf(step) + 1}. {step}");
            }
        }
    }

}
