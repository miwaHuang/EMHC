using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// ��E�������-���M����v���|�E����
    /// </summary>
    public class EMHC_CONSULTANT
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
        /// 1.���ׯ�
        /// 2.���ׯ�
        /// </summary>
        [Required]
        public int LEVEL { get; set; }

        /// <summary>
        /// ���O
        /// �i���ׯšj
        /// 1.��E���|�E�~��B����B���줧�`�H��
        /// 2.��E���|�E�~��B����B�����60�������i��o�䴩���H��
        /// 3.�ʤ���
        /// �i���ׯšj
        /// 1.��E���|�E�~��B����B����B���B�¾K��B���g��B���g�~��B�����줧�`�H��
        /// 2.��E���|�E�~��B����B����B���B�¾K��B���g��B���g�~��B�������30�������i��o�䴩���H��
        /// 3.�ʤ���
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// �H��
        /// </summary>
        public decimal? NUMBER { get; set; }

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





