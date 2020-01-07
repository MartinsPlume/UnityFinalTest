
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Code data")]
    int buttons = 3;
    string scoreText;
    float startTime;
    int t=30;

    [Header("References")]
    public Text score;
    public Text highscore;
    public Text result;
    public Button clearHighScore;
    public Button NewGameButton;
    void Start()
    {
        startTime = 30;
        highscore.text=PlayerPrefs.GetInt("HighScore",0).ToString();
        clearHighScore.onClick.AddListener(DeleteHighScore);
        NewGameButton.onClick.AddListener(StartNewGame);
    }

    public void ButtonMarked()
    {
        buttons -= 1;
        Debug.Log(buttons);
    }

    // Update is called once per frame
    void Update()
    {
        if (buttons != 0 & t>0) { 
        t = Mathf.RoundToInt(startTime - Time.timeSinceLevelLoad);
        scoreText = t.ToString();
        score.text = scoreText;
        }

        if (t <= 0)
        {
            result.text = "You lost!";
            result.gameObject.SetActive(true);
        }

        if (buttons == 0 & t>0)
        {
            if (t > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", t);
                highscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
            }
            result.text = "You Won!";
            result.gameObject.SetActive(true);
        }
    }

    void StartNewGame()
    {
        SceneManager.LoadScene(0);
    }
    public void DeleteHighScore()
    {
        PlayerPrefs.DeleteAll();
        highscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}
