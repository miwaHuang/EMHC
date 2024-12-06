using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// ��ʸ������������-���a���ʯߤ��J�NDoor to wire time
    /// </summary>
    public class EMHC_ACS_PCI_TIME
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
        /// 1.��E��STEMI�f�HDoor to wire time����
        /// 2.��E�����P�@������t�����|�ΰ|����E��STEMI�f�H����
        /// 3.���|�a���ʯߤ��J�N(PCI)�κ��a���ʯߤ��J�N(Primary PCI)���רҼ�

        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// ����
        /// ��E��STEMI�f�HDoor to wire time����
        /// 1. ��E���Ҧ�ST�q�W�ɤ���ʤߦٱ��f�H�������a���ʯߤ��J�N(Primary PCI)�v�����`�H��
        /// 2. ��E���Ҧ�ST�q�W�ɤ���ʤߦٱ��f�H��90�������������a���ʯߤ��J�N(Primary PCI)�v�����`�H��
        /// 3. �ʤ���
        /// ��E�����P�@������t�����|�ΰ|����E��STEMI�f�H����
        /// 1. ����|�ܦP�@������t�����|�ΰ|�Ϥ�STEMI�f�H��
        /// 2. �P�@������t�����|�ΰ|�϶���E�A�ݰ���Door to wire time��STEMI�f�H��
        /// 3. ��F�P�@������t�����|�ΰ|�Ϥ�STEMI�f�HDoor to wire time�p��60�������H��
        /// ���|�a���ʯߤ��J�N(PCI)�κ��a���ʯߤ��J�N(Primary PCI)���רҼ�
        /// 1. ���|�a���ʯߤ��J�N(PCI)�רҼ�
        /// 2. ���|���a���ʯߤ��J�N(Primary PCI)�רҼ�
        /// </summary>
        [Required]
        public int ITEM { get; set; }

        /// <summary>
        /// ����W�Z
        /// </summary>
        public decimal? WEEKDAY { get; set; }

        /// <summary>
        /// ���ɬq
        /// </summary>
        public decimal? ALL_TIME { get; set; }

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









