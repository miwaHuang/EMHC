using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 急性腦中風醫療領域-急性腦中風病人
    /// </summary>
    public class EMHC_STROKE_PATIENT
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
        /// 1.急性腦中風病人抵急診方式
        /// 2.可於假日級夜間處置急性腦中風病人
        /// 3.可於假日及夜間進行急性腦中風病人之手術
        /// 4.接受靜脈血栓溶解或動脈血栓移除治療之急性缺血性腦中風病人佔所有急性缺血性腦中風病人之比例
        /// 5.接受靜脈血栓溶解治療之急性缺血性腦中風病人佔所有符合溶栓適應症急性缺血性腦中風病人之比例
        /// 6.急性缺血性腦中風病人接受靜脈血栓溶解治療時間≦60分鐘之比例
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// 項目
        /// 【急性腦中風病人抵急診方式】
        /// 1.以EMS抵急診病人次
        /// 2.非以EMS抵急診病人次
        /// 3.合計
        /// 【假日級夜間處置急性腦中風病人】
        /// 1.於假日處置急性腦中風病人之總人次
        /// 2.於夜間處置急性腦中風病人之總人次鐘內可獲得支援之人次
        /// 【假日及夜間進行急性腦中風病人之手術】
        /// 1.符合外科介入治療適應症急性腦中風病人之總人次
        /// 2.急性出血性腦中風造成腫塊效應或功能性損傷，需緊急清除血塊之病人人次
        /// 3.急性中風造成急性水腦，需緊急腦脊隨液引流之病人人次
        /// 4.急性缺血性中風造成大片腦梗塞，需緊急做顱骨切除減壓手術之病人人次
        /// 5.急性缺血性中風造成大片腦梗塞，需緊急做顱骨切除減壓手術之病人人次
        /// 6.於假日，夜間處置急性腦中風病人之總人次
        /// 【接受靜脈血栓溶解或動脈血栓移除治療之急性缺血性腦中風病人佔所有急性缺血性腦中風病人之比例】
        /// 1.急診所有急性缺血性腦中風病人之總人次
        /// 2.急診接受靜脈血栓溶解或動脈血栓移除治療之急性缺血性腦中風病人之人次
        /// 3.百分比
        /// 【接受靜脈血栓溶解治療之急性缺血性腦中風病人佔所有符合溶栓適應症急性缺血性腦中風病人之比例】
        /// 1.急診所有符合溶栓適應症之急性缺血性腦中風病人總人次
        /// 2. 急診接受靜脈血栓溶解治療之急性缺血性腦中風病人之人次
        /// 3.百分比
        /// 【急性缺血性腦中風病人接受靜脈血栓溶解治療時間≦60分鐘之比例】
        /// 1.急診接受靜脈血栓溶解治療之急性缺血性腦中風病人總人次
        /// 2.急診急性缺血性腦中風病人接受靜脈血栓溶解治療時間小於等於60分鐘之病人人次
        /// 3.百分比
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












