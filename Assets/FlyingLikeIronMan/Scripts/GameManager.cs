using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public GameObject ammoPrefab;

    public Text scoreText;
    private int _score;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        _score = 0;
        scoreText.text = "Score: " + _score.ToString();
    }

    public void updateScore()
    {
        _score += 1;
        scoreText.text = "Score: " + _score.ToString();
    }

}
