using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    [SerializeField] GameObject star;
    [SerializeField] GameObject asteroid;
    [SerializeField] GameObject satelite;
    [SerializeField] GameObject shield;

    [SerializeField] float respawnTimeAsteroid;
    [SerializeField] float respawnTimeSatelite;
    [SerializeField] float respawnTimeStar;
    [SerializeField] float respawnTimeShield;

    [SerializeField] BoxCollider2D spawnArea;
    public Vector2 spawnBounds;
    


    void Awake()
    {
        spawnBounds = new Vector2(spawnArea.size.x,spawnArea.size.y);
        StartCoroutine(Asteroid());
        StartCoroutine(Satelite());
        StartCoroutine(Star());
        StartCoroutine(Shield());
    }

    
    void Update()
    {
        
        
    }



    private void SpawnAsteroid(GameObject asteroid)
    {
        GameObject a = Instantiate(asteroid);
        a.transform.position = new Vector2(spawnBounds.x, Random.Range(-spawnBounds.y, spawnBounds.y));
        
    }

    private void SpawnSatelite(GameObject satelite)
    {
        GameObject b = Instantiate(satelite);
        b.transform.position = new Vector2(Random.Range(-spawnBounds.x, spawnBounds.x),spawnBounds.y);
    }

    private void SpawnStar(GameObject star)
    {
        GameObject c = Instantiate(star);
        c.transform.position = new Vector2(Random.Range(-spawnBounds.x, spawnBounds.x), Random.Range(-spawnBounds.y, spawnBounds.y));
    }
    private void SpawnShield(GameObject shield)
    {
        GameObject d = Instantiate(shield);
        d.transform.position = new Vector2(Random.Range(-spawnBounds.x, spawnBounds.x), Random.Range(-spawnBounds.y, spawnBounds.y));
    }

    IEnumerator Asteroid()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTimeAsteroid);
            SpawnAsteroid(asteroid);
        }
    }
    IEnumerator Satelite()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTimeSatelite);
            SpawnSatelite(satelite);
        }
    }
    IEnumerator Star()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTimeStar);
            SpawnStar(star);
        }
    }
    IEnumerator Shield()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTimeShield);
            SpawnShield(shield);
        }
    }
}
