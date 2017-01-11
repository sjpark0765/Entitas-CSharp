//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public class SomeClassComponent : IComponent {

    public SomeClass value;
}

namespace Entitas {

    public partial class XXXEntity {

        public SomeClassComponent someClass { get { return (SomeClassComponent)GetComponent(ComponentIds.SomeClass); } }
        public bool hasSomeClass { get { return HasComponent(ComponentIds.SomeClass); } }

        public void AddSomeClass(SomeClass newValue) {
            var component = CreateComponent<SomeClassComponent>(ComponentIds.SomeClass);
            component.value = newValue;
            AddComponent(ComponentIds.SomeClass, component);
        }

        public void ReplaceSomeClass(SomeClass newValue) {
            var component = CreateComponent<SomeClassComponent>(ComponentIds.SomeClass);
            component.value = newValue;
            ReplaceComponent(ComponentIds.SomeClass, component);
        }

        public void RemoveSomeClass() {
            RemoveComponent(ComponentIds.SomeClass);
        }
    }

    public partial class Matcher {

        static IMatcher _matcherSomeClass;

        public static IMatcher SomeClass {
            get {
                if(_matcherSomeClass == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.SomeClass);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherSomeClass = matcher;
                }

                return _matcherSomeClass;
            }
        }
    }
}

    public partial class SomeContextMatcher {

        static IMatcher _matcherSomeClass;

        public static IMatcher SomeClass {
            get {
                if(_matcherSomeClass == null) {
                    var matcher = (Matcher)Matcher.AllOf(SomeContextComponentIds.SomeClass);
                    matcher.componentNames = SomeContextComponentIds.componentNames;
                    _matcherSomeClass = matcher;
                }

                return _matcherSomeClass;
            }
        }
    }

    public partial class SomeOtherContextMatcher {

        static IMatcher _matcherSomeClass;

        public static IMatcher SomeClass {
            get {
                if(_matcherSomeClass == null) {
                    var matcher = (Matcher)Matcher.AllOf(SomeOtherContextComponentIds.SomeClass);
                    matcher.componentNames = SomeOtherContextComponentIds.componentNames;
                    _matcherSomeClass = matcher;
                }

                return _matcherSomeClass;
            }
        }
    }
