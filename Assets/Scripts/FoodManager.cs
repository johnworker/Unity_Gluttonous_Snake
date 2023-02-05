using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leo
{
    public class FoodManager : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                GameManager.m_Main.EatFood(gameObject);
            }
        }
    }

}
