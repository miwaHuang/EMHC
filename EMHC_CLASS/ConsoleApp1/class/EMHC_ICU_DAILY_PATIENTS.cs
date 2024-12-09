using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 加護病房照護領域- 每日平均住院人數
    /// </summary>
    public class EMHC_ICU_DAILY_PATIENTS
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
        /// 1. 每日平均住院人數
        /// 2. 每日平均住院人數【新生兒(含早產兒)加護病房】
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// 每日病人數加總
        /// </summary>
        public int? TOTAL { get; set; }

        /// <summary>
        /// 每日平均住院人數
        /// </summary>
        public int? AVERAGE { get; set; }

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










