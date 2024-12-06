using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ConsoleApp1
{
    /// <summary>
    /// 持續性監測主檔
    /// </summary>
    public class EMHC_MAIN
    {
        /// <summary>
        /// 主鍵值
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        [Required]
        public int YEAR { get; set; }

        /// <summary>
        /// 月份
        /// </summary>
        [Required] 
        public int MONTH { get; set; }

        /// <summary>  
        /// 機構代碼 (最大長度: 10)  
        /// </summary>  
        [MaxLength(10)]
        [Required]
        public string HOSPITAL_CODE { get; set; }

        /// <summary>
        /// 建立人員
        /// </summary>
        public string? CT_UID { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CT_DATE { get; set; }

        /// <summary>
        /// 更新人員
        /// </summary>
        public string? UP_UID { get; set; }

        /// <summary>
        /// 更新時間
        /// </summary>
        public DateTime? UP_DATE { get; set; }
    }
}
