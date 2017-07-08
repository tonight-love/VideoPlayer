using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myplayer.model
{
    //视频实体类
    public class VideoItem
    {
        private string name;//文件名
        private string url;//文件路径
        private string ext;//拓展格式
        private bool isPlaying;//是否播放

        public VideoItem(string name, string url)
        {
            this.name = name;
            this.url = url;
            this.ext = name.Substring(name.LastIndexOf("."));
            this.isPlaying = false;
        }

        //重写Equals和GetHashCode方法
        public override bool Equals(object obj)
        {
            return (this.url == ((VideoItem)obj).url);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public string Ext
        {
            get
            {
                return ext;
            }

            set
            {
                ext = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }

        public bool IsPlaying
        {
            get
            {
                return isPlaying;
            }

            set
            {
                isPlaying = value;
            }
        }
    }



}
