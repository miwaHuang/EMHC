using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 加護病房照護領域- 其他合宜性指標
    /// </summary>
    public class EMHC_ICU_OTHER_INDICATORS
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
        /// 項次
        /// </summary>
        [Required]
        public int ITEM_NO { get; set; }

        /// <summary>
        /// 指標名稱
        /// </summary>
        [MaxLength(30)]
        public string INDICATOR_NAME { get; set; }

        /// <summary>
        /// 數值
        /// </summary>
        [MaxLength(30)]
        public string VALUE { get; set; }

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

