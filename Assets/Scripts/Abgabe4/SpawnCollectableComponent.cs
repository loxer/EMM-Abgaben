using Unity.Entities;


[GenerateAuthoringComponent]
public struct SpawnCollectableComponent : IComponentData
{
    public int count;
    public Entity prefab;
}
