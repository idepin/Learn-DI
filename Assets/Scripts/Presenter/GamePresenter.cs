using UnityEngine;
using VContainer.Unity;

public class GamePresenter : IStartable, ITickable
{
    readonly TimerService timerService;
    readonly HelloWorldService helloWorldService;
    readonly HelloScreen helloScreen;
    readonly TimerScreen timerScreen;

    public GamePresenter(
        HelloWorldService helloWorldService,
        HelloScreen helloScreen,
        TimerService timerService,
        TimerScreen timerScreen
    )
    {
        this.helloWorldService = helloWorldService;
        this.helloScreen = helloScreen;
        this.timerService = timerService;
        this.timerScreen = timerScreen;
    }

    public void Start()
    {
        timerService.StartTimer();
        helloScreen.HelloButton.onClick.AddListener(() => { helloWorldService.Hello(); });

    }

    public void Tick()
    {
        timerScreen.timerText.SetText(timerService.GetSeconds().ToString());
    }
}
