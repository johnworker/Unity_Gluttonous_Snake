using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Leo
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager m_Main = null;

        public SnackManager m_SnackManager = null;

        private void Awake()
        {
            m_Main = this;
        }

        public void EatFood(GameObject eventObj)
        {
            m_SnackManager.EatFood(eventObj);
        }

    }

}
