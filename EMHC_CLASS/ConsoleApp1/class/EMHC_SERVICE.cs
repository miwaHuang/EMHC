
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ConsoleApp1
{
    /// <summary>
    /// 急診醫療領域-急診服務量
    /// </summary>
    public class EMHC_SERVICE
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
        /// 人員類別
        /// 1.急診兒童就診人次
        /// 2.急診就醫人次
        /// 3.急診留觀人次
        /// 4.觀察室登記之急診觀察病床(每月1日登記床數加總)
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// 人次
        /// </summary>
        [Required]
        public int NUMBER { get; set; }

        /// <summary>
        /// 年平均
        /// </summary>
        [Required]
        public decimal YEAR_AVE { get; set; }

        /// <summary>
        /// 月平均
        /// </summary>
        [Required]
        public decimal MONTH_AVE { get; set; }

        /// <summary>
        /// 日平均
        /// </summary>
        [Required]
        public decimal DAY_AVE { get; set; }

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
