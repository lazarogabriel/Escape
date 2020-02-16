using Assets.scripts.Entitys.Player;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Assets.scripts.Menus
{
    /// <summary>
    /// This script have the responsibilites of menu dead wich is the menu that appears when the player is dead
    /// </summary>
    public class DeadMenu : MonoBehaviour
    {
        #region Fields

        public GameObject deadMenuUI;
        public GameObject player;
        public PlayerHealth playerHealth;

        #endregion

        #region Responsibilites

        void Start()
        {
            deadMenuUI.SetActive(false);
            player = GameObject.FindWithTag("Player");
            playerHealth = player.GetComponent<PlayerHealth>();
        }

        void Update()
        {
            Debug.Log(playerHealth.isDead);

            if (playerHealth.isDead == true)
            {
                deadMenuUI.SetActive(true);
            }
        }

        public void MainMenu()
        {
            SceneManager.LoadScene("MainMenu");
        }

        public void PlayAgain()
        {
            SceneManager.LoadScene("Game");
        }

        #endregion

    }
}
