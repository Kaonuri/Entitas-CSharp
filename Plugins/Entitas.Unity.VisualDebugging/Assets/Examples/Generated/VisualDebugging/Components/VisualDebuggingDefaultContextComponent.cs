//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebuggingEntity {

    static readonly DefaultContextComponent defaultContextComponent = new DefaultContextComponent();

    public bool isDefaultContext {
        get { return HasComponent(VisualDebuggingComponentsLookup.DefaultContext); }
        set {
            if(value != isDefaultContext) {
                if(value) {
                    AddComponent(VisualDebuggingComponentsLookup.DefaultContext, defaultContextComponent);
                } else {
                    RemoveComponent(VisualDebuggingComponentsLookup.DefaultContext);
                }
            }
        }
    }
}