using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// �[�@�f�з��@���- ��L�X�y�ʫ���
    /// </summary>
    public class EMHC_ICU_OTHER_INDICATORS
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
        /// ����
        /// </summary>
        [Required]
        public int ITEM_NO { get; set; }

        /// <summary>
        /// ���ЦW��
        /// </summary>
        [MaxLength(30)]
        public string INDICATOR_NAME { get; set; }

        /// <summary>
        /// �ƭ�
        /// </summary>
        [MaxLength(30)]
        public string VALUE { get; set; }

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

