using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leo
{
    public class SnakeManager : MonoBehaviour
    {
        #region 資料
        // 移動間格時間
        private float m_MoveTime = 1;
        // 現在剩下多久時間可以移動
        private float m_NowMoveTime = 0;

        public List<GameObject> m_Allbody = new List<GameObject>();

        #endregion

        #region 事件
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

        #region 方法

        public void EatFood(GameObject eventObj)
        {
            m_Allbody.Add(eventObj);
        }

        // 貪吃蛇移動
        private void Move()
        {
            m_NowMoveTime = m_MoveTime;

            for (int i = m_Allbody.Count - 1; i > 0; i--)
            {
                m_Allbody[i].transform.position = m_Allbody[i - 1].transform.position;
            }

            // Translate 移動專用API
            m_Allbody[0].transform.Translate(13, 0, 0);
        }

        // 貪吃蛇旋轉
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
