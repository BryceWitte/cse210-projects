using System;

class BreathingActivity : Activity
 {
        public BreathingActivity()
        {
            Console.Write("Enter duration (in seconds): ");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        }

        public override void Start()
        {
            base.Start();

            for (int i = 1; i <= duration; i += 2)
            {
                Console.WriteLine("Breathe in...");
                Pause(3);
                Console.WriteLine("Breathe out...");
                Pause(3);
            }

            Finish();
        }
    }
