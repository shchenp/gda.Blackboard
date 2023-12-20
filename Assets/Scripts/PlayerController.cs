using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Marker _marker;
    
    private Camera _camera;
    private float _depth = -9;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        SetMarkerMousePosition();
    }

    public void SetMarkerColor(Image image)
    {
        var color = image.color;
        _marker.SetColor(color);
    }

    private void SetMarkerMousePosition()
    {
        var mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _depth);
        var point = _camera.ScreenToWorldPoint(mousePosition);
        
        _marker.FollowMouse(point);
    }
}
