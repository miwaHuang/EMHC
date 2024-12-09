using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    /// <summary>
    /// ���M�I���W�ηs�ͨ��������
    /// </summary>
    public class EMHC_PREGNANCY
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
        /// 1. ���M�I���W�Ш|�V�m����
        /// 2. �s�ͨ����v���
        /// 3. ���СB�s�ͨ�[�@��������Ǥ��@�z�H�����
        /// 4. ���M�I���W�����B�m����
        /// </summary>
        [Required]
        public int CATEGORY { get; set; }

        /// <summary>
        /// ����
        /// �i���M�I���W�Ш|�V�m���Ρj
        /// 1. ���Фη��@�w�L�������@�z�H���`�H��
        /// 2. �������M�I���W���@�V�m�����Фη��@�w�L���������@�z�H���H��
        /// 3. �ʤ���
        /// �i�s�ͨ����v���j
        /// 1. �s�ͨ����v�H��
        /// 2. ��NRP���s�ͨ����v�H��
        /// 3. ��NRP���s�ͨ����v�ʤ���(%)
        /// 4. ���M����v���L�G�~�s�ͨ�M�~�V�m�H��
        /// 5. ��NRP�����M����v���L�G�~�s�ͨ�M�~�V�m�H��
        /// 6. ��NRP�����M����v���L�G�~�s�ͨ�M�~�V�m�ʤ���(%)
        /// 7. ���M����v�H��
        /// 8. ��NRP�����M����v�H��
        /// 9. ��NRP�����M����v�ʤ���(%)
        /// 10. ����|��v�H��
        /// 11. ��NRP������|��v�H��
        /// 12. ��NRP������|��v�ʤ���(%)
        /// �i���СB�s�ͨ�[�@��������Ǥ��@�z�H�����j
        /// 1. ���СB�s�ͨ�[�@��������ǪA�ȩΥ�¾��1�~�H�W���@�z�H����
        /// 2. ���СB�s�ͨ�[�@��������ǪA�ȩΥ�¾��1�~�H�W�B�����L�s�ͨప�űϩR�N(NRP)���@�z�H����
        /// 3. �ʤ���
        /// �i���M�I���W�����B�m���Ρj
        /// 1. ���M�I���W�������`�H��
        /// 2. ��氪�M�I���W�������`�H��
        /// 3. ��氪�M�I���W��������|60�������Ѱ�����M����v�E�v���H��
        /// 4. �ʤ���
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






