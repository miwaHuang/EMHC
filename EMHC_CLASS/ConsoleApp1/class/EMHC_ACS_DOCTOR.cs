using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// ��ʫa�߯g�������-��Ŧ��v�W��
    /// </summary>
    public class EMHC_ACS_DOCTOR
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
        /// 1.��Ŧ������v�W��
        /// 2.���J�ʤ�Ŧ�����v�W��
        /// 3.��Ŧ�~����v�W��
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// ��v�m�W
        /// </summary>
        [MaxLength(15)]
        public string NAME { get; set; }

        /// <summary>
        /// �M����v�Ҹ�
        /// </summary>
        [MaxLength(15)]
        public string SPECIALIST_CERT { get; set; }

        /// <summary>
        /// ���~����
        /// </summary>
        [MaxLength(15)]
        public string LICENSE { get; set; }

        /// <summary>
        /// ���Ƥ䴩�ɬq
        /// </summary>
        [MaxLength(50)]
        public string SUPPORT_TIME { get; set; }

        /// <summary>
        /// �Ƶ�
        /// </summary>
        [MaxLength(50)]
        public string REMARKS { get; set; }

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















