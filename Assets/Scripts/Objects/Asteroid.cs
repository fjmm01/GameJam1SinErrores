using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Asteroid : MonoBehaviour
{

    [SerializeField] GameObject target;
    [SerializeField] float asteroidSpeed;
    
   
    

    private void Start()
    {
        target = GameObject.FindWithTag("Player");
        this.gameObject.GetComponentInChildren<VisualEffect>().Play();        
        DestroyAsteroid();
        
    }

    private void Update()
    {
        transform.Translate(Vector3.left * asteroidSpeed * Time.deltaTime);
        /*if (grapplingRope.isGrappling && grapplingGun.isGrapplingAnObject)
        {
            Debug.Log("YOU HIT AN ASTEROID RUUUUN");
            StartCoroutine(Launch());
            Debug.Log(asteroidSpeed);
            transform.Translate(Vector3.left * asteroidSpeed * Time.deltaTime);
        }
        */
        
        
    }

    private void DestroyAsteroid()
    {
        Destroy(gameObject, 10f);
    }
    


    /*IEnumerator Launch()
    {
        yield return new WaitForSeconds(2f);

        asteroidSpeed += 10f * Time.deltaTime;
        

        yield return asteroidSpeed;
    }
    */
}
