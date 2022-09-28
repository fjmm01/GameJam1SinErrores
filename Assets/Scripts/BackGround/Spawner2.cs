using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    [SerializeField] Transform player;
    public GameObject star;
    [SerializeField] GameObject asteroid;
    [SerializeField] GameObject satelite;
    [SerializeField] GameObject shield;

    [SerializeField] float respawnTimeAsteroid;
    [SerializeField] float respawnTimeSatelite;
    [SerializeField] float respawnTimeStar;
    [SerializeField] float respawnTimeShield;


    public Vector3 center;
    public Vector2 spawnBounds;
    public Vector3 offset;
    
    void Awake()
    {
        center = new Vector3(transform.position.x, player.position.y + offset.y, transform.position.z);
        StartCoroutine(Star());
        StartCoroutine(Shield());
        StartCoroutine(Asteroid());
        StartCoroutine(Satelite());
    }

   
    void Update()
    {
        if(player != null)
        {
            center = new Vector3(transform.position.x, player.position.y + offset.y, transform.position.z);
        }
        else
        {
            return;
        }
        
    }

    public void SpawnStar(GameObject prefab)
    {
        Vector3 pos = center + new Vector3(Random.Range(-spawnBounds.x/2,spawnBounds.x/2),Random.Range(-spawnBounds.y/2, spawnBounds.y/2),transform.position.z);

        Instantiate(prefab,pos,Quaternion.FromToRotation(new Vector3(0,0,0),new Vector3(360,0,0)));
    }

    public void SpawnShield(GameObject prefab)
    {
        Vector3 pos = center + new Vector3(Random.Range(-spawnBounds.x / 2, spawnBounds.x / 2), Random.Range(-spawnBounds.y / 2, spawnBounds.y / 2), transform.position.z);

        Instantiate(prefab, pos, Quaternion.identity);
    }

    public void SpawnAsteroid(GameObject prefab)
    {
        Vector3 pos = center + new Vector3(spawnBounds.x, Random.Range(-spawnBounds.y / 2, spawnBounds.y / 2), transform.position.z);

        Instantiate(prefab, pos, Quaternion.identity);
    }

    public void SpawnSatelite(GameObject prefab)
    {
        Vector3 pos = center + new Vector3(Random.Range(-spawnBounds.x / 2, spawnBounds.x / 2), spawnBounds.y, transform.position.z);

        Instantiate(prefab, pos, Quaternion.identity);
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
    IEnumerator Asteroid()
    {
        while (true)
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

   /* private void OnDrawGizmos()
    {
        
        Gizmos.color = Color.white;
        
        
        Gizmos.DrawCube(center, spawnBounds);
    }
   */
   
}
