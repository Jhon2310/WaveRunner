using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChangingObstacle : MonoBehaviour
{
    private float _currentTime;
    private bool isMovingForward = true;
    private float _time = 0.5f;
    private void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = isMovingForward ? _currentTime / _time: 1-_currentTime/_time  ;
        var position = transform.localScale;
        position = Vector3.Lerp(new Vector3(1.5f,1.5f),new Vector3(5,5),progress);
        transform.localScale = position;
        if (_currentTime>=_time)
        {
            _currentTime = 0f;
            isMovingForward = !isMovingForward;
        }
    }
}
