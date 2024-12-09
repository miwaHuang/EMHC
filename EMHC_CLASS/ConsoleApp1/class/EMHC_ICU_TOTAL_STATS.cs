using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 加護病房照護領域- 各加護病房加總統計
    /// </summary>
    public class EMHC_ICU_TOTAL_STATS
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
        [Required]
        public long MAIN_ID { get; set; }

        /// <summary>
        /// 在急診等候轉入加護病房之總人次
        /// </summary>
        public int? ER_TO_ICU { get; set; }

        /// <summary>
        /// 在急診等後轉入加護病房超過6小時以上之總人次
        /// </summary>
        public int? OVER_6H_ER_TO_ICU { get; set; }

        /// <summary>
        /// 在急診等候轉入加護病房超過6小時以上之百分比
        /// </summary>
        public decimal? OVER_6H_ER_TO_ICU_PCT { get; set; }

        /// <summary>
        /// 月平均於急診等後轉入加護病房時間
        /// </summary>
        public decimal? AVG_ER_TO_ICU_TIME { get; set; }

        /// <summary>
        /// 月平均於急診停留時間
        /// </summary>
        public decimal? AVG_ER_STAY_TIME { get; set; }

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

