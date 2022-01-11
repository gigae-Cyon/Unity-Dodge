using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public GameObject Panel;

    public void ClosePanel() {
        Panel.SetActive(false);
    }
}
