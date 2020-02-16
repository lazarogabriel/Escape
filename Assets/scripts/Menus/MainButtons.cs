using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

/// <summary>
/// This script have the responsibilites of the main menu
/// </summary>
public class MainButtons : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void PlayGame() => SceneManager.LoadScene(1);
    
    public void QuitGame() => Application.Quit();

    public void SetVolume(float volume) => audioMixer.SetFloat("volume", volume);
}
