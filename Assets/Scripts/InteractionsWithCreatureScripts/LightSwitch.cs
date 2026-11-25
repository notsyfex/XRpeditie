using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class LightSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Volume LightVolume;
    public InputActionReference _lightAction;
    void Start()
    {
        //LightVolume = GetComponent<Volume>();
        //_lightAction = GetComponent<InputAction>();
    }

    private void OnEnable()
    {
        _lightAction.action.Enable();
    }

    private void OnDisable()
    {
        _lightAction.action.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (_lightAction.action.WasPressedThisFrame())
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
