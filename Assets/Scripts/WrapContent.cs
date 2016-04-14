using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WrapContent : MonoBehaviour
{
    public GameObject wrapGO;
    UIWrapContent wrapContent;
    List<int> numbers;


    // Use this for initialization
    void Awake()
    {
        numbers = new List<int>();
        for(int i = 0; i<30; i++){
            numbers.Add(i);
        }
        wrapContent = wrapGO.GetComponent<UIWrapContent>();
        InitWrapContent();
    }

    private void InitWrapContent() {
        wrapContent.onInitializeItem = OnUpdateItem;
        wrapContent.minIndex = -(numbers.Count - 1);
        wrapContent.maxIndex = 0;
    }

    private void OnUpdateItem(GameObject go, int index, int realIndex)
    {
        go.GetComponent<UILabel>().text = numbers[System.Math.Abs(realIndex)].ToString();
    }
}

