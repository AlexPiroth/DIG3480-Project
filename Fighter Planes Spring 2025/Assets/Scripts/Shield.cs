using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject player;
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerController = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        if (!playerController.shieldsUp)
        {
            Destroy(this.gameObject);
        }
    }
}
