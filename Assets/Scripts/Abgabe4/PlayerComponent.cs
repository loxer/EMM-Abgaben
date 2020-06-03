using Unity.Entities;

[GenerateAuthoringComponent]
public struct PlayerComponent : IComponentData
{

    public float speed;
    public float rotationAngle;
    

    // Start is called before the first frame update
    // void Start()
    // {
    //     EntityManager manager = World.DefaultGameObjectInjectionWorld.EntityManager;
    //     manager.CreateEntity();
    // }

}
