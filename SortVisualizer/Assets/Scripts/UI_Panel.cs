using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Panel : MonoBehaviour
{
    public PanelSlot[] slots;

    void Start()
    {
        slots = gameObject.GetComponentsInChildren<PanelSlot>();
    }
}
