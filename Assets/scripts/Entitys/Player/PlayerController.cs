using UnityEngine;

namespace Assets.scripts.Entitys.Player
{
    /// <summary>
    /// This Script have the responsibilites of player movement
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        #region Fields

        public Joystick joystick;
        public GameObject player;
        public PlayerHealth playerHealth;
        public Transform playerTransfrom;
        public float velocity;

        #endregion

        #region Responsibilities

        void Start()
        {
            player = GameObject.FindWithTag("Player");
            playerHealth = player.GetComponent<PlayerHealth>();
            playerTransfrom = player.transform;
            velocity = 0.2f;
        }

        void Update()
        {

            if (playerHealth.isDead == true) return;

            if (Input.GetKey("left") || Input.GetKey("a") || joystick.Horizontal < 0f)
            {
                playerTransfrom.Translate(-velocity, 0, 0);
            }

            if (Input.GetKey("right") || Input.GetKey("d") || joystick.Horizontal > 0f)
            {
                playerTransfrom.Translate(velocity, 0, 0);
            }

            if (Input.GetKey("up") || Input.GetKey("w") || joystick.Vertical > 0f)
            {
                playerTransfrom.Translate(0, velocity, 0);
            }

            if (Input.GetKey("down") || Input.GetKey("s") || joystick.Vertical < 0f)
            {
                playerTransfrom.Translate(0, -velocity, 0);
            }
        }

        #endregion

    }
}