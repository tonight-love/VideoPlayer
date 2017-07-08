using myplayer.helpers;
using myplayer.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myplayer.service
{
    public class PlayUtils
    {
        //打开一个文件
        public static VideoItem OpenFile()
        {
            //打开文件选择框
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "媒体文件|*.mp4;*.avi;*.rm;*.rmvb;*.flv;*.mkv;*.wmv;|所有文件|*.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //新建视频实体
                VideoItem newVideo = new VideoItem(dialog.SafeFileName, dialog.FileName);
                //支持此视频格式
                if (PlayHelper.isRightExt(newVideo)) 
                    return newVideo;
            }
            return null;
        }
    }
}
