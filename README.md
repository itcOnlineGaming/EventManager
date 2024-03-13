# EventManager
Add the package by following [these steps](https://docs.google.com/document/d/1RHa0_EtIBRRZzU_O531dw_4QkyTgdphCu7EBlqlu0xk/edit#heading=h.c178u2kmn6ap)

In order to access the EventManager in your own project, two standard approaches are Singleton and ServiceLocator.

### Singleton
Access the EventManager with 
```
EventManager.Instance 
```
Then subscribe to events with subscribe e.g. your scoreboard might subscribe to the ScoreUpdated event:
```
EventManager.Instance.Subscribe(GameEventType.ScoreUpdated, OnScoreUpdated);
```
And your Game class might be in charge of raising the ScoreUpdated event:
```
EventManager.Instance.RaiseEvent(GameEventType.ScoreUpdated, 10);
```

### ServiceLocator


### Defining GameEvents
GameEvents are strings.  One way to define them is using a static class like this:
```
public static class GameEvent
{
    public static string ScoreUpdated = "ScoreUpdated";
    //add more events here
}
```

