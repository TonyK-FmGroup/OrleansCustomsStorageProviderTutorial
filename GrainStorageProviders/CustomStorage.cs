using Orleans;
using Orleans.Runtime;
using Orleans.Storage;

namespace GrainStorageProviders;

public class CustomStorage : IGrainStorage, ILifecycleParticipant<ISiloLifecycle>
{
    public Task ClearStateAsync<T>(string stateName, GrainId grainId, IGrainState<T> grainState)
    {
        throw new NotImplementedException();
    }

    public void Participate(ISiloLifecycle observer)
    {
        throw new NotImplementedException();
    }

    public Task ReadStateAsync<T>(string stateName, GrainId grainId, IGrainState<T> grainState)
    {
        throw new NotImplementedException();
    }

    public Task WriteStateAsync<T>(string stateName, GrainId grainId, IGrainState<T> grainState)
    {
        throw new NotImplementedException();
    }
}
