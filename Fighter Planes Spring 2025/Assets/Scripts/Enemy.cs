using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float enemy2Horizontal;
    [SerializeField] private int enemyType;
    private float horizontalLimit = 8.5f;

    // Start is called before the first frame update
    void Start()
    {
        enemy2Horizontal = UnityEngine.Random.Range(-2f, 2f);

    }

    // Update is called once per frame
    void Update()
    {


        if (enemyType == 1)
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 3f);
        }
        else if (enemyType == 2)
        {
            transform.Translate(new Vector3(enemy2Horizontal, -1, 0) * Time.deltaTime * 2f);
            if (Math.Abs(transform.position.x) >= horizontalLimit)
            {
                enemy2Horizontal = -enemy2Horizontal;
            }
        }
        if (transform.position.y < -6.5)
        {
            Destroy(this.gameObject);
        }
    }
}

