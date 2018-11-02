﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class VirtualJoystick : MonoBehaviour,IDragHandler,IPointerUpHandler,IPointerDownHandler {
    private Image bgImg;
    private Image joystickImage;
    private Vector3 inputVector;


    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }
    public virtual void OnPointerUp(PointerEventData ped)
    {
        inputVector = Vector3.zero;
        joystickImage.rectTransform.anchoredPosition = Vector3.zero;
    }
    public virtual void OnDrag(PointerEventData ped)
    {
        if(!LevelManager.startTime){
            LevelManager.startTime=true;
        }
        Vector2 pos;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImg.rectTransform,ped.position,ped.pressEventCamera,out pos))
        {
            pos.x = (pos.x / bgImg.rectTransform.sizeDelta.x);
            pos.y = (pos.y / bgImg.rectTransform.sizeDelta.y);
            inputVector = new Vector3(pos.x*2+1,0,pos.y*2-1);
            inputVector = (inputVector.magnitude > 0.5f) ? inputVector.normalized : inputVector;

            //Debug.Log(pos);

            //Move the stick image
            joystickImage.rectTransform.anchoredPosition = new Vector3(inputVector.x*(bgImg.rectTransform.sizeDelta.x/LevelManager.sensibility),inputVector.z*(bgImg.rectTransform.sizeDelta.y/LevelManager.sensibility));
        }
    }
    public float Horizontal()
    {
        if (inputVector.x != 0)
        {
            return inputVector.x;
        }
        else
        {
            return Input.GetAxis("Horizontal");
        }
    }
    public float Vertical()
    {
        if (inputVector.z != 0)
        {
            return inputVector.z;
        }
        else
        {
            return Input.GetAxis("Vertical");
        }
    }

    // Use this for initialization
    void Start () {
        bgImg = GetComponent<Image>();
        joystickImage = transform.GetChild(0).GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
