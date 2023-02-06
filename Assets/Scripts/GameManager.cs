using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Leo
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager m_Main = null;

        public SnakeManager m_SnakeManager = null;

        private void Awake()
        {
            m_Main = this;
        }

        public void EatFood(GameObject eventObj)
        {
            m_SnakeManager.EatFood(eventObj);
        }
    }

}
