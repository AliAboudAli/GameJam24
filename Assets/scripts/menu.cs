using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public Animator animator;

    public AudioMixer audioMixer;

    [SerializeField]public TMP_Dropdown dropdown;

    public float transitiontime = 1f;

    Resolution[] resolutions;

    public void Start()
    {
        resolutions = Screen.resolutions;

        dropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentresolution = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentresolution = i;
            }
        }

        dropdown.value = currentresolution;
        dropdown.RefreshShownValue();
        dropdown.AddOptions(options);
    }

    public void gameover()
    {

    }

    public void backtomenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void setresolution(int resolutionindex)
    {
        Resolution resolution = resolutions[resolutionindex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
    public void quitgame()
    {
        Application.Quit();
    }

    public void playgame()
    {
        StartCoroutine(LevelLoader(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void Continue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void setfullscreen(bool isfullscreen)
    {
        Screen.fullScreen = isfullscreen;
    }

    IEnumerator LevelLoader(int level)
    {
        animator.SetTrigger("start");

        yield return new WaitForSeconds(0f);

        SceneManager.LoadScene(level);
    }
}
