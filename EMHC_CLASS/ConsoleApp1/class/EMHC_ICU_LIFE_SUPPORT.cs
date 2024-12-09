using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 加護病房照護領域 (維生措施)
    /// </summary>
    public class EMHC_ICU_LIFE_SUPPORT
    {
        /// <summary>
        /// 主鍵值
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        /// <summary>
        /// 加護病房ID
        /// </summary>
        [ForeignKey("EMHC_ICU")]
        [Required]
        public long ICU_ID { get; set; }

        /// <summary>
        /// 類別
        /// 1. 加護病房每10床應有專責專科醫師1人以上，負責加護病房醫療業務，並具備相關人員諮詢
        /// 2. 組成跨領域之加護病房照護團隊
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// 登記開放之床位數
        /// </summary>
        public int? REGISTERED_BEDS { get; set; }

        /// <summary>
        /// 年平均占床率
        /// </summary>
        public decimal? OCCUPANCY_RATE { get; set; }

        /// <summary>
        /// 加護病床數
        /// </summary>
        public int? ICU_BEDS { get; set; }

        /// <summary>
        /// 應有醫師人數(重量級)
        /// </summary>
        public int? REQUIRED_DOCS_HEAVY { get; set; }

        /// <summary>
        /// 應有醫師人數(中度級)
        /// </summary>
        public int? REQUIRED_DOCS_MODERATE { get; set; }

        /// <summary>
        /// 實際醫師人數
        /// </summary>
        public int? ACTUAL_DOCS { get; set; }

        /// <summary>
        /// 人床比
        /// </summary>
        public int? DOC_TO_BED_RATIO { get; set; }

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









