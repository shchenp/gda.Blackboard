using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Marker : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Line _linePrefab;
    [SerializeField] private UnityEvent<Line> _onLineAwake;

    private Line _currentLine;

    public void SetColor(Color color)
    {
        if (!gameObject.activeSelf)
        {
            gameObject.SetActive(true);
        }
        
        _renderer.color = color;
    }

    public void DrawNewLine()
    {
        if (!gameObject.activeSelf)
        {
            return;
        }
        
        _currentLine = Instantiate(_linePrefab, transform);
        _currentLine.SetColor(_renderer.color);
        _onLineAwake.Invoke(_currentLine);
    }

    public void Draw()
    {
        if (!gameObject.activeSelf)
        {
            return;
        }
        
        _currentLine.SetNewPoint(transform.localPosition);
    }

    public void FollowMouse(Vector3 position)
    {
        transform.localPosition = position;
    }
}
