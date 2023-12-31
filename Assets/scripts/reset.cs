using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class reset : MonoBehaviour
{
    
    public GameObject buttons;
    public TextMeshProUGUI wintext;

    public lapscounter laps;
    private int resetlapnumber = 0;

    public Rigidbody rbP1;
    public Transform player1start;
    public Transform player1;
    public Rigidbody rbP2;
    public Transform player2start;
    public Transform player2;

    private void Start()
    {
        wintext.gameObject.SetActive(false);

        Time.timeScale = 1;
        buttons.SetActive(false);
        
    }

    public void Reset()
    {
        rbP1.velocity = Vector3.zero;
        rbP2.velocity = Vector3.zero;
        Time.timeScale = 1;
        wintext.gameObject.SetActive(false);
        buttons.SetActive(false);

        player1.position = player1start.position;
        player1.rotation = player1start.rotation;
        player2.position = player2start.position;
        player2.rotation = player2start.rotation;
        
        laps.player1laps = resetlapnumber;
        laps.player2laps = resetlapnumber;
    }
}
