using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class MenuPause : MonoBehaviour
    {
        public static bool GameIsPaused = false;
        
        public GameObject pauseMinuUI;

        private void Start()
        {
            Time.timeScale = 1f;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (GameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause_menu();
                }
            }
        }

        public void Resume()
        {
            pauseMinuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }

        void Pause_menu()
        {
            pauseMinuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }

        public void MainMenu()
        {
            SceneManager.LoadScene("Menu");
            Debug.Log("Выход в меню");
        }

        public void Restart()
        {
            SceneManager.LoadScene("Game");
        }
    
        public void ExitGame()
        {
            Application.Quit();
        }
    }
}

