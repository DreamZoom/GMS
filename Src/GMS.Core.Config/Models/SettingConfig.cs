using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMS.Core.Config
{
    /// <summary>
    /// 数据库配置
    /// </summary>
    [Serializable]
    public class SettingConfig : ConfigFileBase
    {
        public SettingConfig()
        {
        }

        #region 序列化属性
        public String WebSiteTitle { get; set; }
        public String WebSiteDescription { get; set; }
        public String WebSiteKeywords { get; set; }

        public List<Banner> Banners { get; set; }
        #endregion
    }

    [Serializable]
    public class Banner
    {
        public string BannerSrc { get; set; }

        public string Title { get; set; }
    }
}
