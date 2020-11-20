using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light flashlight = null;

    private void Start()
    {
        flashlight.enabled = false;
    }
    public void OnOff() 
    {
        flashlight.enabled = !flashlight.enabled;
    }
}
