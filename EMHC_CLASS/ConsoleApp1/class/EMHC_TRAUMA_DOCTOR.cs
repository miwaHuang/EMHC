using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// ���~���������-�C�������v�W��
    /// </summary>
    public class EMHC_TRAUMA_DOCTOR
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
        /// ¾��
        /// 1. �~�˳����D��
        /// 2. �~�ˤp�եl���H
        /// 3. �~�˱M�d��v
        /// 4. �~�ˤp�ըC�������v
        /// </summary>
        public int? POSITION { get; set; }

        /// <summary>
        /// ��v�m�W
        /// </summary>
        [MaxLength(15)]
        public string NAME { get; set; }

        /// <summary>
        /// ¾��
        /// </summary>
        [MaxLength(15)]
        public string TITLE { get; set; }

        /// <summary>
        /// �~�˰��űϩR�N(ATLS)�ҮѦX��Ĵ�
        /// </summary>
        [MaxLength(15)]
        public string ATLS_CERT_EXPIRY { get; set; }

        /// <summary>
        /// �Ҹ�
        /// </summary>
        [MaxLength(15)]
        public string CERT_NO { get; set; }

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



