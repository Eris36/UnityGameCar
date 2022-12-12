using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class MenuControls : MonoBehaviour
    {
        public void PlayPressed()
        {
            SceneManager.LoadScene("Game");
        }
    
        public void ExitPressed()
        {
            Debug.Log("Exit pressed!");
            Application.Quit();
        }
    }
}

