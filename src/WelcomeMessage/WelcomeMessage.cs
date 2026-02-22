using PluginManager.Api;
using PluginManager.Api.Capabilities.Implementations.Events.GameEvents;
using PluginManager.Api.Contracts;
using PluginManager.Api.Hooks;

namespace WelcomeMessage;

public class WelcomeMessage : BasePlugin
{
    public override string ModuleName => "WelcomeMessage";
    public override string ModuleVersion => "1.0.0";
    public override string ModuleAuthor => "TouchMe-Inc";
    public override string ModuleDescription => "Show welcome message";

    protected override void OnLoad()
    {
        RegisterEventHandler<PlayerSpawnedInWorldEvent>(OnPlayerSpawnedInWorld, HookMode.Pre);
    }

    private HookResult OnPlayerSpawnedInWorld(PlayerSpawnedInWorldEvent evt)
    {
        switch (evt.RespawnType)
        {
            case RespawnType.NewGame:
                Log.Out("RespawnType.NewGame");
                break;
            case RespawnType.JoinMultiplayer:
                Log.Out("RespawnType.JoinMultiplayer");
                break;
            case RespawnType.EnterMultiplayer:
                Log.Out("RespawnType.EnterMultiplayer");
                break;
            case RespawnType.LoadedGame:
                Log.Out("RespawnType.LoadedGame");
                break;
            case RespawnType.Teleport:
                Log.Out("RespawnType.Teleport");
                break;
            case RespawnType.Died:
                Log.Out("RespawnType.Died");
                break;
            case RespawnType.Unknown:
                Log.Out("RespawnType.Unknown");
                break;
        }

        return HookResult.Continue;
    }
}