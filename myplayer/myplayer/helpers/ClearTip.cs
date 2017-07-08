using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myplayer.helpers
{
    //清除视频左上方的提示
    public class ClearTip
    {
        private static AxAPlayer3Lib.AxPlayer player;
        private static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public static void Clear(AxAPlayer3Lib.AxPlayer p, int time)
        {
            timer.Enabled = false;
            player = p;
            timer.Interval = time;
            timer.Tick += new EventHandler(time_tick);
            timer.Start();
        }

        private static void time_tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            player.SetConfig(602, "0");//激活视频叠加图功能, 1-激活, 0-不激活
        }
    }
}
