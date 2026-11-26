using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonInputManager : MonoBehaviour
{
    private ButtonUI ButtonRefrence;
    private PlayerInput PlayerInput;

    private InputAction RedButtonInput;
    private InputAction BlueButtonInput;
    private InputAction YellowButtonInput;
    private InputAction GreenButtonInput;

    public float ButtonInputDelay = 1f;
    public float CurrentButtonDelay = 0f;


    private void Start()
    {
        ButtonRefrence = GetComponent<ButtonUI>();
        PlayerInput = GetComponent<PlayerInput>();
        RedButtonInput = PlayerInput.actions.FindAction("RedButton");
        BlueButtonInput = PlayerInput.actions.FindAction("BlueButton");
        YellowButtonInput = PlayerInput.actions.FindAction("YellowButton");
        GreenButtonInput = PlayerInput.actions.FindAction("GreenButton");
    }
    void Update()
    {
        if (CurrentButtonDelay >= 0)
        {
            CurrentButtonDelay -= Time.deltaTime;  
        }

        //input

        if (RedButtonInput.IsPressed())
        {
            PressRedButton();
        }
        if(BlueButtonInput.IsPressed())
        {
            PressBlueButton();
        }
        if(YellowButtonInput.IsPressed())
        {
            PressYellowButton();
        }
        if(GreenButtonInput.IsPressed())
        {
            PressGreenButton();
        }
    }

    public void PressRedButton()
    {
        if (CurrentButtonDelay < 0)
        {
          ButtonRefrence.RedButton();
            CurrentButtonDelay = ButtonInputDelay;
        }
    }
    public void PressBlueButton()
    {
        if (CurrentButtonDelay < 0)
        {
            ButtonRefrence.BlueButton();
            CurrentButtonDelay = ButtonInputDelay;
        }
    }
    public void PressYellowButton()
    {
        if (CurrentButtonDelay < 0)
        {
            ButtonRefrence.YellowButton();
            CurrentButtonDelay = ButtonInputDelay;
        }
    }
    public void PressGreenButton()
    {
        if (CurrentButtonDelay < 0)
        {
            ButtonRefrence.GreenButton();
            CurrentButtonDelay = ButtonInputDelay;
        }
    }
}
