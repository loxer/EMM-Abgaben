using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public GameObject collectable;
    public GameObject vfxGraph;

    public int numberOfCollectables;

    private const float POS_HEIGHT = 0.38f;

    
    private float sizeOfCollectable = 1.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        Vector3[] spawnPositions = new Vector3[numberOfCollectables];
        Debug.Log(numberOfCollectables);

        for(int i = 0; i < numberOfCollectables; i++) 
        {

            Vector3 spawnPos = getSpawnPoint(spawnPositions);
            spawnPositions[i] = spawnPos;
            
            GameObject newCollectable = Instantiate(collectable, spawnPos, Quaternion.identity);
            GameObject newVFXGraph = Instantiate(vfxGraph);
            newVFXGraph.transform.position = spawnPos;

        }
    
        // printPos(spawnPositions);
    }

    // Update is called once per frame
    void Update()
    {


    }

    private Vector3 getSpawnPoint(Vector3[] spawnPositions)
    {
        Vector3 spawnPos = generateRandomSpawnPoint();

        while(spawnCollates(spawnPositions, spawnPos))
        {
            spawnPos = generateRandomSpawnPoint();
        }
        return spawnPos;
    }

    private Vector3 generateRandomSpawnPoint()
    {
        float spawnPosX = UnityEngine.Random.Range(-4.5f, 4.5f);
        float spawnPosZ = UnityEngine.Random.Range(-4.5f, 4.5f);
        Vector3 spawnPos = new Vector3(spawnPosX, POS_HEIGHT, spawnPosZ);
        return spawnPos;
    }

    private bool spawnCollates(Vector3[] spawnPositions, Vector3 spawnPos)
    {
        for(int i = 0; i < spawnPositions.Length; i++)
        {
            if(spawnPositions[i].x + sizeOfCollectable >= spawnPos.x && spawnPositions[i].x - sizeOfCollectable < spawnPos.x &&
                spawnPositions[i].z + sizeOfCollectable >= spawnPos.z && spawnPositions[i].z - sizeOfCollectable < spawnPos.z)
                {
                    return true;
                }
        }
        return false;
    }

    private void printPos(Vector3[] spawnPositions)
    {
        for(int i = 0; i < spawnPositions.Length; i++) 
        {
            Debug.Log(spawnPositions[i]);
        }
        // Debug.Log(collectables.transform.position.x);
    }


}
