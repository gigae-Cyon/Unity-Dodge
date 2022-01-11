using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordResetPanelYesButton : MonoBehaviour
{
    public GameObject recordResetPanel;
    public GameObject recordResetConfirmPanel;

    public void ResetRecord() {
        PlayerPrefs.DeleteAll();
        recordResetPanel.SetActive(false);
        recordResetConfirmPanel.SetActive(true);
    }
}
