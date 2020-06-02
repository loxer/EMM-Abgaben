using System.Collections;
using System.Collections.Generic;

using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using Unity.Rendering;


public class SpawnCollectableSystem : ComponentSystem
{
    private Random random;
    // [SerializeField] private Mesh _mesh;
    // [SerializeField] private Material _material;

    protected override void OnCreate()
    {
        random = new Random(15);
    }


   
    // void Start()
    protected override void OnUpdate()
    {
        // EntityManager manager = World.DefaultGameObjectInjectionWorld.EntityManager;
        // Entity someEntity = manager.CreateEntity();

        

        Entities.ForEach((ref SpawnCollectableComponent spawnCollectable) => {
            Entity newTable = EntityManager.Instantiate(spawnCollectable.prefab);
        

            EntityManager.SetComponentData(newTable, 
                new Translation {Value = new float3(random.NextFloat(-5f, 5f), 0.5f, random.NextFloat(-5f, 5f))}
            );
        

        });




        // EntityManager manager = World.DefaultGameObjectInjectionWorld.EntityManager;
        // EntityArchetype archetype = manager.CreateArchetype(
        //     typeof(Translation),
        //     typeof(Rotation),
        //     typeof(LocalToWorld),
        //     typeof(RenderMesh),
        //     typeof(RenderBounds)
        // );

        // Entity table = manager.CreateEntity(archetype);
        
        // // GameObject somer = spawnCollectable.prefab;

        // manager.AddComponentData(table, new Translation
        // {
        //     Value = new float3(0, 1, 2)
        // });

        // manager.AddSharedComponentData(table, new RenderMesh{
            
        // });    
    }
}
