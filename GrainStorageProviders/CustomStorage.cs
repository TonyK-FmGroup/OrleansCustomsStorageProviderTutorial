using Orleans;
using Orleans.Runtime;
using Orleans.Storage;

namespace GrainStorageProviders;

public class CustomStorage : IGrainStorage, ILifecycleParticipant<ISiloLifecycle>
{
    private string StorageName;
    public CustomStorage(string storageName)
    {
        StorageName = storageName;
    }

    public Task ClearStateAsync<T>(string stateName, GrainId grainId, IGrainState<T> grainState)
    {
        throw new NotImplementedException();
    }

    public void Participate(ISiloLifecycle observer)
    {
        observer.Subscribe(
       OptionFormattingUtilities.Name<CustomStorage>(StorageName),
       ServiceLifecycleStage.ApplicationServices,  Init);
    }

    public Task ReadStateAsync<T>(string stateName, GrainId grainId, IGrainState<T> grainState)
    {
        throw new NotImplementedException();
    }

    public Task WriteStateAsync<T>(string stateName, GrainId grainId, IGrainState<T> grainState)
    {
        throw new NotImplementedException();
    }

    private Task Init(CancellationToken ct)
    {
        // set something up here for the service
        return Task.CompletedTask;
    }
}
