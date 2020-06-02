// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// using Unity.Entities;
// using Unity.Mathematics;
// using Unity.Transforms;

// public class Test : MonoBehaviour
// {
//     // private Random random;
//     private Entity sphereEntity;
//     private EntityManager entityManager;
//     private BlobAssetStore blobAssetStore;

//     private void Awake()
//     {
//         GameObject collectables = GameObject.Find("CollectableNew");

//         entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
//         blobAssetStore = new BlobAssetStore();
//         GameObjectConversionSettings settings = GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, blobAssetStore);
//         sphereEntity = GameObjectConversionUtility.ConvertGameObjectHierarchy(collectables.numberOfCollectables)
//     }

//     // Start is called before the first frame update
//     void Start()
//     {
//         // new Unity.Random((uint) UnityEngine.Random.Range(0, int.MaxValue));
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }
