using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager_oops : MonoBehaviour
{
    [SerializeField] private UI_Panel[] panels;
    [SerializeField] private int panelSize;

    void Start()
    {
        panels = gameObject.GetComponentsInChildren<UI_Panel>();
        panelSize = panels[0].slots.Length;
        RandomizePanels();
    }

    void RandomizePanels()
    {
        for( int i = 0; i < panelSize; i++ )
        {
            int randNum = Random.Range( 0, 8 );

            foreach( UI_Panel pnl in panels )
            {
                pnl.slots[i].SetItem( randNum );
            }
        }
    }
}
