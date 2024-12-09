using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// ���~���������-���~�ˬ����M����v���|�E����
    /// </summary>
    public class EMHC_TRAUMA_CONSULTATION
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
        /// ��O
        /// 1. ��Ŧ�~��
        /// 2. �ݵĥ~��
        /// 3. ���g�~��
        /// 4. ����
        /// 5. ��Υ~��
        /// 6. �c����
        /// 7. �@��~��
        /// 8. ������
        /// 9. ��g��
        /// 10. �¾K��
        /// 99. ��L
        /// </summary>
        [Required]
        public int DEPARTMENT { get; set; }

        /// <summary>
        /// ��L��O
        /// </summary>
        [MaxLength(15)]
        public string OTHER_DEPARTMENT { get; set; }

        /// <summary>
        /// �O�_�]��
        /// 0. �_
        /// 1. �O
        /// 2. �X�֭ȯZ
        /// </summary>
        public int? IS_AVAILABLE { get; set; }

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



