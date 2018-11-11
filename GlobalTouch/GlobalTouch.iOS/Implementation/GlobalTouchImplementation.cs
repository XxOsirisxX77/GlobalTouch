using System;
using Custom;

namespace iOS.Implementation
{

    public class GlobalTouchImplementation : IGlobalTouch
    {
        EventHandler globalTouchHandler;

        public void TapScreen(EventHandler handler)
        {
            globalTouchHandler = handler;
        }

        public void TapScreen()
        {
            globalTouchHandler?.Invoke(this, null);
        }

    }

}