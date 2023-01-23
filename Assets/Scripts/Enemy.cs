using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRb;
    public float speed = 3.0f;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized; //Direction to look towards player

        enemyRb.AddForce(lookDirection * speed); //Vector3 coordinates we need to take to get to player, subtract (normalized) THEN multiply
    }
}
