using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    [SerializeField]
    public Transform target;
    public float maxY;
    public float minY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(target.position.y, minY, maxY), transform.position.z);
        }
        else
        {
            return;
        }
       
    }
}
