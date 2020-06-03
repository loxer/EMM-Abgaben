using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using UnityEngine;

public class CollectedComponentBehavior : SystemBase
{
    protected override void OnUpdate()
    {        
        Entities.ForEach((ref CollectedComponent table, ref Rotation rotation) =>
        {
            table.rotationAngle += Time.DeltaTime;
            float3 targetDirection = new float3((float) math.sin(table.rotationAngle), 0, (float) math.cos(table.rotationAngle));
            
            rotation.Value = quaternion.LookRotationSafe(targetDirection, new Vector3(0, 1, 0));
        }).WithoutBurst().Run();
    }    
}
