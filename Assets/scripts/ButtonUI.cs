using UnityEngine;

public class ButtonUI : MonoBehaviour
{
     public enum UiState
    {
        StartMenu,
        Default,
        RedMenu,
        BlueSubMenu,
        YellowSubMenu,
        GreenSubMenu,
    }
    
    private UiState _currentState = UiState.StartMenu;
    public UiState CurrentState => _currentState;
    public AnimationManager StartAnimation;

    public void RedButton()
    {
        // activates start animation if pressed
        if (_currentState == UiState.StartMenu)
        {
            _currentState = UiState.Default;
            StartAnimation.IsStartActivated = true;
        }
        //redmenu toggle
        if (_currentState == UiState.Default)
        {
            _currentState = UiState.RedMenu;
        }
        else
        {
            _currentState = UiState.Default;
        }
        Debug.Log(_currentState);
    }
    public void BlueButton()
    {
        // activates start animation if pressed
        if (_currentState == UiState.StartMenu)
        {
            _currentState = UiState.Default;
            StartAnimation.IsStartActivated = true;
        }
        //toggles blue on/off
        if (_currentState == UiState.RedMenu)
        {
            _currentState = UiState.BlueSubMenu;
        }
        else if( _currentState == UiState.BlueSubMenu)
        {
            _currentState = UiState.RedMenu;
        }
        Debug.Log(_currentState);
    }
    public void YellowButton()
    {
        // activates start animation if pressed
        if (_currentState == UiState.StartMenu)
        {
            _currentState = UiState.Default;
            StartAnimation.IsStartActivated = true;
        }
        //toggles yellow on/off
        if (_currentState == UiState.RedMenu)
        {
            _currentState = UiState.YellowSubMenu;
        }
        else if (_currentState == UiState.YellowSubMenu)
        {
            _currentState = UiState.RedMenu;
        }
        Debug.Log(_currentState);
    }
    public void GreenButton()
    {
        // activates start animation if pressed
        if (_currentState == UiState.StartMenu)
        {
            _currentState = UiState.Default;
            StartAnimation.IsStartActivated = true;
        }
        //toggles green on/off
        if (_currentState == UiState.RedMenu)
        {
            _currentState = UiState.GreenSubMenu;
        }
        else if (_currentState == UiState.GreenSubMenu)
        {
            _currentState = UiState.RedMenu;
        }
        Debug.Log(_currentState);
    }
    private void Update()
    {
        
    }
}
