using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;

    public GameObject[] obstacleInstances;
    public int numberOfInstances = 10;
    public int instanceCount = 0;

    public float timeToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn = Random.Range(1f,2f);

        obstacleInstances = new GameObject[numberOfInstances];

        for (int i = 0; i < numberOfInstances; i++)
        {
            obstacleInstances[i] = Instantiate(obstaclePrefab);
            obstacleInstances[i].transform.position = transform.position;
            obstacleInstances[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeToSpawn -= Time.deltaTime;

        if (timeToSpawn <= 0.0f)
        {
            SpawnObstacle();
            timeToSpawn = Random.Range(1f,3f);
        }
    }

    void SpawnObstacle()
    {
        obstacleInstances[instanceCount].SetActive(true);
        obstacleInstances[instanceCount].transform.position = transform.position;
        instanceCount++;
        if (instanceCount == numberOfInstances) instanceCount = 0;
    }
}
