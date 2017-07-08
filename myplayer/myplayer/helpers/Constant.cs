using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myplayer.helpers
{
    public class Constant
    {
        public enum N_MESSAGE
        {
            DOUBLE_LEFT_CLICK = 0x203,
            LEFT_CLICK = 0x201,
            LEFT_CLICK_OUT = 0x202,
            MOVE = 0x200,
            RIGHT_CLICK_OUT = 0x205,
            RIGHT_CLICK_IN = 0x204
        }

        public enum PLAY_STATE
        {
            PS_READY,
            PS_OPENING,
            PS_PAUSING,
            PS_PAUSED,
            PS_PLAYING,
            PS_PLAY,
            PS_CLOSING
        }

        public enum Scroll_State
        {
            None,
            NormalMove,
            ManualMove,
            MoveBegin,
            MoveEnd
        }
    }
}
