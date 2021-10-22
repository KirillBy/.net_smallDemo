using System;

namespace Commmand_RemoteControll
{
    class Program
    {
        static void Main(string[] args)
        {
            FaucetControl faucetControl = new FaucetControl();
            Stereo stereo = new Stereo();
            ApplianceControl applianceControl = new ApplianceControl();
            TV tv = new TV();
            GarageDoor garageDoor = new GarageDoor();
            
            RemoteControll remoteControll = new RemoteControll();
            remoteControll.SetCommand(1, new FaucetOnCommand(faucetControl), new FaucetOffCommand(faucetControl));
            remoteControll.SetCommand(2, new StereoOnCommand(stereo), new StereoOffCommand(stereo));
            remoteControll.SetCommand(3, new ApplianceControlOnCommand(applianceControl), new ApplianceControlOffCommand(applianceControl));
            remoteControll.SetCommand(4, new TVOnCommand(tv), new TVOffCommand(tv));
            remoteControll.SetCommand(5, new GarageDoorOnCommand(garageDoor), new GarageDoorOffCommand(garageDoor));
            
            remoteControll.onButtonPushed(1);
            remoteControll.offButtonPushed(1);
            remoteControll.onButtonPushed(2);
            remoteControll.offButtonPushed(2);
            remoteControll.onButtonPushed(3);
            remoteControll.offButtonPushed(3);
            remoteControll.onButtonPushed(4);
            remoteControll.offButtonPushed(4);
            remoteControll.onButtonPushed(5);
            remoteControll.offButtonPushed(5);
            remoteControll.undoButtonPushed();
            remoteControll.undoButtonPushed();
            remoteControll.undoButtonPushed();
            remoteControll.undoButtonPushed();
            remoteControll.undoButtonPushed();
            remoteControll.undoButtonPushed();
        }
    }
}
