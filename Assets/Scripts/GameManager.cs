using System.Collections;
using System.Collections.Generic;
using Mono.Cecil.Cil;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    void Update()
    {
        // Check if the spacebar was pressed down this frame
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space pressed");
            EventManager.Instance.RaiseEvent(GameEvent.ScoreUpdated, 100);
        }
    }
}
