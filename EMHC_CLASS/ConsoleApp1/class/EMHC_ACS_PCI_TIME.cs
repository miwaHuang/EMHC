using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 急性腦中風醫療領域-緊急冠狀動脈介入術Door to wire time
    /// </summary>
    public class EMHC_ACS_PCI_TIME
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
        /// 1.急診之STEMI病人Door to wire time情形
        /// 2.急診接收同一醫療體系之分院或院區轉診之STEMI病人情形
        /// 3.全院冠狀動脈介入術(PCI)及緊急冠狀動脈介入術(Primary PCI)之案例數

        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// 項目
        /// 急診之STEMI病人Door to wire time情形
        /// 1. 急診之所有ST段上升之急性心肌梗塞病人接受緊急冠狀動脈介入術(Primary PCI)治療之總人次
        /// 2. 急診之所有ST段上升之急性心肌梗塞病人於90分鐘內接受緊急冠狀動脈介入術(Primary PCI)治療之總人次
        /// 3. 百分比
        /// 急診接收同一醫療體系之分院或院區轉診之STEMI病人情形
        /// 1. 需轉院至同一醫療體系之分院或院區之STEMI病人次
        /// 2. 同一醫療體系之分院及院區間轉診，需執行Door to wire time之STEMI病人次
        /// 3. 到達同一醫療體系之分院或院區之STEMI病人Door to wire time小於60分鐘之人次
        /// 全院冠狀動脈介入術(PCI)及緊急冠狀動脈介入術(Primary PCI)之案例數
        /// 1. 全院冠狀動脈介入術(PCI)案例數
        /// 2. 全院緊急冠狀動脈介入術(Primary PCI)案例數
        /// </summary>
        [Required]
        public int ITEM { get; set; }

        /// <summary>
        /// 平日上班
        /// </summary>
        public decimal? WEEKDAY { get; set; }

        /// <summary>
        /// 全時段
        /// </summary>
        public decimal? ALL_TIME { get; set; }

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









