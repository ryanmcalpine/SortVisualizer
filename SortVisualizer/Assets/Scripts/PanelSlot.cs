using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSlot : MonoBehaviour
{
    //public int index;
    private Image bg;
    private Text itemNumTxt;
    private int itemNum = -1;
    public int ItemNum
    {
        get
        {
            return itemNum;
        }
    }

    void Start()
    {
        bg = gameObject.GetComponent<Image>();
        itemNumTxt = gameObject.transform.GetChild( 0 ).GetComponent<Text>();
    }

    public void SetItem( int num )
    {
        itemNum = num;
        itemNumTxt.text = num.ToString();

        switch( num )
        {
            case 0:
                bg.color = new Color32( 148, 0, 211, 100 ) ;
                break;
            case 1:
                bg.color = new Color32( 75, 0, 130, 100 );
                break;
            case 2:
                bg.color = new Color32( 0, 0, 255, 100 );
                break;
            case 3:
                bg.color = new Color32( 0, 255, 255, 100 );
                break;
            case 4:
                bg.color = new Color32( 0, 255, 0, 100 );
                break;
            case 5:
                bg.color = new Color32( 255, 255, 0, 100 );
                break;
            case 6:
                bg.color = new Color32( 255, 127, 0, 100 );
                break;
            case 7:
                bg.color = new Color32( 255, 0, 0, 100 );
                break;
        }
    }
}
