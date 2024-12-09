using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// ���~���������-���~�˯f�H���w����R
    /// </summary>
    public class EMHC_TRAUMA_PATIENT
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
        /// ����
        /// 1. ��|�H��
        /// 2. ������|��
        /// 3. ��N�H��
        /// 4. ��N��v
        /// 5. ���`�H��
        /// 6. ���`��v
        /// 7. �i�JICU�H��
        /// 8. �i�JICU��v
        /// 9. ICU������|��
        /// </summary>
        [Required]
        public int ITEM { get; set; }


        /// <summary>
        /// ���ץ~�˱w��(��16)
        /// </summary>
        public decimal? SEVERE_PATIENTS { get; set; }

        /// <summary>
        /// ���שΤ��ץ~�˱w��(<16)
        /// </summary>
        public decimal? MILD_PATIENTS { get; set; }


        /// <summary>
        /// �X�p
        /// </summary>
        public decimal? TOTAL { get; set; }

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




