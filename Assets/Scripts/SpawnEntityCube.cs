using System;
using Unity.Entities;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEntityCube : MonoBehaviour, IDeclareReferencedPrefabs, IConvertGameObjectToEntity
{

    public GameObject entityCube;
    public int rows, columns;

    public void DeclaredReferencePrefabs(List<GameObject> gameObjects)
    {
        gameObjects.Add(entityCube);
    }

    public void Convert(Entity entity, EntityManager entityManager, GameObjectConversionSystem conversionSystem)
    {
        var spawnerData = new Spawner
        {
            prefab = conversionSystem.GetPrimaryEntity(entityCube),
            Erows = rows,
            Ecols = columns
        };
        entityManager.AddComponentData(entity, spawnerData);
    }
}