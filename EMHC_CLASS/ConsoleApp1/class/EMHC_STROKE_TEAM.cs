using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 急性腦中風醫療領域-急性腦中風照護團隊
    /// </summary>
    public class EMHC_STROKE_TEAM
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
        /// 類別
        /// 1.神經科專科醫師
        /// 2.神經外科專科醫師
        /// 3.腦中風個案管理師
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// 人數
        /// </summary>
        public int? NUMBER { get; set; }

        /// <summary>
        /// 專任醫師數
        /// </summary>
        public int? FULL_TIME_DOCS { get; set; }

        /// <summary>
        /// 支援醫師數
        /// </summary>
        public int? SUPPORT_DOCS { get; set; }

        /// <summary>
        /// 支援時數
        /// </summary>
        [MaxLength(15)]
        public string SUPPORT_HOURS { get; set; }

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






