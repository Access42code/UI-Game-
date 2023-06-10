using UnityEngine;

public class ToggleContainer : MonoBehaviour
{
    public GameObject container; 

    private bool isContainerVisible = false; 
    private bool isPaused = false; 
    
    public void OnMenuButtonClicked()
    {
        if (isContainerVisible)
        {
            HideContainer();
        }
        else
        {
            ShowContainer();
        }
        TogglePause();
    }

    
    private void ShowContainer()
    {
        container.SetActive(true);
        isContainerVisible = true;
    }

    
    private void HideContainer()
    {
        container.SetActive(false);
        isContainerVisible = false;
    }

    
    private void TogglePause()
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