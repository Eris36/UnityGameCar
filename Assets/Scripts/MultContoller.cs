using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultContoller : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundPeople;
    public AudioClip soundBoll;
    public AudioClip soundTsunami;
    public AudioClip humanOyo;
    public AudioClip humanAaaa;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(soundPeople);
        audioSource.Play();
        Invoke ("NextScen", 10f);
        Invoke("HumanScared", 4f);
        Invoke("HumanRun", 8f);
        Invoke("SoundBoll", 4.8f);
        Invoke("Tsunami", 3f);
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

    void SoundBoll()
    {
        audioSource.PlayOneShot(soundBoll);
    }

    void HumanScared()
    {
        audioSource.PlayOneShot(humanOyo);
    }
    
    void HumanRun()
    {
        audioSource.PlayOneShot(humanAaaa);
    }
    
    void Tsunami()
    {
        audioSource.PlayOneShot(soundTsunami);
    }

}
