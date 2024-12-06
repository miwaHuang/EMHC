using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// ��ʸ������������-��ʸ������f�H
    /// </summary>
    public class EMHC_STROKE_PATIENT
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
        /// 1.��ʸ������f�H���E�覡
        /// 2.�i�󰲤�ũ]���B�m��ʸ������f�H
        /// 3.�i�󰲤�Ω]���i���ʸ������f�H����N
        /// 4.�����R�ߦ�귻�ѩΰʯߦ�겾���v������ʯʦ�ʸ������f�H���Ҧ���ʯʦ�ʸ������f�H�����
        /// 5.�����R�ߦ�귻�Ѫv������ʯʦ�ʸ������f�H���Ҧ��ŦX����A���g��ʯʦ�ʸ������f�H�����
        /// 6.��ʯʦ�ʸ������f�H�����R�ߦ�귻�Ѫv���ɶ���60���������
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// ����
        /// �i��ʸ������f�H���E�覡�j
        /// 1.�HEMS���E�f�H��
        /// 2.�D�HEMS���E�f�H��
        /// 3.�X�p
        /// �i����ũ]���B�m��ʸ������f�H�j
        /// 1.�󰲤�B�m��ʸ������f�H���`�H��
        /// 2.��]���B�m��ʸ������f�H���`�H�������i��o�䴩���H��
        /// �i����Ω]���i���ʸ������f�H����N�j
        /// 1.�ŦX�~�줶�J�v���A���g��ʸ������f�H���`�H��
        /// 2.��ʥX��ʸ������y���~�������Υ\��ʷl�ˡA�ݺ��M��������f�H�H��
        /// 3.��ʤ����y����ʤ����A�ݺ�渣���H�G�ެy���f�H�H��
        /// 4.��ʯʦ�ʤ����y���j�������A�ݺ�氵�`������������N���f�H�H��
        /// 5.��ʯʦ�ʤ����y���j�������A�ݺ�氵�`������������N���f�H�H��
        /// 6.�󰲤�A�]���B�m��ʸ������f�H���`�H��
        /// �i�����R�ߦ�귻�ѩΰʯߦ�겾���v������ʯʦ�ʸ������f�H���Ҧ���ʯʦ�ʸ������f�H����ҡj
        /// 1.��E�Ҧ���ʯʦ�ʸ������f�H���`�H��
        /// 2.��E�����R�ߦ�귻�ѩΰʯߦ�겾���v������ʯʦ�ʸ������f�H���H��
        /// 3.�ʤ���
        /// �i�����R�ߦ�귻�Ѫv������ʯʦ�ʸ������f�H���Ҧ��ŦX����A���g��ʯʦ�ʸ������f�H����ҡj
        /// 1.��E�Ҧ��ŦX����A���g����ʯʦ�ʸ������f�H�`�H��
        /// 2. ��E�����R�ߦ�귻�Ѫv������ʯʦ�ʸ������f�H���H��
        /// 3.�ʤ���
        /// �i��ʯʦ�ʸ������f�H�����R�ߦ�귻�Ѫv���ɶ���60��������ҡj
        /// 1.��E�����R�ߦ�귻�Ѫv������ʯʦ�ʸ������f�H�`�H��
        /// 2.��E��ʯʦ�ʸ������f�H�����R�ߦ�귻�Ѫv���ɶ��p�󵥩�60�������f�H�H��
        /// 3.�ʤ���
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












