using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerate : ObjectPool
{
    [SerializeField] private GameObject[] _template;
    [SerializeField] private float _secondsBetweenSpawn;
    [SerializeField] private float _maxSpawnPositionY;
    [SerializeField] private float _minSpawnPositionY;

    private float _elapsedTime = 0;

    private void Start()
    {
        Initialize(_template);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if(_elapsedTime > _secondsBetweenSpawn)
        {
            if(TryGetObject(out GameObject cube))
            {
                _elapsedTime = 0;

                float spawnPositionY = Random.Range(_minSpawnPositionY, _maxSpawnPositionY);
                Vector3 spawnPoint = new Vector3(transform.position.x, spawnPositionY, transform.position.z);
                cube.SetActive(true);
                cube.transform.position = spawnPoint;

                DisableObjectAbroadScreen();

            }
        }
    }

}
