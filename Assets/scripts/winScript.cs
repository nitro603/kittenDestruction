using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winScript : MonoBehaviour
{

    public GameObject winScreenUI;
    public Enemy boss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        Debug.Log(boss.health);
        if (boss.health <= 15) {
            
            StartCoroutine (spawnScreen());
        }
    }

    private IEnumerator spawnScreen()
    {
        yield return new WaitForSeconds(1);
        
        winScreenUI.SetActive(true);
    }
}
