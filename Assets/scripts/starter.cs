using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starter : MonoBehaviour
{

    public GameObject levels;
    // Start is called before the first frame update
    void Start()
    {
        levels.SetActive(false);
    }

    public void startbutton()
    {
        levels.SetActive(true);

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
