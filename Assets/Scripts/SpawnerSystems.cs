using Unity.Collections;
using Unity.Burst;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

public class SpawnerSystems : JobComponentSystem
{
    EndFixedStepSimulationEntityCommandBufferSystem m_EntityCommandBufferSystem;

    protected override void OnCreate()
    {
        m_EntityCommandBufferSystem = World.GetOrCreateSystem<EndSimulationEntityCommandBufferSystem>();
    }

    struct SpawnJob:
        {
        public EntityCommandBuffer commandBuffer;
        public void Execute(Entity entity, int index, [ReadOnly] ref Spawner spawner,[ReadOnly] ref LocalToWorld)
        {
            for (int x = 0; x < spawner.Erows; x++)
            {
                for (int z = 0; z < spawner.Ecols; z++)
                {
                    var instance = commandBuffer.Instantiate(spawner.prefab);
                    var pos = math.transform(location.Value, new float3(x, noise.cnoise(new float2(x, z) * 0.21f), z));
                    commandBuffer.SetComponent(instance, new Translation { Value = pos });
                }
            }
            commandBuffer.DestroyEntity(entity);
        }
    }
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        var job = new SpawnJob
        {
            commandBuffer = m_EntityCommandBufferSystem.CreateCommandBuffer();
        }.ScheduleSingle(this, inputDeps);

    
    }


}
