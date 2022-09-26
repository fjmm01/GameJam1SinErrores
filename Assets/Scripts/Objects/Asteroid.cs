using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    [SerializeField] GameObject target;
    [SerializeField] float asteroidSpeed;
    
    public TesteGrapplingRope grapplingRope;
    public TestGrapplingGun grapplingGun;
    

    private void Start()
    {
        target = GameObject.FindWithTag("Player");
        grapplingGun = target.GetComponentInChildren<TestGrapplingGun>();
        grapplingRope = target.GetComponentInChildren<TesteGrapplingRope>();
        DestroyAsteroid();
        
    }

    private void Update()
    {
        transform.Translate(Vector3.left * asteroidSpeed * Time.deltaTime);
        if (grapplingRope.isGrappling && grapplingGun.isGrapplingAnObject)
        {
            Debug.Log("YOU HIT AN ASTEROID RUUUUN");
            StartCoroutine(Launch());
            Debug.Log(asteroidSpeed);
            transform.Translate(Vector3.left * asteroidSpeed * Time.deltaTime);
        }
        
        
    }

    private void DestroyAsteroid()
    {
        Destroy(gameObject, 10f);
    }
    


    IEnumerator Launch()
    {
        yield return new WaitForSeconds(2f);

        asteroidSpeed += 10f * Time.deltaTime;
        

        yield return asteroidSpeed;
    }
}
