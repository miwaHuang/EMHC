using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// 急診醫療領域-人力配置
    /// </summary>
    public class EMHC_STAFF
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
        public long MAIN_ID { get; set; }

        /// <summary>
        /// 醫院類別
        /// 1. 本院及兒童醫院合併計算, 2. 本院及 3. 兒童醫院
        /// </summary>
        [Required]
        public int HOSPITAL_TYPE { get; set; }

        /// <summary>
        /// 人員類別
        /// 1.實際專任醫師人數(A)
        /// 2.實際兒科專任專科醫師人數(B)
        /// 3.實際專任醫師且具急診醫學科專科醫師資格人數(具急診醫學學科專科證書)(C)
        /// 4.實際護理人員數(D)
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// 人數
        /// </summary>
        public int? NUMBER { get; set; }

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
