using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPanelCloseButton : MonoBehaviour
{
    public GameObject howToPanel;

    public void CloseHowToPanel() {
        howToPanel.SetActive(false);
    }
}
