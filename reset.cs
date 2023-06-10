using UnityEngine;

public class PauseButton : MonoBehaviour
{
    private bool isPaused = false; 

    
    public void OnPauseButtonClicked()
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    
    private void PauseGame()
    {
        Time.timeScale = 0f; 
        isPaused = true;
    }

    
    private void ResumeGame()
    {
        Time.timeScale = 1f; 
        isPaused = false;
    }
}
