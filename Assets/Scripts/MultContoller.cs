using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultContoller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke ("NextScen", 10f);
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            SceneManager.LoadScene("Game");
        }
    }

    void NextScen()
    {
        SceneManager.LoadScene("Game");
    }
}
