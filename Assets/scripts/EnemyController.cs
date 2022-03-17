using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Rigidbody enemyRb;
    public float speed = 3.0f;
    int MoveDist = 20;
    int AttackDist = 5;
    GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
        if (Vector3.Distance(transform.position, player.transform.position) <= AttackDist)
            Debug.Log("I've got you in my sights");
    }
}
