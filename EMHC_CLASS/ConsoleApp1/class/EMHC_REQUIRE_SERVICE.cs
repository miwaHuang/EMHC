using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 急診醫療領域-所需人力配置
    /// </summary>
    public class EMHC_REQUIRE_SERVICE
    {
        /// <summary>
        /// 主鍵值
        /// </summary>
        [Key]
        public long ID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        /// <summary>
        /// 監測主檔ID
        /// </summary>
        [ForeignKey("EMHC_MAIN")]
        [Required]
        public long MAIN_ID { get; set; }

        /// <summary>
        /// 急診加護病房床數
        /// </summary>
        public int? ICU_BEDS { get; set; }

        /// <summary>
        /// 急診加護病房應有專任醫師人數
        /// </summary>
        public int? ICU_DOCS { get; set; }

        /// <summary>
        /// 年平均急診兒童就診人次
        /// </summary>
        public decimal? YEARLY_VISITS { get; set; }

        /// <summary>
        /// 每月應有兒科醫師服務
        /// </summary>
        [MaxLength(15)]
        public string MONTHLY_REQ { get; set; }

        /// <summary>
        /// 每月執登兒科醫師服務
        /// </summary>
        [MaxLength(15)]
        public string MONTHLY_REG { get; set; }

        /// <summary>
        /// 是否有24小時兒童急診
        /// </summary>
        public bool? HAS_24H_EMERGENCY { get; set; }

        /// <summary>
        /// 應有兒科醫師人數
        /// </summary>
        [MaxLength(15)]
        public string REQ_DOCS { get; set; }

        /// <summary>
        /// 執登兒科醫師人數
        /// </summary>
        [MaxLength(15)]
        public string REG_DOCS { get; set; }

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




