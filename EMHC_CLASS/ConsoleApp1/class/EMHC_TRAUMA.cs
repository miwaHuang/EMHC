using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// ���~���������
    /// </summary>
    public class EMHC_TRAUMA
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
        /// 1. �~�����@�H�����~��Ш|����
        /// 2. �~���Y���{��(ISS)���������v
        /// 3. ������~�ˤ�N�Φ����v��뤧���~�B�]���B����Ӯ׼Ʋέp
        /// 4. �~�ˤp�ձҰʮɶ�
        /// 5. ���~�ˤ�N��30�������i�J�}�M�Ф�v
        /// 6. ���~�˯f�H��X���βέp
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// ����
        /// �i�~�����@�H�����~��Ш|���Ρj
        /// 1. ��¾���@�~�H�W���~�����@�H���`��
        /// 2. ��¾���@�~�H�W�B��ƤT�~16�p�ɥ~���~��Ш|�ɼƤ��~�����@�H����
        /// 3. �ʤ���
        /// �i�~���Y���{��(ISS)���������v�j
        /// 1. �ŦX�~���Y����(ISS)������H���f�H�`�H��
        /// 2. �����~���Y����(ISS)������H���f�H�H��
        /// 3. �ʤ���
        /// �i������~�ˤ�N�Φ����v��뤧���~�B�]���B����Ӯ׼Ʋέp�j
        /// 1. ������~�ˤ�N���Ҧ��Ӯ׼�
        /// 2. ��]��(5pm~8am)������~�ˤ�N���Ӯ׼�
        /// 3. �󰲤�(�t�P�����B�P����ΨҰ���)������~�ˤ�N���Ӯ׼�
        /// 4. ��������v��뤧�Ҧ��Ӯ׼�
        /// 5. ��]��(5pm~8am)��������v��뤧�Ӯ׼�
        /// 6. �󰲤�(�t�P�����B�P����ΨҰ���)��������v��뤧�Ӯ׼�
        /// �i�~�ˤp�ձҰʮɶ��j
        /// 1. �~�ˤp�ձҰʤ�����
        /// 2. �~�ˤp�ձҰʫ�ܨ�F�ɶ��p��30����������
        /// 3. �~�ˤp�ձҰʫ�ܨ�F�ɶ��p��10����������
        /// 4. �~�ˤp�ձҰʫ�ܨ�F�ɶ��p��30���������ƹF���v(�ʤ���)
        /// 5. �~�ˤp�ձҰʫ�ܨ�F�ɶ��p��10�������F���v(�ʤ���)
        /// �i���~�ˤ�N��30�������i�J�}�M�Ф�v�j
        /// 1. ���~�ˤ�N�f�H���`�H��
        /// 2. ���~�ˤ�N��30�������i�J�}�M�Яf�H���H��
        /// 3. �ʤ���
        /// �i���~�˯f�H��X���βέp�j
        /// 1. ��E���~�˯f�H�`�H��
        /// 2. ��E���~�˯f�H��X�`�H��
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




