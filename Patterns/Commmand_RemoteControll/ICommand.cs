namespace Commmand_RemoteControll
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }

    public class ApplianceControlOnCommand : ICommand
    {
        private ApplianceControl _applianceControl;
        
        public ApplianceControlOnCommand(ApplianceControl applianceControl)
        {
            _applianceControl = applianceControl;
        }
        public void Execute()
        {
            _applianceControl.On();
        }

        public void Undo()
        {
            _applianceControl.Off();
        }
    }
    
    public class ApplianceControlOffCommand : ICommand
    {
        private ApplianceControl _applianceControl;
        
        public ApplianceControlOffCommand(ApplianceControl applianceControl)
        {
            _applianceControl = applianceControl;
        }
        public void Execute()
        {
            _applianceControl.Off();
        }

        public void Undo()
        {
            _applianceControl.On();
        }
    }

    public class StereoOnCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd();
        }

        public void Undo()
        {
            _stereo.RemoveDvd();
            _stereo.Off();
        }
    }
    
    public class StereoOffCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOffCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.RemoveDvd();
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
            _stereo.SetCd();
        }
    }
    
    public class FaucetOnCommand : ICommand
    {
        private readonly FaucetControl _faucetControl;

        public FaucetOnCommand(FaucetControl faucetControl)
        {
            _faucetControl = faucetControl;
        }
        public void Execute()
        {
            _faucetControl.openValue();
        }

        public void Undo()
        {
            _faucetControl.closeValue();
        }
    }
    
    public class FaucetOffCommand : ICommand
    {
        private readonly FaucetControl _faucetControl;

        public FaucetOffCommand(FaucetControl faucetControl)
        {
            _faucetControl = faucetControl;
        }
        public void Execute()
        {
            _faucetControl.closeValue();
        }

        public void Undo()
        {
            _faucetControl.openValue();
        }
    }
    
    public class TVOnCommand: ICommand
    {
        private readonly TV _tv;

        public TVOnCommand(TV tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.On();
        }

        public void Undo()
        {
            _tv.Off();
        }
    }
    
    public class TVOffCommand: ICommand
    {
        private readonly TV _tv;

        public TVOffCommand(TV tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.Off();
        }

        public void Undo()
        {
            _tv.On();
        }
    }
    
    public class GarageDoorOnCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorOnCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.LightOn();
            _garageDoor.Up();
            _garageDoor.Stop();
            _garageDoor.LightOff();
        }

        public void Undo()
        {
            _garageDoor.LightOn();
            _garageDoor.Down();
            _garageDoor.Stop();
            _garageDoor.LightOff();
        }
    }
    
     
    public class GarageDoorOffCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorOffCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.LightOn();
            _garageDoor.Down();
            _garageDoor.Stop();
            _garageDoor.LightOff();
        }

        public void Undo()
        {
            _garageDoor.LightOn();
            _garageDoor.Up();
            _garageDoor.Stop();
            _garageDoor.LightOff();
        }
    }
}