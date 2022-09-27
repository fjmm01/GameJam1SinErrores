using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnvironment : MonoBehaviour
{
    [SerializeField] Transform environment;
    [SerializeField] Transform player;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        environment.position = new Vector3(environment.position.x, player.position.y, environment.position.z);
    }
}
