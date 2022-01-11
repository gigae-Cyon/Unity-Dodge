using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRecordButton : MonoBehaviour
{
    public GameObject recordResetPanel;
    public GameObject howToPanel;

    public void OpenRecordResetPanel() {
        recordResetPanel.SetActive(true);
        howToPanel.SetActive(false);
    }
}
