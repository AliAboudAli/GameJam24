using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectons : MonoBehaviour
{
    public GameObject[] characters;
    public int SelectedCharacterIndex;
    public int newIndex;
    public LoadCharacter load;
    GameManager gameManager;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
       // SelectedCharacterIndex = 0;
    }

    public void NextCharacter()
    {
        characters[newIndex].SetActive(false);
        newIndex = newIndex + 1;
        characters[newIndex].SetActive(true);
        print(newIndex);
    }

    public void BackCharacter()
    {
        characters[newIndex].SetActive(false);
        newIndex = newIndex - 1;
        characters[SelectedCharacterIndex].SetActive(true);
        //print(newIndex);
    }

    void Update()
    {
        print(newIndex);
//        print(gameObject.name);
    }

    public void StartGame()
    {
        gameManager.SelectedCharacter = newIndex;
       // PlayerPrefs.SetInt("selectedCharacter", SelectedCharacterIndex);
        print(newIndex);
        gameManager.LoadNextScene();
    }
}