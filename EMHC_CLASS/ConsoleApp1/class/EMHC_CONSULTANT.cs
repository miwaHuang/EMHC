using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 急診醫療領域-有專科醫師緊急會診機制
    /// </summary>
    public class EMHC_CONSULTANT
    {
        /// <summary>
        /// 主鍵值
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        /// <summary>
        /// 監測主檔ID
        /// </summary>
        [ForeignKey("EMHC_MAIN")]
        [Required]
        public long MAIN_ID { get; set; }

        /// <summary>
        /// 等級
        /// 1.中度級
        /// 2.重度級
        /// </summary>
        [Required]
        public int LEVEL { get; set; }

        /// <summary>
        /// 類別
        /// 【中度級】
        /// 1.急診緊急會診外科、內科、骨科之總人次
        /// 2.急診緊急會診外科、內科、骨科於60分鐘內可獲得支援之人次
        /// 3.百分比
        /// 【重度級】
        /// 1.急診緊急會診外科、內科、骨科、兒科、麻醉科、神經科、神經外科、婦產科之總人次
        /// 2.急診緊急會診外科、內科、骨科、兒科、麻醉科、神經科、神經外科、婦產科於30分鐘內可獲得支援之人次
        /// 3.百分比
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// 人次
        /// </summary>
        public decimal? NUMBER { get; set; }

        /// <summary>
        /// 建立人員
        /// </summary>
        [MaxLength(15)]
        public string CT_UID { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        [Required]
        public DateTime CT_DATE { get; set; }

        /// <summary>
        /// 更新人員
        /// </summary>
        [MaxLength(15)]
        public string UP_UID { get; set; }

        /// <summary>
        /// 更新時間
        /// </summary>
        public DateTime? UP_DATE { get; set; }
    }
}





