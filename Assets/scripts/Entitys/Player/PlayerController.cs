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
            velocity = 20f;
        }

        void Update()
        {

            if (playerHealth.isDead == true) return;

            var horizontal = Input.GetAxis("Horizontal") == 0 ? joystick.Horizontal : Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical") == 0 ? joystick.Vertical : Input.GetAxis("Vertical");

            var vector = new Vector2(horizontal, vertical);

            playerTransfrom.Translate(vector * velocity * Time.deltaTime);

        }

        #endregion

    }
}