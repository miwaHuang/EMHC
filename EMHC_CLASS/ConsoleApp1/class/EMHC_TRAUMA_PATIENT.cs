using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 緊急外傷醫療領域-緊急外傷病人之預後分析
    /// </summary>
    public class EMHC_TRAUMA_PATIENT
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
        /// 項目
        /// 1. 住院人數
        /// 2. 平均住院日
        /// 3. 手術人數
        /// 4. 手術比率
        /// 5. 死亡人數
        /// 6. 死亡比率
        /// 7. 進入ICU人數
        /// 8. 進入ICU比率
        /// 9. ICU平均住院日
        /// </summary>
        [Required]
        public int ITEM { get; set; }


        /// <summary>
        /// 重度外傷患者(≧16)
        /// </summary>
        public decimal? SEVERE_PATIENTS { get; set; }

        /// <summary>
        /// 輕度或中度外傷患者(<16)
        /// </summary>
        public decimal? MILD_PATIENTS { get; set; }


        /// <summary>
        /// 合計
        /// </summary>
        public decimal? TOTAL { get; set; }

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




