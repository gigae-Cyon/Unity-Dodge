using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRecordButton : MonoBehaviour
{
    public GameObject recordResetPanel;

    public void OpenRecordResetPanel() {
        recordResetPanel.SetActive(true);
    }
}
