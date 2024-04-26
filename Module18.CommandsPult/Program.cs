using System;

namespace Module18.CommandsPult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TV tv = new TV();
            //Volume volume = new Volume();
            MultiPult mPult = new MultiPult();

            mPult.SetCommand(0, new TVCommand(tv));
            mPult.SetCommand(1, new VolumeCommand(tv.volume));
            mPult.SetCommand(2, new VolumeMuteCommand(tv.volume));

            // включаем телевизор
            mPult.PressButton(0);
            for (int i = 0; i < 15; i++)
            {
                mPult.PressButton(1);
            }
            for (int i = 0; i < 5; i++)
            {
                mPult.PressUndoButton(1);
            }
            Console.WriteLine("Press mute");
            mPult.PressButton(2);
            Console.WriteLine("Press unmute");
            mPult.PressUndoButton(2);
            Console.WriteLine("Press vol+");
            mPult.PressButton(1);

        }
    }
}
