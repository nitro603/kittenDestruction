using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript instance;

    public Text ScoreText;

    public int score;

    private void Awake(){
        instance = this;
        score = MainManager.Instance.totalPoints;
    }

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = score.ToString() + " Points";
    }

    // Update is called once per frame
    void Update()
    {
        score = MainManager.Instance.totalPoints;
    }

    public void AddPoint(int value){
        score += value;
        if(MainManager.Instance != null){
            MainManager.Instance.totalPoints += value;
            Debug.Log("Main Points: " + MainManager.Instance.totalPoints);
        }
        ScoreText.text = score.ToString() + " Points";
    }
}
