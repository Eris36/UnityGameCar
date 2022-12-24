using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class MenuControls : MonoBehaviour
    {
        public void PlayPressed()
        {
            SceneManager.LoadScene("Mult");
        }
    
        public void ExitPressed()
        {
            Debug.Log("Exit pressed!");
            Application.Quit();
        }
    }
}

