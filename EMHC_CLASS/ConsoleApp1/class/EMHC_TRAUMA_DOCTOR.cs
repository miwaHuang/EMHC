using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 緊急外傷醫療領域-每日輪值醫師名單
    /// </summary>
    public class EMHC_TRAUMA_DOCTOR
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
        /// 職務
        /// 1. 外傷部門主管
        /// 2. 外傷小組召集人
        /// 3. 外傷專責醫師
        /// 4. 外傷小組每日輪值醫師
        /// </summary>
        public int? POSITION { get; set; }

        /// <summary>
        /// 醫師姓名
        /// </summary>
        [MaxLength(15)]
        public string NAME { get; set; }

        /// <summary>
        /// 職稱
        /// </summary>
        [MaxLength(15)]
        public string TITLE { get; set; }

        /// <summary>
        /// 外傷高級救命術(ATLS)證書合格效期
        /// </summary>
        [MaxLength(15)]
        public string ATLS_CERT_EXPIRY { get; set; }

        /// <summary>
        /// 證號
        /// </summary>
        [MaxLength(15)]
        public string CERT_NO { get; set; }

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



