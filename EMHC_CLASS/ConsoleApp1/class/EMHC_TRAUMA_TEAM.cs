using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 緊急外傷醫療領域-緊急外傷照護團隊
    /// </summary>
    public class EMHC_TRAUMA_TEAM
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
        /// 外傷部門組織
        /// 1. 獨立之外傷部門
        /// 2. 外傷小組
        /// </summary>
        public int? TRAUMA_DEPARTMENT { get; set; }

        /// <summary>
        /// 專責醫師編制人數
        /// </summary>
        public int? SPECIALIST_DOCS { get; set; }

        /// <summary>
        /// 外傷個案管理師人數
        /// </summary>
        public int? CASE_MANAGERS { get; set; }

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
