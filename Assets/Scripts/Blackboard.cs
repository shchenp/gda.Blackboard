using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Blackboard : MonoBehaviour
{
    private List<Line> _lines = new();

    public void AddLine(Line line)
    {
        _lines.Add(line);
    }

    public void Clear()
    {
        foreach (var line in _lines)
        {
            Destroy(line.gameObject);
        }

        _lines = new List<Line>();
    }
}
