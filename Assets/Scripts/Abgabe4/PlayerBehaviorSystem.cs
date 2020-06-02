using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using System;


public class PlayerBehaviorSystem : SystemBase
{    
    protected override void OnUpdate() 
    {
        Entities.ForEach((ref PlayerComponent player, ref Translation translation, ref Rotation rotation) =>
        {
            player.rotationAngle = player.rotationAngle + Input.GetAxis("Horizontal");
            float3 targetDirection = new float3((float) math.sin(player.rotationAngle), 0, (float) math.cos(player.rotationAngle));
            
            rotation.Value = quaternion.LookRotationSafe(targetDirection, Vector3.up);
            translation.Value += player.speed * Input.GetAxis("Vertical") /* * new float3(1,0,1) */ * targetDirection;
        }).WithoutBurst().Run();
    }
}