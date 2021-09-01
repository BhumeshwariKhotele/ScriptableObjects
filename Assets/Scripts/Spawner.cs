using System;
using Unity.Entities;
using UnityEngine;

public class Spawner : IComponentData
{
    public Entity prefab;
    public int Erows, Ecols;
}
