using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 急性冠心症醫療領域
    /// </summary>
    public class EMHC_ACS
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
        /// 類別
        /// 1. 作第一章EKG時間小於10分鐘
        /// 2. 介入性心臟血管醫師人數
        /// 3. 心臟外科醫師【重度級】
        /// 4. 有無設置心導管室(有/無)
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// 項目
        /// 【急診之STEMI病人Door to wire time情形】
        /// 1. 急診急性冠心症病人總人次
        /// 2. 急診急性冠心症病人作第一張EKG時間小於10分鐘之件數
        /// 3. 百分比
        /// 【STEMI病人於急診適合給予ASA及Clopidogrel(或Ticagrelor、Prasugrel)等之比例】
        /// 1. 急診所有急性冠心症病人之總人次
        /// 2. 急診急性冠心症病人適合給予ASA及Clopidogrel(或Ticagrelor)等之人次
        /// 3. 百分比
        /// </summary>
        [Required]
        public int ITEM { get; set; }

        /// <summary>
        /// 數值
        /// </summary>
        public decimal? VALUE { get; set; }

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


