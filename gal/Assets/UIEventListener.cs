﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class UIEventListener : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{

    /// <summary>
    /// 定义事件代理
    /// </summary>
    /// <param name="gb"></param>
    public delegate void UIEventProxy(GameObject gb);

    /// <summary>
    /// 鼠标点击事件
    /// </summary>
    public event UIEventProxy OnClick;

    /// <summary>
    /// 鼠标进入事件
    /// </summary>
    public event UIEventProxy OnMouseEnter;

    public event UIEventProxy OnMouseDown;
    /// <summary>
    /// 鼠标滑出事件
    /// </summary>
    public event UIEventProxy OnMouseExit;
    public void OnPointerDown(PointerEventData eventData)
    {
        if (OnMouseDown != null)
            OnMouseDown(this.gameObject);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (OnClick != null)
            OnClick(this.gameObject);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (OnMouseEnter != null)
            OnMouseEnter(this.gameObject);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (OnMouseExit != null)
            OnMouseExit(this.gameObject);
    }
}