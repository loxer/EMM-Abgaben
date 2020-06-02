using UnityEngine;
using Unity.Entities;

[GenerateAuthoringComponent]
public class PlayerComponent : IComponentData
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
