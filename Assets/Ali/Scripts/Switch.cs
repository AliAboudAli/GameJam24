using UnityEngine;
using TMPro;

public class Switch : MonoBehaviour
{
    public GameObject[] Courasel;
    public GameObject[] charactersPrefabs;
    private int index;
    public TextMeshProUGUI[] Names;
    public GameObject SpawnedObject;
    

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        ShowCurrent();
    }
    
    public void Next()
    {
        index++;
        if (index >= Courasel.Length)
            index = 0;

        ShowCurrent();
    }

    public void Previous()
    {
        index--;
        if (index < 0)
            index = Courasel.Length - 1;

        ShowCurrent();
    }

    private void ShowCurrent()
    {
        // Activate only the GameObject at the current index
        for (int i = 0; i < Courasel.Length; i++)
        {
            Courasel[i].SetActive(i == index);
        }

        // Update the names in the TextMeshProUGUI components
        for (int i = 0; i < Names.Length; i++)
        {
            if (i == index)
            {
                Names[i].gameObject.SetActive(true);
                Names[i].text = GetElementName(index);
            }
            else
            {
                Names[i].gameObject.SetActive(false);
            }
        }
    }

    private string GetElementName(int index)
    {
        // Provide the names for each element here based on the index
        switch (index)
        {
            case 0:
                return "NanN1";
            case 1:
                return "NanN2";
            case 2:
                return "NanN3";
            case 3:
                return "NanN4";
            default:
                return "";
        }
    }

    public void SpawnSelectedCharacter()
    {
        //check if the index is valid 
        if (index >= 0 && index < charactersPrefabs.Length)
        {
            //Destroy the previously spawned character prefab
            if (SpawnedObject != null)
            {
                Destroy(SpawnedObject);
            }
            
            //Instantiate the selected character prefab
            SpawnedObject = Instantiate(charactersPrefabs[index], transform.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("Invalid index");
        }
    }
}
