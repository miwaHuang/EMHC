using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// ��ʸ������������-��ʸ��������@�ζ�
    /// </summary>
    public class EMHC_STROKE_TEAM
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
        /// 1.���g��M����v
        /// 2.���g�~��M����v
        /// 3.�������Ӯ׺޲z�v
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// �H��
        /// </summary>
        public int? NUMBER { get; set; }

        /// <summary>
        /// �M����v��
        /// </summary>
        public int? FULL_TIME_DOCS { get; set; }

        /// <summary>
        /// �䴩��v��
        /// </summary>
        public int? SUPPORT_DOCS { get; set; }

        /// <summary>
        /// �䴩�ɼ�
        /// </summary>
        [MaxLength(15)]
        public string SUPPORT_HOURS { get; set; }

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






