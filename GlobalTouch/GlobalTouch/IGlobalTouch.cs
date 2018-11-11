using System;

namespace Custom
{

    public interface IGlobalTouch
    {
        void TapScreen(EventHandler handler);
        void TapScreen();
    }
}
