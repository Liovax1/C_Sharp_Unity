using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab; // Le prefab de la plateforme
    public float spawnRate = 2f; // Temps entre chaque spawn
    public float minHeight = 128f; // Hauteur minimale
    public float maxHeight = 135f; // Hauteur maximale

    private Vector3 spawnPos; // Position d’apparition des plateformes

    void Start()
    {
        // Lancer le spawn des plateformes à intervalle régulier
        InvokeRepeating(nameof(SpawnPlatform), 0f, spawnRate);
    }

    void SpawnPlatform()
    {
        // Définir la position de spawn avec une hauteur variable
        // X et Z sont fixes, mais Y (hauteur) varie entre minHeight et maxHeight
        spawnPos = new Vector3(-11.80107f, Random.Range(10.5f, 13f), -10.5f); // La plage de hauteur a été étendue ici

        // Instancier la plateforme
        GameObject platform = Instantiate(platformPrefab, spawnPos, Quaternion.identity);

        Debug.Log($"Plateforme spawnée à : {spawnPos}");
    }


}
