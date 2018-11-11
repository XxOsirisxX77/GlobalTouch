using System;
using GlobalTouch.Droid;
using Custom;

namespace Droid.Implementation
{
    public class GlobalTouchImplementation : IGlobalTouch
    {

        public void TapScreen(EventHandler handler)
        {
            (MainApplication.CurrentContext as MainActivity).globalTouchHandler += handler;
        }

        public void TapScreen()
        {

        }
    }
}