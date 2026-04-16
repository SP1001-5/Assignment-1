using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_3
{
    internal class MobilePhone
    {
        public delegate void RingEventHandler();
        public event RingEventHandler OnRing;
        public void ReceiveCall()
        {
            Console.WriteLine("Incoming..");
            if(OnRing != null) 
                OnRing();
        }
    }

    class RingtonePlayer
    {
        public void PlayRingtone()
        {
            Console.WriteLine("Playing ringtone...");
        }
    }
    
    class ScreenDisplay
    {
        public void CallerInfo()
        {
            Console.WriteLine("Displaying caller information...");
        }
    }

    class VibrationMotor
    {
        public void Vibration()
        {
            Console.WriteLine("Phone is vibrating...");
        }
    }

    class Primary
    {
        static void Main()
        {
            MobilePhone mobilephone = new MobilePhone();
            RingtonePlayer ringtonePlayer = new RingtonePlayer();
            ScreenDisplay screendisplay = new ScreenDisplay();
            VibrationMotor vibrationMotor = new VibrationMotor();

            mobilephone.OnRing += ringtonePlayer.PlayRingtone;
            mobilephone.OnRing += screendisplay.CallerInfo;
            mobilephone.OnRing += vibrationMotor.Vibration;
            mobilephone.ReceiveCall();

        }
    }
}
