using UnityEngine;
using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope
{
    [SerializeField] HelloScreen helloScreen;
    [SerializeField] TimerScreen timerScreen;
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<GamePresenter>();
        builder.Register<HelloWorldService>(Lifetime.Singleton);
        builder.RegisterComponent(helloScreen);

        builder.Register<TimerService>(Lifetime.Singleton);
        builder.RegisterComponent(timerScreen);

    }
}
