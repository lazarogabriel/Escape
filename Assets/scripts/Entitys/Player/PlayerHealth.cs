using UnityEngine;

namespace Assets.scripts.Entitys.Player
{
    /// <summary>
    /// This script have the resposibilites of player health
    /// </summary>
    public class PlayerHealth : MonoBehaviour
    {
        #region Fields

        public GameObject player;
        public bool isDead;

        #endregion

        #region Resposibilites
        void Start()
        {
            player = GameObject.FindWithTag("Player");
            isDead = false;
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.tag == "Enemy")
            {
                isDead = true;
            }
        }

        #endregion

    }
}
