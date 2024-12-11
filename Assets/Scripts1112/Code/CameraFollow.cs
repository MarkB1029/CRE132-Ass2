using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("References")]
    public Transform _playerTransform;
    private bool _IsFacingRight;
    public float _flipYRotationTime = 0.5f;
    private Coroutine _turnCoroutine;

    private void Update()
    {
        transform.position = _playerTransform.transform.position;
    }
    public void CallTurn()
    {
        _turnCoroutine = StartCoroutine(FlipYLerp());
    }
    private IEnumerator FlipYLerp()
    {
        float startRotation = transform.localEulerAngles.y;
        float endRotationAmount = DetermineEndRotation();
        float yRotation = 0f;

        float elapsedTime = 0f;
        while (elapsedTime < _flipYRotationTime)
        {
            elapsedTime += Time.deltaTime;
            yRotation = Mathf.Lerp(startRotation, endRotationAmount, (elapsedTime / _flipYRotationTime));
            transform.rotation = Quaternion.Euler(0f, yRotation, 0f);
            yield return null;
        }
    }
    private float DetermineEndRotation()
    {
        _IsFacingRight = !_IsFacingRight;
        if (_IsFacingRight)
        {
            return 100f;
        }
        else
        {
            return 0f;
        }
    }
}

