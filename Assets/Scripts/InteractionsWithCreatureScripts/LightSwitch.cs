using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class LightSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Volume LightVolume;
    public InputActionReference LightAction;

    private bool _isNight;
    private float _targetWeight;

    [SerializeField] private float _transitionSpeed = 2f;

    void Start()
    {
        _targetWeight = 0f; //Sets the target weight to zero, it will look for the smalest weight then count down.
        _isNight = false;
    }

    private void OnEnable()
    {
        LightAction.action.Enable();
    }

    private void OnDisable()
    {
        LightAction.action.Disable();
    }

    // Update is called once per frame
    private void Update()
    {
        if (LightAction.action.WasPressedThisFrame())
        {
            DayToNight();
        }

        // Smooth transition
        LightVolume.weight = Mathf.MoveTowards(
            LightVolume.weight,
            _targetWeight, //look for where the darkness needs to go
            _transitionSpeed * Time.deltaTime //speed of how fast it becomes lighter or darker
        );
    }
    void DayToNight()
    {
            _isNight = !_isNight;

            if (_isNight)
            {
                _targetWeight = 1;
                Debug.Log("nighty night");
            }
            else
            {

                _targetWeight = 0;
                Debug.Log("morning");
            }
    }
}
