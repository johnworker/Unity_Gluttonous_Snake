using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leo
{
    public class SnackManager : MonoBehaviour
    {
        #region ���
        // ���ʶ���ɶ�
        private float m_MoveTime = 1;
        // �{�b�ѤU�h�[�ɶ��i�H����
        private float m_NowMoveTime = 0;

        #endregion

        #region �ƥ�
        void Start()
        {

        }

        void Update()
        {
            if (m_NowMoveTime < 0) 
            {
                Move();
            }
            else 
            {
                m_NowMoveTime -= Time.deltaTime;
            }
        }

        #endregion

        #region ��k
        private void Move()
        {
            m_NowMoveTime = m_MoveTime;

            transform.Translate(0, -40, 0);
        }

        #endregion
    }

}
