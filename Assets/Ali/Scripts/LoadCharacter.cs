using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] CharacterPrefabs;
    public Transform spawnPoint;
    public Transform spawnPoint2;
    public TMP_Text Label;
    GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
       // int selectedCharacterIndex = PlayerPrefs.GetInt("selectedCharacter");
       int selectedCharacterIndex = gameManager.SelectedCharacter;
       print(selectedCharacterIndex);
        GameObject prefab = CharacterPrefabs[selectedCharacterIndex];
        GameObject clone = Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
        GameObject clone2 = Instantiate(prefab, spawnPoint2.position, spawnPoint2.rotation);

        
    }
}