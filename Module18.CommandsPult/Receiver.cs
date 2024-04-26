using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.CommandsPult
{
    internal class Receiver
    {
    }

    class TV
    {
        public Volume volume;
        public TV()
        {
            volume = new Volume();
        }
        public void On()
        {
            Console.WriteLine("Телевизор включен!");
        }

        public void Off()
        {
            Console.WriteLine("Телевизор выключен...");
        }
    }

    class Volume
    {
        public const int OFF = 0;
        public const int HIGH = 20;
        public const int BASE = 7;
        private int level;
        private int previousLevel;

        public Volume()
        {
            level = BASE;
        }

        public void RaiseLevel()
        {
            if (level < HIGH)
                level++;
            ShowNotify(level);
        }

        private void ShowNotify(int level)
        {
            Console.WriteLine("Уровень звука {0}", level);
        }

        public void ShowNotify(bool isMuted)
        {
            if (isMuted)
                Console.WriteLine("Volume muted!");
        }

        public void DropLevel()
        {
            if (level > OFF)
                level--;
            ShowNotify(level);
        }

        public void Mute()
        {
            previousLevel = level;
            level = 0;
            ShowNotify(true);
        }

        public void UnMute()
        {
            if (previousLevel > OFF)
            {
                level = previousLevel;
                ShowNotify(level);
            }
        }
    }
}
