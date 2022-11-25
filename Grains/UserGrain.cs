using Orleans;
using Orleans.Runtime;

namespace Grains;

public interface IUserGrain : IGrainWithStringKey
{
    Task SetName(string name);
}

public class UserInfo
{
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

}


//[StorageProvider(ProviderName = "customstore")]
public class UserGrain : Grain, IUserGrain
{
    private IPersistentState<UserInfo> State;

    public UserGrain([PersistentState("userinfo", "customstore")] IPersistentState<UserInfo> state)
    {
        State = state;
    }

    public async Task SetName(string name)
    {
        State.State.FirstName = name;
        await State.WriteStateAsync();
    }

}