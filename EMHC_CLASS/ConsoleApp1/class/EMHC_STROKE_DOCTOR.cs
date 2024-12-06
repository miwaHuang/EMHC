using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 急性腦中風醫療領域-神經科醫師名單
    /// </summary>
    public class EMHC_STROKE_DOCTOR
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
        /// 醫師姓名
        /// </summary>
        [MaxLength(15)]
        public string NAME { get; set; }

        /// <summary>
        /// 專科醫師證號
        /// </summary>
        [MaxLength(15)]
        public string SPECIALIST_CERT { get; set; }

        /// <summary>
        /// 執業執照
        /// </summary>
        [MaxLength(15)]
        public string LICENSE { get; set; }

        /// <summary>
        /// 報備支援時段
        /// </summary>
        [MaxLength(50)]
        public string SUPPORT_TIME { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        [MaxLength(50)]
        public string REMARKS { get; set; }

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









