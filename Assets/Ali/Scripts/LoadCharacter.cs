using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] CharacterPrefabs;
    public GameObject[] CharacterPrefabs2;
    public Transform spawnPoint;
    public Transform spawnPoint2;
    public TMP_Text Label;
    public TMP_Text Label2;
    GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        int selectedCharacterIndex = gameManager.SelectedCharacter;
        Debug.Log(selectedCharacterIndex); 
        GameObject prefab = CharacterPrefabs[selectedCharacterIndex];
        GameObject prefab2 = CharacterPrefabs2[selectedCharacterIndex];
        GameObject clone = Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
        GameObject clone2 = Instantiate(prefab2, spawnPoint2.position, spawnPoint2.rotation); 
        Debug.Log("SelectedCharacter: " + selectedCharacterIndex);
        Debug.Log("CharacterPrefabs Length: " + CharacterPrefabs.Length);
        Debug.Log("CharacterPrefabs2 Length: " + CharacterPrefabs2.Length);

    }
}