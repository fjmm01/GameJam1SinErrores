using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satelite : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float sateliteSpeed;

    public TesteGrapplingRope grapplingRope;
    public TestGrapplingGun grapplingGun;


    private void Start()
    {
        target = GameObject.FindWithTag("Player");
        grapplingRope = target.GetComponentInChildren<TesteGrapplingRope>();
        grapplingGun = target.GetComponentInChildren<TestGrapplingGun>();
        DestroySatelite();

    }

    private void Update()
    {
        transform.Translate(Vector3.down * sateliteSpeed * Time.deltaTime);
        if (grapplingRope.isGrappling && grapplingGun.isGrapplingAnObject == true)
        {
            Debug.Log("YOU HIT AN SATELITE RUUUUN");
            StartCoroutine(Launch());
            Debug.Log(sateliteSpeed);
            transform.Translate(Vector3.down * sateliteSpeed * Time.deltaTime);
        }


    }

    private void DestroySatelite()
    {
        Destroy(gameObject, 10f);
    }



    IEnumerator Launch()
    {
        yield return new WaitForSeconds(2f);

        sateliteSpeed += 10f * Time.deltaTime;


        yield return sateliteSpeed;
    }
}
