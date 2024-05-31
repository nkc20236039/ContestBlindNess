using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using VContainer;
using VContainer.Unity;

public class DISetting : LifetimeScope
{
    [SerializeField]
    private KeyConfigPresenter keyConfigPresenter;
    [SerializeField]
    private InputActionAsset actions;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterComponent(actions);
        builder.RegisterComponent(keyConfigPresenter)
            .As<IOutPutAction>();
        builder.Register<DatabaseAccess>(Lifetime.Singleton)
            .As<IKeyConfigRepository>();
        builder.Register<KeyConfigApplicationService>(Lifetime.Singleton)
            .As<IInputAction>();
        builder.Register<KeyConfigRebindService>(Lifetime.Singleton);
        builder.Register<KeyConfigConflictService>(Lifetime.Singleton);
        builder.Register<KeyConfigCancelService>(Lifetime.Singleton);
        builder.Register<KeyConfigSaveService>(Lifetime.Singleton);
        builder.Register<KeyConfigSetupService>(Lifetime.Singleton);
        builder.Register<KeyConfigDefaultService>(Lifetime.Singleton);
        builder.Register<KeyConfigDisableService>(Lifetime.Singleton);
    }
}
