//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public SomeOtherClassComponent someOtherClass { get { return (SomeOtherClassComponent)GetComponent(GameComponentsLookup.SomeOtherClass); } }
    public bool hasSomeOtherClass { get { return HasComponent(GameComponentsLookup.SomeOtherClass); } }

    public void AddSomeOtherClass(SomeNamespace.SomeOtherClass newValue) {
        var index = GameComponentsLookup.SomeOtherClass;
        var component = CreateComponent<SomeOtherClassComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSomeOtherClass(SomeNamespace.SomeOtherClass newValue) {
        var index = GameComponentsLookup.SomeOtherClass;
        var component = CreateComponent<SomeOtherClassComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSomeOtherClass() {
        RemoveComponent(GameComponentsLookup.SomeOtherClass);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSomeOtherClass;

    public static Entitas.IMatcher<GameEntity> SomeOtherClass {
        get {
            if(_matcherSomeOtherClass == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SomeOtherClass);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSomeOtherClass = matcher;
            }

            return _matcherSomeOtherClass;
        }
    }
}