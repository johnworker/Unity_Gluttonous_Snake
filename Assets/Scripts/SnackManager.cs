using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leo
{
    public class SnackManager : MonoBehaviour
    {
        #region 資料
        // 移動間格時間
        private float m_MoveTime = 1;
        // 現在剩下多久時間可以移動
        private float m_NowMoveTime = 0;

        #endregion

        #region 事件
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

        #region 方法
        private void Move()
        {
            m_NowMoveTime = m_MoveTime;

            transform.Translate(0, -40, 0);
        }

        #endregion
    }

}
