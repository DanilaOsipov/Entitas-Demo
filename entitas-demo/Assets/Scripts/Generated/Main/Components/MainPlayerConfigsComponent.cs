//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MainContext {

    public MainEntity playerConfigsEntity { get { return GetGroup(MainMatcher.PlayerConfigs).GetSingleEntity(); } }
    public PlayerConfigs playerConfigs { get { return playerConfigsEntity.playerConfigs; } }
    public bool hasPlayerConfigs { get { return playerConfigsEntity != null; } }

    public MainEntity SetPlayerConfigs(Services.PlayerConfigsLibrary newValue) {
        if (hasPlayerConfigs) {
            throw new Entitas.EntitasException("Could not set PlayerConfigs!\n" + this + " already has an entity with PlayerConfigs!",
                "You should check if the context already has a playerConfigsEntity before setting it or use context.ReplacePlayerConfigs().");
        }
        var entity = CreateEntity();
        entity.AddPlayerConfigs(newValue);
        return entity;
    }

    public void ReplacePlayerConfigs(Services.PlayerConfigsLibrary newValue) {
        var entity = playerConfigsEntity;
        if (entity == null) {
            entity = SetPlayerConfigs(newValue);
        } else {
            entity.ReplacePlayerConfigs(newValue);
        }
    }

    public void RemovePlayerConfigs() {
        playerConfigsEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MainEntity {

    public PlayerConfigs playerConfigs { get { return (PlayerConfigs)GetComponent(MainComponentsLookup.PlayerConfigs); } }
    public bool hasPlayerConfigs { get { return HasComponent(MainComponentsLookup.PlayerConfigs); } }

    public void AddPlayerConfigs(Services.PlayerConfigsLibrary newValue) {
        var index = MainComponentsLookup.PlayerConfigs;
        var component = (PlayerConfigs)CreateComponent(index, typeof(PlayerConfigs));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePlayerConfigs(Services.PlayerConfigsLibrary newValue) {
        var index = MainComponentsLookup.PlayerConfigs;
        var component = (PlayerConfigs)CreateComponent(index, typeof(PlayerConfigs));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePlayerConfigs() {
        RemoveComponent(MainComponentsLookup.PlayerConfigs);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class MainMatcher {

    static Entitas.IMatcher<MainEntity> _matcherPlayerConfigs;

    public static Entitas.IMatcher<MainEntity> PlayerConfigs {
        get {
            if (_matcherPlayerConfigs == null) {
                var matcher = (Entitas.Matcher<MainEntity>)Entitas.Matcher<MainEntity>.AllOf(MainComponentsLookup.PlayerConfigs);
                matcher.componentNames = MainComponentsLookup.componentNames;
                _matcherPlayerConfigs = matcher;
            }

            return _matcherPlayerConfigs;
        }
    }
}