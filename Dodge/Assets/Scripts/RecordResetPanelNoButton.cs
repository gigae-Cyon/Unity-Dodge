using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordResetPanelNoButton : MonoBehaviour
{
    public GameObject recordResetPanel;
    
    public void CloseRecordResetPanel() {
        recordResetPanel.SetActive(false);
    }
}
