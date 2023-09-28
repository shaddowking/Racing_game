using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject P1controlUI;
    public GameObject P2controlUI;
    public GameObject resumebutton;
    public GameObject menue;
    // Start is called before the first frame update
    void Start()
    {
        menue.SetActive(false);
        resumebutton.SetActive(false);
        P1controlUI.SetActive(false);
        P2controlUI.SetActive(false);

    }

    public void resume()
    {
        Time.timeScale = 1;
        menue.SetActive(false);
        resumebutton.SetActive(false);
        P1controlUI.SetActive(false);
        P2controlUI.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            menue.SetActive(true);
            resumebutton.SetActive(true);
            P1controlUI.SetActive(true);
            P2controlUI.SetActive(true);

        }
        
    }
}
