using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    #region Fields
    
    public GameObject enemy;
    public GameObject player;
    public float followingVelocity;

    #endregion

    void Start()
    {
        enemy = gameObject;
        player = GameObject.FindWithTag("Player");
        followingVelocity = .06f;
    }

  
    void Update()
    {
        enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, player.transform.position, followingVelocity);
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Enemy")
        {
            Destroy(enemy);
        }
    }
}
