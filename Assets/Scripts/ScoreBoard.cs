using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    private int score = 0;
    private void OnEnable()
    {
        EventManager.Instance.Subscribe(GameEvent.ScoreUpdated, OnScoreUpdated);
    }

    private void OnDisable()
    {
        EventManager.Instance.Unsubscribe(GameEvent.ScoreUpdated, OnScoreUpdated);
    }

    private void OnScoreUpdated(int addedPoints)
    {
        score += addedPoints;
        Debug.Log("Update score to "+ score);
    }
}