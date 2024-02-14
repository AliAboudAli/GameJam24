using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] Characterprefabs;
    public Transform spawnPoint;
    public TMP_Text Label;
    // Start is called before the first frame update
    void Start()
    {
        int SelectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        GameObject prefab = Characterprefabs[SelectedCharacter];
        GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        Label.text = prefab.name;
    }
    
}
