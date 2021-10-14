using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public GameObject CompleteLevelUI;

    public void Finish()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            CompleteLevel();
        }
    }

    void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }
}