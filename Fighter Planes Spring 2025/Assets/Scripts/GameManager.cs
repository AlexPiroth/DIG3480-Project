using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject EnemyOnePrefab;
    public GameObject EnemyTwoPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyOne", 1, 2);
        InvokeRepeating("CreateEnemyTwo", 6, Random.Range(1f, 5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateEnemyOne()
    {
        Instantiate(EnemyOnePrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }

    void CreateEnemyTwo()
    {
        Instantiate(EnemyTwoPrefab, new Vector3(Random.Range(-7f, 7f), 6.5f, 0), Quaternion.identity);
    }
}
