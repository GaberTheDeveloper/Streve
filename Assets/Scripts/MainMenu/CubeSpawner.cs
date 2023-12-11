using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [Header("Cube Spawning")]
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private Vector2 spawnLocation;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float spawnDelay = 5f;


    private void Start()
    {
        StartCoroutine(SpawnMenuCubes());
    }

    private IEnumerator SpawnMenuCubes()
    {
        while (true) // Infinite loop
        {
            GameObject cubeObj = Instantiate(cubePrefab, spawnLocation, Quaternion.identity); // Spawn cube
            Coroutine moveCoroutine = StartCoroutine(MoveBackgroundCube(cubeObj)); // Move cube
            yield return new WaitForSeconds(spawnDelay); // Wait some time
            StopCoroutine(moveCoroutine);
            Destroy(cubeObj); // Delete cube
        }
    }

    private IEnumerator MoveBackgroundCube(GameObject cubeObj)
    {
        while (true)
        {
            cubeObj.transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
            yield return null;
        }
    }
}
