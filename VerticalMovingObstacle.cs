using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovingObstacle : MonoBehaviour
{
    private float _currentTime;
    private bool isMovingForward = true;
    private float _time = 2f;

    private void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = isMovingForward ? _currentTime / _time: 1-_currentTime/_time  ;
        var position = transform.position;
        position = Vector3.Lerp(new Vector3(position.x,position.y-0.15f),new Vector3(position.x,position.y+0.15f),progress);
        transform.position = position;
        if (_currentTime>=_time)
        {
            _currentTime = 0f;
            isMovingForward = !isMovingForward;
        }
    }
}
