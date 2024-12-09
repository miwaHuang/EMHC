using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// �[�@�f�з��@���- �C�饭����|�H��
    /// </summary>
    public class EMHC_ICU_DAILY_PATIENTS
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
        /// ���O
        /// 1. �C�饭����|�H��
        /// 2. �C�饭����|�H�ơi�s�ͨ�(�t������)�[�@�f�Сj
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// �C��f�H�ƥ[�`
        /// </summary>
        public int? TOTAL { get; set; }

        /// <summary>
        /// �C�饭����|�H��
        /// </summary>
        public int? AVERAGE { get; set; }

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










