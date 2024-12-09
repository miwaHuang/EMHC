using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 加護病房照護領域- 加護病房品質指標執情形
    /// </summary>
    public class EMHC_ICU_QUALITY_INDICATORS
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
        [Required]
        public long ICU_ID { get; set; }

        /// <summary>
        /// 在急診等號轉入加護病房之總人次
        /// </summary>
        public int? TOTAL_ER_TO_ICU { get; set; }

        /// <summary>
        /// 在急診等後轉入加護病房超過6小時以上之人次
        /// </summary>
        public int? OVER_6H_ER_TO_ICU { get; set; }

        /// <summary>
        /// 在急診等候轉入加護病房超過6小時以上之百分比
        /// </summary>
        public decimal? OVER_6H_ER_TO_ICU_PCT { get; set; }

        /// <summary>
        /// 在急診等後轉入加護病房超過6小時以上之月平均人次
        /// </summary>
        public decimal? AVG_OVER_6H_ER_TO_ICU { get; set; }

        /// <summary>
        /// 月平均於急診等後轉入加護病房時間
        /// </summary>
        public decimal? AVG_ER_TO_ICU_TIME { get; set; }

        /// <summary>
        /// 月平均急診停留時間
        /// </summary>
        public decimal? AVG_ER_STAY_TIME { get; set; }

        /// <summary>
        /// 加護病房病人總住院日數
        /// </summary>
        public int? TOTAL_ICU_DAYS { get; set; }

        /// <summary>
        /// 加護病房病人感染之總人次
        /// </summary>
        public int? TOTAL_ICU_INF { get; set; }

        /// <summary>
        /// 加護病房感染率
        /// </summary>
        public decimal? ICU_INF_RATE { get; set; }

        /// <summary>
        /// 加護病房死亡率
        /// </summary>
        public decimal? ICU_MORT_RATE { get; set; }

        /// <summary>
        /// 加護病房總病床數
        /// </summary>
        public int? TOTAL_ICU_BEDS { get; set; }

        /// <summary>
        /// 加護病房出院總人次
        /// </summary>
        public int? TOTAL_ICU_DISCH { get; set; }

        /// <summary>
        /// 護病床周轉率
        /// </summary>
        public decimal? BED_TURN_RATE { get; set; }

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

