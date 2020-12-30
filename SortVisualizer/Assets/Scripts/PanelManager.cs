using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    #region Singleton

    public static PanelManager Instance { get; protected set; }

    void Awake()
    {
        // Make sure this is the only instance of AudioController
        if( Instance != null )
        {
            Debug.LogError( "PanelManager - Another PanelManager already exists." );
            return;
        }

        Instance = this;
    }

    #endregion

    public UI_Panel[] panels;
    [SerializeField] private int panelSize;

    void Start()
    {
        panels = gameObject.GetComponentsInChildren<UI_Panel>();
        //panelSize = panels[0].slots.Length;
        panelSize = 100;
        //RandomizePanels();
    }

    void Update()
    {

    }

    public void RandomizePanels()
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
