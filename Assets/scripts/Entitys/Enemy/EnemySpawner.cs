using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public float timer;
    public GameObject enemyPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;    
    
        if(timer > 2f) 
        {
            timer = 0;
            float x = Random.Range(-24f, 24f);
            float y = Random.Range(-24f, 24f);

            var position = new Vector3(x, y, 0);

            Instantiate(enemyPrefab, position, new Quaternion());
        }
    }
}
