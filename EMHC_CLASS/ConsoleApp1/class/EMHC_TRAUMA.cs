using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 緊急外傷醫療領域
    /// </summary>
    public class EMHC_TRAUMA
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
        /// 1. 外傷醫護人員之繼續教育情形
        /// 2. 外傷嚴重程度(ISS)評估完成率
        /// 3. 執行緊急外傷手術或血管攝影栓塞之全年、夜間、假日個案數統計
        /// 4. 外傷小組啟動時間
        /// 5. 緊急外傷手術於30分鐘內進入開刀房比率
        /// 6. 緊急外傷病人轉出情形統計
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// 項目
        /// 【外傷醫護人員之繼續教育情形】
        /// 1. 任職滿一年以上之外傷醫護人員總數
        /// 2. 任職滿一年以上且具備三年16小時外傷繼續教育時數之外傷醫護人員數
        /// 3. 百分比
        /// 【外傷嚴重程度(ISS)評估完成率】
        /// 1. 符合外傷嚴重度(ISS)評估對象之病人總人次
        /// 2. 完成外傷嚴重度(ISS)評估對象之病人人次
        /// 3. 百分比
        /// 【執行緊急外傷手術或血管攝影栓塞之全年、夜間、假日個案數統計】
        /// 1. 執行緊急外傷手術之所有個案數
        /// 2. 於夜間(5pm~8am)執行緊急外傷手術之個案數
        /// 3. 於假日(含星期六、星期日及例假日)執行緊急外傷手術之個案數
        /// 4. 執行血管攝影栓塞之所有個案數
        /// 5. 於夜間(5pm~8am)執行血管攝影栓塞之個案數
        /// 6. 於假日(含星期六、星期日及例假日)執行血管攝影栓塞之個案數
        /// 【外傷小組啟動時間】
        /// 1. 外傷小組啟動之次數
        /// 2. 外傷小組啟動後至到達時間小於30分鐘之次數
        /// 3. 外傷小組啟動後至到達時間小於10分鐘之次數
        /// 4. 外傷小組啟動後至到達時間小於30分鐘之次數達成率(百分比)
        /// 5. 外傷小組啟動後至到達時間小於10分鐘之達成率(百分比)
        /// 【緊急外傷手術於30分鐘內進入開刀房比率】
        /// 1. 緊急外傷手術病人之總人次
        /// 2. 緊急外傷手術於30分鐘內進入開刀房病人之人次
        /// 3. 百分比
        /// 【緊急外傷病人轉出情形統計】
        /// 1. 急診緊急外傷病人總人數
        /// 2. 急診緊急外傷病人轉出總人數
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




