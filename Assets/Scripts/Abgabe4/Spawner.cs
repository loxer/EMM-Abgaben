// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using Unity.Entities;
// using Unity.Mathematics;
// using Unity.Transforms;
// using Unity.Rendering;

// public class Spawner : MonoBehaviour
// {
//     [SerializeField] private Mesh _mesh;
//     [SerializeField] private Material _material;

//     void Start()
//     {
//         MakeEntity();
//     }

//     // Update is called once per frame
//     private void MakeEntity()
//     {
//         SpawnCollectableComponent spawnCollectable;
//          if(spawnCollectable.numberOfCollectables == ) {

//          }
//         // int someNumber =;
//         // spawnCollectable.prefab

//         EntityManager manager = World.DefaultGameObjectInjectionWorld.EntityManager;
//             EntityArchetype archetype = manager.CreateArchetype(
//             typeof(Translation),
//             typeof(Rotation),
//             typeof(LocalToWorld),
//             typeof(RenderMesh),
//             typeof(RenderBounds)            
//         );
        
//         Entity table = manager.CreateEntity(archetype);
//         manager.AddComponentData(table, new Translation
//         { Value = new float3(            
//                 new Unity.Mathematics.Random((uint)UnityEngine.Random.Range(0, int.MaxValue)).NextFloat(-4.5f, 4.5f),
//                 0, 
//                 new Unity.Mathematics.Random((uint)UnityEngine.Random.Range(0, int.MaxValue)).NextFloat(-4.5f, 4.5f)
            
//         )});

//         manager.AddSharedComponentData(table, new RenderMesh
//         {
//             mesh = _mesh,
//             material = _material
//         });  
//     }
// }
