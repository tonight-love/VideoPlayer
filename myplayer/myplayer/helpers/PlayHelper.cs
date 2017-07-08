using myplayer.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

namespace myplayer.helpers
{
    public class PlayHelper
    {
        //根据拓展格式，判断是否支持此文件类型
        public static bool isRightExt(VideoItem item)
        {
            string[] strArray = new string[] { ".avi", ".mp4", ".rm", ".mkv", ".wmv", ".rmvb", ".flv", ".mov", ".mpg", ".divx", ".xvid" };
            foreach (string str in strArray)
            {
                //找到此拓展格式
                if (item.Ext.ToLower() == str)
                {
                    return true;
                }
            }
            return false;
        }

        //获得时间字符串
        public static string GetTime(long ms)
        {
            int num = (int)ms / 0x3e8;
            string str = "00:00";
            if (num > 0)
            {
                int num2 = num / 60;
                int num3 = num % 60;
                str = ((num2 < 10) ? ("0" + num2.ToString()) : num2.ToString()) + ":" + ((num3 < 10) ? ("0" + num3.ToString()) : num3.ToString());
            }
            return str;
        }

        /// <summary>
        /// 递归获取文件夹目录下文件
        /// </summary>
        /// <param name="pathName">需要递归遍历的文件夹</param>
        /// <param name="fileRule">遍历规则，委托</param>
        public static void LoopFolder(string pathName, Action<FileInfo> fileRule)
        {
            if (string.IsNullOrEmpty(pathName))
            {
                throw new ArgumentNullException(pathName);
            }
            try
            {
                DirectorySecurity security = new DirectorySecurity(pathName, AccessControlSections.Access);
                if (!security.AreAccessRulesProtected)
                {
                    DirectoryInfo myinfo = new DirectoryInfo(pathName);
                    foreach (FileInfo info in myinfo.GetFiles())
                    {
                        fileRule(info);
                    }
                }
            }
            catch
            {
            }
        }
    }
}
