using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private EventMaster EM;

    private void Awake()
    {
        EM = GetComponent<EventMaster>();
    }

    private void ShowConsoleMessages(char c) 
    {
        Debug.Log(c.ToString());
    }

    private void OnEnable()
    {
        EM.KeyPress += ShowConsoleMessages;
    }

    private void OnDisable()
    {
        EM.KeyPress += ShowConsoleMessages;
    }
}

}
