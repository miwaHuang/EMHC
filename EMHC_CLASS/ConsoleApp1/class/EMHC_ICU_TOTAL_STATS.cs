using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// �[�@�f�з��@���- �U�[�@�f�Х[�`�έp
    /// </summary>
    public class EMHC_ICU_TOTAL_STATS
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
        [Required]
        public long MAIN_ID { get; set; }

        /// <summary>
        /// �b��E������J�[�@�f�Ф��`�H��
        /// </summary>
        public int? ER_TO_ICU { get; set; }

        /// <summary>
        /// �b��E������J�[�@�f�жW�L6�p�ɥH�W���`�H��
        /// </summary>
        public int? OVER_6H_ER_TO_ICU { get; set; }

        /// <summary>
        /// �b��E������J�[�@�f�жW�L6�p�ɥH�W���ʤ���
        /// </summary>
        public decimal? OVER_6H_ER_TO_ICU_PCT { get; set; }

        /// <summary>
        /// �륭�����E������J�[�@�f�Юɶ�
        /// </summary>
        public decimal? AVG_ER_TO_ICU_TIME { get; set; }

        /// <summary>
        /// �륭�����E���d�ɶ�
        /// </summary>
        public decimal? AVG_ER_STAY_TIME { get; set; }

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

