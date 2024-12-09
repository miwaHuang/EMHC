using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// �[�@�f�з��@���- �[�@�f�Ы~����а�����
    /// </summary>
    public class EMHC_ICU_QUALITY_INDICATORS
    {
        /// <summary>
        /// �D���
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        /// <summary>
        /// �[�@�f��ID
        /// </summary>
        [Required]
        public long ICU_ID { get; set; }

        /// <summary>
        /// �b��E������J�[�@�f�Ф��`�H��
        /// </summary>
        public int? TOTAL_ER_TO_ICU { get; set; }

        /// <summary>
        /// �b��E������J�[�@�f�жW�L6�p�ɥH�W���H��
        /// </summary>
        public int? OVER_6H_ER_TO_ICU { get; set; }

        /// <summary>
        /// �b��E������J�[�@�f�жW�L6�p�ɥH�W���ʤ���
        /// </summary>
        public decimal? OVER_6H_ER_TO_ICU_PCT { get; set; }

        /// <summary>
        /// �b��E������J�[�@�f�жW�L6�p�ɥH�W���륭���H��
        /// </summary>
        public decimal? AVG_OVER_6H_ER_TO_ICU { get; set; }

        /// <summary>
        /// �륭�����E������J�[�@�f�Юɶ�
        /// </summary>
        public decimal? AVG_ER_TO_ICU_TIME { get; set; }

        /// <summary>
        /// �륭����E���d�ɶ�
        /// </summary>
        public decimal? AVG_ER_STAY_TIME { get; set; }

        /// <summary>
        /// �[�@�f�Яf�H�`��|���
        /// </summary>
        public int? TOTAL_ICU_DAYS { get; set; }

        /// <summary>
        /// �[�@�f�Яf�H�P�V���`�H��
        /// </summary>
        public int? TOTAL_ICU_INF { get; set; }

        /// <summary>
        /// �[�@�f�зP�V�v
        /// </summary>
        public decimal? ICU_INF_RATE { get; set; }

        /// <summary>
        /// �[�@�f�Ц��`�v
        /// </summary>
        public decimal? ICU_MORT_RATE { get; set; }

        /// <summary>
        /// �[�@�f���`�f�ɼ�
        /// </summary>
        public int? TOTAL_ICU_BEDS { get; set; }

        /// <summary>
        /// �[�@�f�ХX�|�`�H��
        /// </summary>
        public int? TOTAL_ICU_DISCH { get; set; }

        /// <summary>
        /// �@�f�ɩP��v
        /// </summary>
        public decimal? BED_TURN_RATE { get; set; }

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

