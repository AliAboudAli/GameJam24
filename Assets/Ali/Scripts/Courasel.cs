using UnityEngine;
using TMPro;

public class Courasel : MonoBehaviour
{
    public GameObject[] Kourasel;
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
        if (index >= Kourasel.Length)
            index = 0;

        ShowCurrent();
    }

    public void Previous()
    {
        index--;
        if (index < 0)
            index = Kourasel.Length - 1;

        ShowCurrent();
    }

    private void ShowCurrent()
    {
        // Activate only the GameObject at the current index
        for (int i = 0; i < Kourasel.Length; i++)
        {
            Kourasel[i].SetActive(i == index);
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

    private string GetElementName(int index, bool isFirstCase = true)
    {
        if (isFirstCase)
        {
            // Handle the first type of cases
            switch (index)
            {
                case 0:
                    return "Jantje";
                case 1:
                    return "Pietje";
                case 2:
                    return "Predator";
                case 3:
                    return "Takeshi";
                default:
                    return "";
            }
        }
        else
        {
            // Handle the second type of cases
            switch (index)
            {
                case 0:
                    return "Predator";
                case 1:
                    return "Jantje";
                case 2:
                    return "Takeshi";
                case 3:
                    return "Pietje";
                default:
                    return "";
            }
        }
    }
}