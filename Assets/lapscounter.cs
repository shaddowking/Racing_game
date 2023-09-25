using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class lapscounter : MonoBehaviour
{
    public GameObject resetbutton;
    public GameObject nextLevelbutton;
    public GameObject MainMenuebutton;
    
    public TextMeshProUGUI P1counter;
    public TextMeshProUGUI P2counter;
    public TextMeshProUGUI wintext;

    public int player1laps;
    public int player2laps;
    
    // Start is called before the first frame update
    void Start()
    {
        wintext.gameObject.SetActive(false);
        player1laps = 0;
        player2laps = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player1")
        {
            player1laps++;
        }
        if (other.gameObject.tag == "player2")
        {
            player2laps++;
        }
    }


    // Update is called once per frame
    void Update()
    {
        P1counter.text = "P1 " + $"{player1laps}" + "/3";
        P2counter.text = "P2 " + $"{player2laps}" + "/3";

        if (player1laps == 1)
        {
            wintext.gameObject.SetActive(true);
            wintext.text = "player 1 won";
            Time.timeScale = 0;
            resetbutton.SetActive(true);
            nextLevelbutton.SetActive(true);
            MainMenuebutton.SetActive(true);

        }
        if (player2laps == 3)
        {
            wintext.gameObject.SetActive(true);
            wintext.text = "player 2 won";
            Time.timeScale = 0;
            resetbutton.SetActive(true);
            nextLevelbutton.SetActive(true);
            MainMenuebutton.SetActive(true);


        }
    }
}
