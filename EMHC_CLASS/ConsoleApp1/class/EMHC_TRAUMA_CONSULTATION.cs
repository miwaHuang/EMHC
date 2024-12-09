using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 緊急外傷醫療領域-有外傷相關專科醫師緊急會診機制
    /// </summary>
    public class EMHC_TRAUMA_CONSULTATION
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
        /// 科別
        /// 1. 心臟外科
        /// 2. 胸腔外科
        /// 3. 神經外科
        /// 4. 骨科
        /// 5. 整形外科
        /// 6. 泌尿科
        /// 7. 一般外科
        /// 8. 婦產科
        /// 9. 放射科
        /// 10. 麻醉科
        /// 99. 其他
        /// </summary>
        [Required]
        public int DEPARTMENT { get; set; }

        /// <summary>
        /// 其他科別
        /// </summary>
        [MaxLength(15)]
        public string OTHER_DEPARTMENT { get; set; }

        /// <summary>
        /// 是否設有
        /// 0. 否
        /// 1. 是
        /// 2. 合併值班
        /// </summary>
        public int? IS_AVAILABLE { get; set; }

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



