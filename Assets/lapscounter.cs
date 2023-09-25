using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class lapscounter : MonoBehaviour
{
    public TextMeshProUGUI P1counter;
    public TextMeshProUGUI P2counter;

    public int player1laps;
    public int player2laps;
    
    // Start is called before the first frame update
    void Start()
    {
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
    }
}
