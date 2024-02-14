using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectons : MonoBehaviour
{
    public GameObject[] characters;
    public int SelecedCharacters = 0;

    public void NextCharacter()
    {
        characters[SelecedCharacters].SetActive(false);
        SelecedCharacters = (SelecedCharacters + 1) % characters.Length;
        characters[SelecedCharacters].SetActive(true);
    }

    public void BackCharacter()
    {
        characters[SelecedCharacters].SetActive(false);
        SelecedCharacters--;
        if (SelecedCharacters < 0)
        {
            SelecedCharacters += characters.Length;
        }
        characters[SelecedCharacters].SetActive(true);
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("SelecedCharacters", SelecedCharacters);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
