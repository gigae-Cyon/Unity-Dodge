using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenButton : MonoBehaviour
{
    public GameObject panel;
    public Button buttonToDisable;

    public void OpenPanel() {
        panel.SetActive(true);
        if (buttonToDisable != null) {buttonToDisable.enabled = false;}
    }
}
