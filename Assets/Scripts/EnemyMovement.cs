using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    Target playerHealth;
    
    Target enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = GetComponent<Target>();
        enemyHealth = GetComponent<Target>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        if(enemyHealth.health > 0 && playerHealth.health > 0)
        {
            nav.SetDestination(player.position);
        }
        else{
            nav.enabled = false;
        }
    }
}
