using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject catclose;
    public GameObject catopen;
    public TextMeshProUGUI scoretext;

    int score = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))        //¥ªÁä(0)«ö¤U
        //if(Input.touchCount == 1)
        {
            catclose.SetActive(false);
            catopen.SetActive(true);
            GetComponent<AudioSource>().Play();
            score++;
            scoretext.text = score.ToString();
        }
        else if(Input.GetMouseButtonUp(0)) 
        {
            catclose.SetActive(true);
            catopen.SetActive(false);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
