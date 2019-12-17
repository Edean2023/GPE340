using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        HealthSystem healthSystem = new HealthSystem(5);

        Debug.Log("health: " + healthSystem.GetHealth());
    }

}
