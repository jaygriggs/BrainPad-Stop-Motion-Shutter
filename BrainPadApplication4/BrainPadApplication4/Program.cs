using System.Threading;
using GHIElectronics.TinyCLR.BrainPad;

namespace BrainPadApplication4
{
    class Program
    {

        //public bool GameHasStarted;
        private double _LightSpeed = .1;


        public void BrainPadSetup()
        {
            //Put your setup code here. It runs once when the BrainPad starts up.

            BrainPad.Display.DrawTextAndShowOnScreen(1, 0, "Stop\r\nMotion\r\nShutter");
            BrainPad.Wait.Seconds(1);
                BrainPad.Display.DrawSmallTextAndShowOnScreen(1, 0,
                    "The Light Will\r\nFlicker.\r\nPress Button \r\nDirections To \r\nChange The Speed");


            

        }

        public void BrainPadLoop()
        {


            if (BrainPad.Buttons.IsRightPressed())
            {
                _LightSpeed = _LightSpeed + .001;
                if (_LightSpeed <= 0)
                {
                    _LightSpeed = .001;
                }
                BrainPad.Display.DrawTextAndShowOnScreen(0,0, "" + _LightSpeed);

            }
            if (BrainPad.Buttons.IsLeftPressed())
            {
                _LightSpeed = _LightSpeed - .001;
                if (_LightSpeed <= 0)
                {
                     _LightSpeed = .001;
                }
                BrainPad.Display.DrawTextAndShowOnScreen(0, 0, "" + _LightSpeed);

            }
            if (BrainPad.Buttons.IsUpPressed())
            {
                _LightSpeed = _LightSpeed + .020;
                if (_LightSpeed <= 0)
                {
                    _LightSpeed = .001;
                }
                BrainPad.Display.DrawTextAndShowOnScreen(0, 0, "" + _LightSpeed);
            }
            if (BrainPad.Buttons.IsDownPressed())
            {
                _LightSpeed = _LightSpeed - .020;
                if (_LightSpeed <= 0)
                {
                    _LightSpeed = .001;
                }
                BrainPad.Display.DrawTextAndShowOnScreen(0, 0, "" + _LightSpeed);
            }


            {


                //Put your program code here. It runs repeatedly after the BrainPad starts up.



                BrainPad.LightBulb.TurnWhite();
                Thread.Sleep(1);
                BrainPad.LightBulb.TurnOff();
                BrainPad.Wait.Seconds(_LightSpeed);


            }
        }




    }
}
