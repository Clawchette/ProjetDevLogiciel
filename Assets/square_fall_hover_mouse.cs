using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class square_fall_hover_mouse : MonoBehaviour

{
    public Image image3;
    public Image image4;

    void Start(){
        var tempColor3 = image3.color;
        tempColor3.a = 0f;
        image3.color = tempColor3;
        var tempColor4 = image4.color;
        tempColor4.a = 0f;
        image4.color = tempColor4;
    }
    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            var tempColor3 = image3.color;
            tempColor3.a = 1f;
            image3.color = tempColor3;
            var tempColor4 = image4.color;
            tempColor4.a = 1f;
            image4.color = tempColor4;
        }
        else
        {
            var tempColor4 = image4.color;
            tempColor4.a = 0f;
            image4.color = tempColor4;
            var tempColor3 = image3.color;
            tempColor3.a = 0f;
            image3.color = tempColor3;
        }

    }
}