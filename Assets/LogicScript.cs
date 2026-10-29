using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;

    public TextMeshProUGUI playerScoreText;

    public GameObject gameOverScreen;

    [ContextMenu("Add Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        playerScoreText.text = "SCORE :" + playerScore;
        Debug.Log(playerScore);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}