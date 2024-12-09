using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// ��ʫa�߯g�������
    /// </summary>
    public class EMHC_ACS
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
        /// 1. �@�Ĥ@��EKG�ɶ��p��10����
        /// 2. ���J�ʤ�Ŧ�����v�H��
        /// 3. ��Ŧ�~����v�i���ׯšj
        /// 4. ���L�]�m�߾ɺޫ�(��/�L)
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// ����
        /// �i��E��STEMI�f�HDoor to wire time���Ρj
        /// 1. ��E��ʫa�߯g�f�H�`�H��
        /// 2. ��E��ʫa�߯g�f�H�@�Ĥ@�iEKG�ɶ��p��10���������
        /// 3. �ʤ���
        /// �iSTEMI�f�H���E�A�X����ASA��Clopidogrel(��Ticagrelor�BPrasugrel)������ҡj
        /// 1. ��E�Ҧ���ʫa�߯g�f�H���`�H��
        /// 2. ��E��ʫa�߯g�f�H�A�X����ASA��Clopidogrel(��Ticagrelor)�����H��
        /// 3. �ʤ���
        /// </summary>
        [Required]
        public int ITEM { get; set; }

        /// <summary>
        /// �ƭ�
        /// </summary>
        public decimal? VALUE { get; set; }

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


