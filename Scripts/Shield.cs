using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindAnyObjectByType<Player>().gameObject;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        transform.rotation = player.transform.rotation;
    }
}
