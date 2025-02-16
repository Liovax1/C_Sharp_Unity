using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab; // Assigner le prefab dans l'Inspector
    public float spawnRate = 4f;  // Temps entre chaque plateforme
    public float spawnHeight = 3f; // Hauteur aléatoire

    void Start()
    {
        InvokeRepeating("SpawnPlatform", 1f, spawnRate);
    }

    void SpawnPlatform()
    {
        float randomY = Random.Range(-spawnHeight, spawnHeight);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, 0);

        GameObject newPlatform = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
    }

}
