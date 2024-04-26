using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.CommandsPult
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    class TVCommand : ICommand
    {
        TV tv;
        public TVCommand(TV tvSet)
        {
            tv = tvSet;
        }
        public void Execute()
        {
            tv.On();
        }
        public void Undo()
        {
            tv.Off();
        }
    }

    class VolumeCommand : ICommand
    {
        Volume volume;

        public VolumeCommand(Volume v)
        {
            volume = v;
        }

        public void Execute()
        {
            volume.RaiseLevel();
        }

        public void Undo()
        {
            volume.DropLevel();
        }
    }

    class VolumeMuteCommand : ICommand
    {
        Volume volume;

        public VolumeMuteCommand(Volume v)
        {
            volume = v;
        }

        public void Execute()
        {
            volume.Mute();
        }

        public void Undo()
        {
            volume.UnMute();
        }
    }

    class NoCommand : ICommand
    {
        public void Execute()
        {
        }

        public void Undo()
        {
        }
    }
}
