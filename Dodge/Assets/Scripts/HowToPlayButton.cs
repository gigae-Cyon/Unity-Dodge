using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlayButton : MonoBehaviour
{
    public GameObject howToPanel;

    public void OpenHowToPanel() {
        howToPanel.SetActive(true);
    }
}
