using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// ���~���������-���~�˷��@�ζ�
    /// </summary>
    public class EMHC_TRAUMA_TEAM
    {
        /// <summary>
        /// �D���
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        /// <summary>
        /// �ʴ��D��ID
        /// </summary>
        [ForeignKey("EMHC_MAIN")]
        [Required]
        public long MAIN_ID { get; set; }

        /// <summary>
        /// �~�˳�����´
        /// 1. �W�ߤ��~�˳���
        /// 2. �~�ˤp��
        /// </summary>
        public int? TRAUMA_DEPARTMENT { get; set; }

        /// <summary>
        /// �M�d��v�s��H��
        /// </summary>
        public int? SPECIALIST_DOCS { get; set; }

        /// <summary>
        /// �~�˭Ӯ׺޲z�v�H��
        /// </summary>
        public int? CASE_MANAGERS { get; set; }

        /// <summary>
        /// �إߤH��
        /// </summary>
        [MaxLength(15)]
        public string CT_UID { get; set; }

        /// <summary>
        /// �إ߮ɶ�
        /// </summary>
        [Required]
        public DateTime CT_DATE { get; set; }

        /// <summary>
        /// ��s�H��
        /// </summary>
        [MaxLength(15)]
        public string UP_UID { get; set; }

        /// <summary>
        /// ��s�ɶ�
        /// </summary>
        public DateTime? UP_DATE { get; set; }
    }
}
