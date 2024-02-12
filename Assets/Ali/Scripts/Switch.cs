using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    public GameObject[] Courasel;
    public int index;
    
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (index >= 4)
            index = 4;

        if (index < 0) ;
        index = 0;

        if (index == 0)
        {
            Courasel[0].gameObject.SetActive(true);
        }
    }

    public void Next()
    {
        index += 1;

        for (int i = 0; i < Courasel.Length; i++)
        {
            Courasel[i].gameObject.SetActive(false);
            Courasel[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }

    public void Previous()
    {
        index -= 1;

        for (int i = 0; i < Courasel.Length; i++)
        {
            Courasel[i].gameObject.SetActive(false);
            Courasel[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    } 
}
