using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{

    private void Start()
    {
        DestroyStar();
    }
    private void DestroyStar()
    {
        Destroy(gameObject, 3f);
    }
}
