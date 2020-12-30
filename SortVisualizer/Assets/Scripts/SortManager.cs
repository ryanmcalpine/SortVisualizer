using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortManager : MonoBehaviour
{
    //private bool isSorting = false;
    [SerializeField] private float delayTime = 0.05f;

    // Update is called once per frame
    void Update()
    {

    }

    public void StartSort()
    {
        StartCoroutine( BubbleSort( PanelManager.Instance.panels[0].slots ) );
        StartCoroutine( InsertionSort( PanelManager.Instance.panels[1].slots ) );
        StartCoroutine( SelectionSort( PanelManager.Instance.panels[2].slots ) );
    }

    IEnumerator BubbleSort( PanelSlot[] slots )
    {
        int i, j;
        int n = slots.Length;

        for( j = n - 1; j > 0; j-- )
        {
            for( i = 0; i < j; i++ )
            {
                yield return new WaitForSeconds( delayTime );

                if( slots[i].ItemNum > slots[i + 1].ItemNum )
                {
                    int tmp = slots[i].ItemNum;
                    slots[i].SetItem( slots[i + 1].ItemNum );
                    slots[i + 1].SetItem( tmp );
                }
            }
        }
    }

    IEnumerator SelectionSort( PanelSlot[] slots )
    {
        int i;
        int n = slots.Length;

        for( i = 0; i < n - 1; i++ )
        {
            yield return new WaitForSeconds( delayTime );

            int k = SSFindMin( slots, i );
            //Debug.Log( "i:" + i + ", k: " + k );
            if( i != k )
            {
                //Debug.Log( "Exchanging slots " + i + " and " + k );
                int tmp = slots[i].ItemNum;
                slots[i].SetItem( slots[k].ItemNum );
                slots[k].SetItem( tmp );
            }
        }
    }
    int SSFindMin( PanelSlot[] slots, int start )
    {
        //Debug.Log( "SS - Finding min" );
        int minPos = start;
        for( int pos = start + 1; pos < slots.Length; pos++ )
        {
            if( slots[pos].ItemNum < slots [minPos].ItemNum )
            {
                //Debug.Log( "SS - new minPos: " + pos );
                minPos = pos;
            }
        }
        //Debug.Log( "SS - Returning minPos " + minPos );
        return minPos;
    }

    /*
    IEnumrator QuickSort( PanelSlot[] slots )
    {
        int i, j;
        int p;  // pivot
    }
    */

    IEnumerator InsertionSort( PanelSlot[] slots )
    {
        int i, j;
        int n = slots.Length;

        for( j = 1; j < n; j++ )
        {
            yield return new WaitForSeconds( delayTime );

            for( i=j; i > 0 && slots[i].ItemNum < slots[i-1].ItemNum; i-- )
            {
                int tmp = slots[i].ItemNum;
                slots[i].SetItem( slots[i - 1].ItemNum );
                slots[i - 1].SetItem( tmp );
            }
        }
    }

    /*
    IEnumerator ShellSort( PanelSlot[] slots )
    {

    }
    */
}
