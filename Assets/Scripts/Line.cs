using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Line : MonoBehaviour
{
    [SerializeField] private LineRenderer _renderer;

    private float _depth;

    public void SetColor(Color color)
    {
        _renderer.startColor = color;
        _renderer.endColor = color;
    }
    
    public void SetNewPoint(Vector3 position)
    {
        _renderer.positionCount++;

        position.z = _depth;
        var currentPosition = _renderer.positionCount - 1;
        _renderer.SetPosition(currentPosition, position);
    }
}
