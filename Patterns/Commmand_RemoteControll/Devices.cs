using System;

namespace Commmand_RemoteControll
{
    public class ApplianceControl
    {
        public void On()
        {
            Console.WriteLine("Appliance is on");
        }

        public void Off()
        {
            Console.WriteLine("Appliance is off");
        }
    }

    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo is on");
        }

        public void Off()
        {
            Console.WriteLine("Stereo is off");
        }

        public void SetCd()
        {
            Console.WriteLine("Cd is chosen on stereo");
        }

        public void RemoveDvd()
        {
            Console.WriteLine("Dvd is removed from stereo");
        }
    }

    public class FaucetControl
    {
        public void openValue()
        {
            Console.WriteLine("Faucet is open");
        }

        public void closeValue()
        {
            Console.WriteLine("Faucet is closed");
        }
    }

    public class TV
    {
        public void On()
        {
            Console.WriteLine("TV is on");
        }

        public void Off()
        {
            Console.WriteLine("TV is off");
        }
    }

    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage door is getting up");
        }

        public void Down()
        {
            Console.WriteLine("Garage door is getting down");
        }

        public void Stop()
        {
            Console.WriteLine("Garage door is stopped");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage light is on");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage light is off");
        }
    }
}