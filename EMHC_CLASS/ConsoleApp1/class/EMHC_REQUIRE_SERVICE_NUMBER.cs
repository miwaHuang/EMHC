using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    /// <summary>
    /// 急診醫療領域-所需人力配置人數
    /// </summary>
    public class EMHC_REQUIRE_SERVICE_NUMBER
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
        /// 等級
        /// 1.中度級
        /// 2.重度級
        /// </summary>
        [Required]
        public int LEVEL { get; set; }

        /// <summary>
        /// 類別
        /// 【中度級】
        /// 1.所需專科醫師人數
        /// 2.應有專任醫師人數
        /// 3.應有護理人員數
        /// 4.應有護理人員數
        /// 5.應有護理人員數
        /// 【重度級】
        /// 1.急診就醫人次應有專任醫師人數
        /// 2.急診留觀人次應有專任醫師人數
        /// 3.應有專任醫師人數
        /// 4.急診就醫人次應有護理人員數
        /// 5.急診觀察病床應有護理人員數
        /// 6.應有護理人員數
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }


        /// <summary>
        /// 應有人數
        /// </summary>
        public decimal? REQUIRED { get; set; }

        /// <summary>
        /// 執登人數
        /// </summary>
        public decimal? REGISTERED { get; set; }

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




