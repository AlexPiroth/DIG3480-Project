using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float enemy2Horizontal;

    // Start is called before the first frame update
    void Start()
    {
        enemy2Horizontal = Random.Range(-2f, 2f);

    }

    // Update is called once per frame
    void Update()
    {
        

        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 3f);

        transform.Translate(new Vector3(enemy2Horizontal, -1, 0) * Time.deltaTime * 2f);
        if (transform.position.y < -6.5)
        {
            Destroy(this.gameObject);
        }
    }
}

