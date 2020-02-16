using UnityEngine;

namespace Assets.scripts.Entitys.Player
{
    /// <summary>
    /// This Script have the responsibilites of player movement
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        #region Fields

        public GameObject player;
        public PlayerHealth playerHealth;
        public Transform playerTransfrom;

        #endregion

        #region Responsibilities

        void Start()
        {
            player = GameObject.FindWithTag("Player");
            playerHealth = player.GetComponent<PlayerHealth>();
            playerTransfrom = player.transform;
        }

        void Update()
        {
            if (playerHealth.isDead == true) return;


            if (Input.GetKey("left") || Input.GetKey("a"))
            {
                playerTransfrom.Translate(-0.09f, 0, 0);
            }

            if (Input.GetKey("right") || Input.GetKey("d"))
            {
                playerTransfrom.Translate(0.09f, 0, 0);
            }

            if (Input.GetKey("up") || Input.GetKey("w"))
            {
                playerTransfrom.Translate(0, 0.09f, 0);
            }

            if (Input.GetKey("down") || Input.GetKey("s"))
            {
                playerTransfrom.Translate(0, -0.09f, 0);
            }
        }

        #endregion

    }
}