using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.LookAt;

public class LookatController : MonoBehaviour, ICubismLookTarget
{
    public Vector3 GetPosition()
    {
        if (!Input.GetMouseButton(0))
        {
            return Vector3.zero;
        }

        var targetPosition = Input.mousePosition;
        targetPosition = (Camera.main.ScreenToViewportPoint(targetPosition) * 2) - Vector3.one;
        Debug.Log("Look at "+ targetPosition);
        return targetPosition;

        throw new System.NotImplementedException();
    }

    public bool IsActive()
    {
        return true;

        throw new System.NotImplementedException();

    }
}
