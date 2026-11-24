using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    enum UiState
    {
        StartMenu,
        Default,
        RedMenu,
        BlueSubMenu,
        YellowSubMenu,
        GreenSubMenu,
    }
    
    private UiState _currentState = UiState.StartMenu;
    public AnimationManager StartAnimation;

    public void RedButton()
    {
       if(_currentState == UiState.Default)
        {
            _currentState = UiState.RedMenu;
        }
        else
        {
            _currentState = UiState.Default;
        }
        // activates start animation if pressed
        if (_currentState == UiState.StartMenu)
        {
            _currentState = UiState.Default;
            StartAnimation.IsStartActivated = true;
        }
        Debug.Log(_currentState);
    }
    public void BlueButton()
    {
        //toggles blue on/off
        if(_currentState == UiState.RedMenu)
        {
            _currentState = UiState.BlueSubMenu;
        }
        else if( _currentState == UiState.BlueSubMenu)
        {
            _currentState = UiState.RedMenu;
        }
        // activates start animation if pressed
        if (_currentState == UiState.StartMenu)
        {
            _currentState = UiState.Default;
            StartAnimation.IsStartActivated = true;
        }
        Debug.Log(_currentState);
    }
    public void YellowButton()
    {
        //toggles yellow on/off
        if (_currentState == UiState.RedMenu)
        {
            _currentState = UiState.YellowSubMenu;
        }
        else if (_currentState == UiState.YellowSubMenu)
        {
            _currentState = UiState.RedMenu;
        }
        // activates start animation if pressed
        if (_currentState == UiState.StartMenu)
        {
            _currentState = UiState.Default;
            StartAnimation.IsStartActivated = true;
        }
        Debug.Log(_currentState);
    }
    public void GreenButton()
    {
        //toggles green on/off
        if (_currentState == UiState.RedMenu)
        {
            _currentState = UiState.GreenSubMenu;
        }
        else if (_currentState == UiState.GreenSubMenu)
        {
            _currentState = UiState.RedMenu;
        }
        // activates start animation if pressed
        if (_currentState == UiState.StartMenu)
        {
            _currentState = UiState.Default;
            StartAnimation.IsStartActivated = true;
        }
        Debug.Log(_currentState);
    }
    private void Update()
    {
        
    }
}
