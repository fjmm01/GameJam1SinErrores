using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField] Transform centerBackGround;
    [SerializeField] float size;

    private void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.y >= centerBackGround.position.y + size)
        {
            centerBackGround.position = new Vector2(centerBackGround.position.x, transform.position.y + size);
        }
        else if(transform.position.y < centerBackGround.position.y - size)
        {
            centerBackGround.position = new Vector2(centerBackGround.position.x, transform.position.y - size);
        }
    }

    
}
