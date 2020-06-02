using System.Collections;
using System.Collections.Generic;

using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using Unity.Rendering;
// using Unity.Burst;


public class SpawnCollectableSystem : SystemBase
{
    BeginInitializationEntityCommandBufferSystem m_EntityCommandBufferSystem;

    protected override void OnCreate()
    {
        m_EntityCommandBufferSystem = World.GetOrCreateSystem<BeginInitializationEntityCommandBufferSystem>();
    }


    protected override void OnUpdate()
    {
        var commandBuffer = m_EntityCommandBufferSystem.CreateCommandBuffer().ToConcurrent();

        // for(int i = )

        Entities
            // .WithBurst(FloatMode.Default, FloatPrecision.Standard, true)
            .ForEach((Entity entity, int entityInQueryIndex, in SpawnCollectableComponent spawnCollectableComponent) => 
        {
            for(var i = 0; i < spawnCollectableComponent.count; i++)
            {
                Entity entityInstance = commandBuffer.Instantiate(entityInQueryIndex, spawnCollectableComponent.prefab);
                commandBuffer.SetComponent(entityInQueryIndex, entityInstance, new Translation
                {
                    Value = new float3(            
                        new Unity.Mathematics.Random((uint)UnityEngine.Random.Range(0, int.MaxValue)).NextFloat(-4.5f, 4.5f),
                        0, 
                        new Unity.Mathematics.Random((uint)UnityEngine.Random.Range(0, int.MaxValue)).NextFloat(-4.5f, 4.5f))
                });
            }
            
            commandBuffer.DestroyEntity(entityInQueryIndex, entity);
        }).ScheduleParallel();

        m_EntityCommandBufferSystem.AddJobHandleForProducer(Dependency);

            // ref SpawnCollectableComponent spawnCollectable
            // Entity newTable = EntityManager.Instantiate(spawnCollectable.prefab);
        

            // EntityManager.SetComponentData(newTable, 
            //     new Translation {Value = new float3(random.NextFloat(-4.5f, 4.5f), 0.5f, random.NextFloat(-4.5f, 4.5f))}
            // );


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
