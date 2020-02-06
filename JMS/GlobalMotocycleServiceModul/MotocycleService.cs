using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalMotocycleServiceModul
{
    public delegate void MotoServiceDelegate(int totalDistance);

    public class MotocycleService
    {
        private MotoServiceDelegate _motoServiceDelegate;
        //public static int TotalDistance { get;  set; }
        public static int DistanceFromService { get;  set; }

        public MotocycleService()
        {
            CheckDistance();
        }
        public MotocycleService(MotoServiceDelegate motoServiceDelegate)
        {
            _motoServiceDelegate = motoServiceDelegate;
        }
        void CheckDistance()
        {
            if(DistanceFromService >= 9800)
            {
                //Notify
                NotifyAboutService();
            }
        }

        void NotifyAboutService()
        {
            
            _motoServiceDelegate(DistanceFromService);
            ResetDistance();
        }
        void ResetDistance()
        {
            DistanceFromService = 0;
        }
    }
}
