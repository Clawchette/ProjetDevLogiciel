using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class square_speed_hover_mouse : MonoBehaviour
{


    public Image image;
    public Image image2;

    void Start(){
        var tempColor = image.color;
        tempColor.a = 0f;
        image.color = tempColor;
        var tempColor2 = image2.color;
        tempColor2.a = 0f;
        image2.color = tempColor2;
    }
    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            var tempColor = image.color;
            tempColor.a = 1f;
            image.color = tempColor;
            var tempColor2 = image2.color;
            tempColor2.a = 1f;
            image2.color = tempColor2;
        }
        else
        {
            var tempColor2 = image2.color;
            tempColor2.a = 0f;
            image2.color = tempColor2;
            var tempColor = image.color;
            tempColor.a = 0f;
            image.color = tempColor;
        }

    }
}