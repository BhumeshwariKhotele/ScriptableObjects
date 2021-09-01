using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[RequiresEntityConversion]
public class ECSDemoScript : MonoBehaviour, IConvertGameObjectToEntity
{
    public void Convert(Entity entity,EntityManager entityManager,GameObjectConversionSystem conversionSystem )
    {
        var data = new PerlinPosition { };
        entityManager.AddComponentData(entity, data);
    }


}
