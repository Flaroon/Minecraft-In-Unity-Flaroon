using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public BlockUIData[] Blocks;
    public RawImage[] Slots;
    public TextMeshProUGUI[] BlockCounts;
    [HideInInspector]
    public BlockUIData[] SlotData;

    public int SlotSelected;

    private void Start()
    {
        SlotData = new BlockUIData[8];
    }

    private void Update()
    {
        if (key("1")) {
            SlotSelected = 0;
            Slots[0].rectTransform.localScale = new Vector3(0.240479991f, 0.40079993f, 0.40079993f);
        }
        else if (SlotSelected != 0) {
            Slots[0].rectTransform.localScale = new Vector3(0.200000003f, 0.333333284f, 0.333333284f);
        }

        if (key("2")) {
            SlotSelected = 1;
            Slots[1].rectTransform.localScale = new Vector3(0.240479991f, 0.40079993f, 0.40079993f);
        }
        else if (SlotSelected != 1)
        {
            Slots[1].rectTransform.localScale = new Vector3(0.200000003f, 0.333333284f, 0.333333284f);
        }

        if (key("3")) {
            SlotSelected = 2;
            Slots[2].rectTransform.localScale = new Vector3(0.240479991f, 0.40079993f, 0.40079993f);
        }
        else if (SlotSelected != 2)
        {
            Slots[2].rectTransform.localScale = new Vector3(0.200000003f, 0.333333284f, 0.333333284f);
        }

        if (key("4")) {
            SlotSelected = 3;
            Slots[3].rectTransform.localScale = new Vector3(0.240479991f, 0.40079993f, 0.40079993f);
        }
        else if (SlotSelected != 3)
        {
            Slots[3].rectTransform.localScale = new Vector3(0.200000003f, 0.333333284f, 0.333333284f);
        }

        if (key("5")) {
            SlotSelected = 4;
            Slots[4].rectTransform.localScale = new Vector3(0.240479991f, 0.40079993f, 0.40079993f);
        }
        else if (SlotSelected != 4)
        {
            Slots[4].rectTransform.localScale = new Vector3(0.200000003f, 0.333333284f, 0.333333284f);
        }

        if (key("6")) {
            SlotSelected = 5;
            Slots[5].rectTransform.localScale = new Vector3(0.240479991f, 0.40079993f, 0.40079993f);
        }
        else if (SlotSelected != 5)
        {
            Slots[5].rectTransform.localScale = new Vector3(0.200000003f, 0.333333284f, 0.333333284f);
        }

        if (key("7")) {
            SlotSelected = 6;
            Slots[6].rectTransform.localScale = new Vector3(0.240479991f, 0.40079993f, 0.40079993f);
        }
        else if (SlotSelected != 6)
        {
            Slots[6].rectTransform.localScale = new Vector3(0.200000003f, 0.333333284f, 0.333333284f);
        }

        if (key("8")) {
            SlotSelected = 7;
            Slots[7].rectTransform.localScale = new Vector3(0.240479991f, 0.40079993f, 0.40079993f);
        }
        else if (SlotSelected != 7)
        {
            Slots[7].rectTransform.localScale = new Vector3(0.200000003f, 0.333333284f, 0.333333284f);
        }
    }                 

    bool key(string i) => Input.GetKeyDown(i);

    public int GetBlockFromIndex(int b)
    {
        for (int i = 0; i < Blocks.Length; i++)
        {
            if (Blocks[i].BlockIndex == b)
            {
                return i;
            }
        }


        return 0;
    }
}

[System.Serializable]
public struct BlockUIData
{
    public string BlockName;
    public Texture2D tex;
    public int BlockIndex, Blockcount;
}
