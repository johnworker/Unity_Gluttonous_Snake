using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leo
{
    public class SnakeManager : MonoBehaviour
    {
        #region ���
        // ���ʶ���ɶ�
        private float m_MoveTime = 1;
        // �{�b�ѤU�h�[�ɶ��i�H����
        private float m_NowMoveTime = 0;

        public List<GameObject> m_Allbody = new List<GameObject>();

        #endregion

        #region �ƥ�
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
            if (Input.GetKeyDown(KeyCode.A))
            {
                TurnLeft();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                TurnRight();
            }

        }

        #endregion

        #region ��k

        public void EatFood(GameObject eventObj)
        {
            m_Allbody.Add(eventObj);
        }

        // �g�Y�D����
        private void Move()
        {
            m_NowMoveTime = m_MoveTime;

            for (int i = m_Allbody.Count - 1; i > 0; i--)
            {
                m_Allbody[i].transform.position = m_Allbody[i - 1].transform.position;
            }

            // Translate ���ʱM��API
            m_Allbody[0].transform.Translate(13, 0, 0);
        }

        // �g�Y�D����
        private void TurnRight()
        {
            m_Allbody[0].transform.Rotate(0, 0, -90);
        }

        private void TurnLeft()
        {
            m_Allbody[0].transform.Rotate(0, 0, 90);
        }

        #endregion
    }

}
