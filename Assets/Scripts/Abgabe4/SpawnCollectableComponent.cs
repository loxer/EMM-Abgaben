using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct SpawnCollectableComponent : IComponentData
{
    public int count;
    public Entity prefab;

}
