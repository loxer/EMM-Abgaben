using UnityEngine;
using Unity.Entities;

[GenerateAuthoringComponent]
public class SpawnCollectableComponent : IComponentData
{
    public int numberOfCollectables;
    public Entity collectablePrefab;
}
