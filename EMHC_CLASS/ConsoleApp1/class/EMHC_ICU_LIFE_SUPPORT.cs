using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// �[�@�f�з��@��� (���ͱ��I)
    /// </summary>
    public class EMHC_ICU_LIFE_SUPPORT
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
        [ForeignKey("EMHC_ICU")]
        [Required]
        public long ICU_ID { get; set; }

        /// <summary>
        /// ���O
        /// 1. �[�@�f�ШC10�������M�d�M����v1�H�H�W�A�t�d�[�@�f�������~�ȡA�è�Ƭ����H���Ը�
        /// 2. �զ����줧�[�@�f�з��@�ζ�
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// �n�O�}�񤧧ɦ��
        /// </summary>
        public int? REGISTERED_BEDS { get; set; }

        /// <summary>
        /// �~�����e�ɲv
        /// </summary>
        public decimal? OCCUPANCY_RATE { get; set; }

        /// <summary>
        /// �[�@�f�ɼ�
        /// </summary>
        public int? ICU_BEDS { get; set; }

        /// <summary>
        /// ������v�H��(���q��)
        /// </summary>
        public int? REQUIRED_DOCS_HEAVY { get; set; }

        /// <summary>
        /// ������v�H��(���ׯ�)
        /// </summary>
        public int? REQUIRED_DOCS_MODERATE { get; set; }

        /// <summary>
        /// �����v�H��
        /// </summary>
        public int? ACTUAL_DOCS { get; set; }

        /// <summary>
        /// �H�ɤ�
        /// </summary>
        public int? DOC_TO_BED_RATIO { get; set; }

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









