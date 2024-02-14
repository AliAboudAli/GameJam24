using UnityEngine;
using TMPro;

public class Switch : MonoBehaviour
{
    public GameObject[] Courasel;
    private int index;
    public TextMeshProUGUI[] Names;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        ShowCurrent();
    }

    // Update is called once per frame
    void Update()
    {
        // Optionally, handle any update-related behavior here.
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
                return "Name1";
            case 1:
                return "Name2";
            case 2:
                return "Name3";
            case 3:
                return "Name4";
            default:
                return "";
        }
    }
}