using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public static bool IsGameStarted = false;
    public GameObject Logo, PlayImage, CountMoves, LoseText, WinText, LevelsImage, RestartImage;

    public void PlayGame()
    {
        IsGameStarted = true;
        Logo.SetActive(false);
        PlayImage.SetActive(false);
        CountMoves.SetActive(true);
        
    }

    public void WinGame()
    {
        WinText.SetActive(true);
        RestartImage.SetActive(true);
        LevelsImage.SetActive(true);
        CountMoves.SetActive(false);
    }

    public void LoseGame()
    {
        IsGameStarted = false;
        LoseText.SetActive(true);
        RestartImage.SetActive(true);
        CountMoves.SetActive(false);
        LevelsImage.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
