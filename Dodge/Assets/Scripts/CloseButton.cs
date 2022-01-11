using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseButton : MonoBehaviour
{
    public GameObject panel;
    public Button buttonToEnable;

    public void ClosePanel() {
        panel.SetActive(false);
        if (buttonToEnable != null) {buttonToEnable.enabled = true;}
    }
}
