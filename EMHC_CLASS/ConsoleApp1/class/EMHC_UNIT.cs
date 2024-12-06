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
    /// 醫院申請資料
    /// </summary>
    public class EMHC_UNIT
    {
        /// <summary>
        /// 主鍵值 ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        /// <summary>
        /// 監測主檔ID MAIN_ID
        /// </summary>
        [ForeignKey("EMHC_MAIN")]
        public long MAIN_ID { get; set; }

        /// <summary>
        /// 指揮中心代碼 DEPT_NO
        /// </summary>
        [StringLength(2)]
        public string DEPT_NO { get; set; }

        /// <summary>
        /// 縣市別 HOSPITAL_AREA
        /// </summary>
        [StringLength(4)]
        public string HOSPITAL_AREA { get; set; }

        /// <summary>
        /// 急救責任醫院等級 LEVEL
        /// 1. 度級急救責任醫院
        /// 2. 中度級急救責任醫院具備部分章節重度級能力
        /// 3. 中度級急救責任醫院（不含高危險妊娠及新生兒醫療）具備部分章節重度級能力
        /// 4. 中度級急救責任醫院
        /// 5. 中度級急救責任醫院（不含高危險妊娠及新生兒醫療）
        /// 6. 一般級急救責任醫院具備部分章節中度級能力
        /// 7. 一般級急救責任醫院
        /// </summary>
        public int LEVEL { get; set; }

        /// <summary>
        /// 評定效期 PERIOD
        /// </summary>
        public DateTime? PERIOD { get; set; } // Allow null

        /// <summary>
        /// 第一章評定等級 CHAPTER1
        /// </summary>
        public int CHAPTER1 { get; set; }

        /// <summary>
        /// 第二章評定等級 CHAPTER2
        /// </summary>
        public int CHAPTER2 { get; set; }

        /// <summary>
        /// 第三章評定等級 CHAPTER3
        /// </summary>
        public int CHAPTER3 { get; set; }

        /// <summary>
        /// 第四章評定等級 CHAPTER4
        /// </summary>
        public int CHAPTER4 { get; set; }

        /// <summary>
        /// 第五章評定等級 CHAPTER5
        /// </summary>
        public int CHAPTER5 { get; set; }

        /// <summary>
        /// 第六章評定等級 CHAPTER6
        /// 1. 重度級, 2. 中度級, 3. 未申請
        /// </summary>
        public int CHAPTER6 { get; set; }

        /// <summary>
        /// 建立人員 CT_UID
        /// </summary>
        [StringLength(15)]
        public string CT_UID { get; set; }

        /// <summary>
        /// 建立時間 CT_DATE
        /// </summary>
        public DateTime CT_DATE { get; set; }

        /// <summary>
        /// 更新人員 UP_UID
        /// </summary>
        [StringLength(15)]
        public string UP_UID { get; set; }

        /// <summary>
        /// 更新時間 UP_DATE
        /// </summary>
        public DateTime? UP_DATE { get; set; } // Allow null
    }
}
