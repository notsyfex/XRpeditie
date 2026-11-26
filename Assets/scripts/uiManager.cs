using Unity.VisualScripting;
using UnityEngine;

public class uiManager : MonoBehaviour
{
    public ButtonUI buttonUI;
    public GameObject RedMenu;
    public GameObject BlueSubMenu;
    public GameObject YellowSubMenu;
    public GameObject GreenSubMenu;

    void Update()
    {
        if (buttonUI.CurrentState == ButtonUI.UiState.RedMenu)
        {
            RedMenu.SetActive(true);
        }
        else
        {
            RedMenu.SetActive(false);
        }

        if (buttonUI.CurrentState == ButtonUI.UiState.BlueSubMenu)
        {
            BlueSubMenu.SetActive(true);
        }
        else
        {
            BlueSubMenu.SetActive(false);
        }

        if (buttonUI.CurrentState == ButtonUI.UiState.YellowSubMenu)
        {
            YellowSubMenu.SetActive(true);
        }
        else
        {
            YellowSubMenu.SetActive(false);
        }

        if (buttonUI.CurrentState == ButtonUI.UiState.GreenSubMenu)
        {
            GreenSubMenu.SetActive(true);
        }
        else
        {
            GreenSubMenu.SetActive(false);
        }
    }
}
