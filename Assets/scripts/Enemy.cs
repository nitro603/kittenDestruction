using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {

    public int health;
    public int value;
    

//get score from main manager, once a point level is reached change scene
//check points every time an enemy is killed.

    private void Update()
    {
        if (health <= 0) {
            ScoreScript.instance.AddPoint(value);
            int totalPoints = MainManager.Instance.totalPoints;
            int levelCap = MainManager.Instance.levelCap;

            if(totalPoints >= levelCap){
                MainManager.Instance.levelCap = (totalPoints * 3);
                Debug.Log("level cap: " + levelCap);
                if(SceneManager.GetActiveScene().buildIndex < 3){
                    SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage) {
        health -= damage;
    }
}