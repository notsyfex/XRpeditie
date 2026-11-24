using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class LightSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Volume LightVolume;
    private InputAction _lightAction;
    void Start()
    {
        LightVolume = GetComponent<Volume>();
        _lightAction = GetComponent<InputAction>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_lightAction.IsPressed())
        {
            DayToNight();
        }
    }


    void DayToNight()
    {
        //Lightvolume.weight eraf halen door 
        LightVolume.weight = 1;
    }
}
