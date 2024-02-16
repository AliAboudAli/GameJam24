using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectons : MonoBehaviour
{
    public GameObject[] characters;
    public int newIndex;
    GameManager gameManager;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void NextCharacter()
    {
        characters[newIndex].SetActive(false);
        newIndex = newIndex + 1;
        if (newIndex >= characters.Length)
        {
            newIndex = 0;
        }
        characters[newIndex].SetActive(true);
    }

    public void BackCharacter()
    {
        characters[newIndex].SetActive(false);
        newIndex = newIndex - 1;
        if (newIndex < 0)
        {
            newIndex = characters.Length - 1;
        }
        characters[newIndex].SetActive(true);
    }

    public void StartGame()
    {
        gameManager.SelectedCharacter = newIndex;
        gameManager.LoadNextScene();
    }
}