using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// 高危險妊娠及新生兒醫療領域
    /// </summary>
    public class EMHC_PREGNANCY
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
        /// 1. 高危險妊娠教育訓練情形
        /// 2. 新生兒科醫師資格
        /// 3. 產房、新生兒加護單位及嬰兒室之護理人員資格
        /// 4. 高危險妊娠孕婦處置情形
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// 項目
        /// 【高危險妊娠教育訓練情形】
        /// 1. 產房及照護安胎孕產婦護理人員總人數
        /// 2. 接受高危險妊娠照護訓練之產房及照護安胎孕產婦之護理人員人數
        /// 3. 百分比
        /// 【新生兒科醫師資格】
        /// 1. 新生兒科醫師人數
        /// 2. 具NRP之新生兒科醫師人數
        /// 3. 具NRP之新生兒科醫師百分比(%)
        /// 4. 兒科專科醫師受過二年新生兒專業訓練人數
        /// 5. 具NRP之兒科專科醫師受過二年新生兒專業訓練人數
        /// 6. 具NRP之兒科專科醫師受過二年新生兒專業訓練百分比(%)
        /// 7. 兒科專科醫師人數
        /// 8. 具NRP之兒科專科醫師人數
        /// 9. 具NRP之兒科專科醫師百分比(%)
        /// 10. 兒科住院醫師人數
        /// 11. 具NRP之兒科住院醫師人數
        /// 12. 具NRP之兒科住院醫師百分比(%)
        /// 【產房、新生兒加護單位及嬰兒室之護理人員資格】
        /// 1. 產房、新生兒加護單位及嬰兒室服務或任職滿1年以上之護理人員數
        /// 2. 產房、新生兒加護單位及嬰兒室服務或任職滿1年以上且接受過新生兒高級救命術(NRP)之護理人員數
        /// 3. 百分比
        /// 【高危險妊娠孕婦處置情形】
        /// 1. 高危險妊娠孕產婦總人次
        /// 2. 緊急高危險妊娠孕產婦總人次
        /// 3. 緊急高危險妊娠孕產婦到院60分鐘內由婦產科專科醫師診治之人次
        /// 4. 百分比
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






