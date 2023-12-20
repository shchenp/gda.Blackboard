using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;

    public void SetColor(Color color)
    {
        if (!gameObject.activeSelf)
        {
            gameObject.SetActive(true);
        }
        
        _renderer.color = color;
    }

    public void FollowMouse(Vector3 position)
    {
        transform.localPosition = position;
    }
}
