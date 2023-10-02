using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        

    }

    public void mainmenu()
    {
        SceneManager.LoadScene("main menu");
    }

    
    public void Level1()
    {
        SceneManager.LoadScene("level 1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("level 2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("level 3");
    }


    public void Quit()
    {
        Application.Quit();
        Debug.Log("quit game");
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
