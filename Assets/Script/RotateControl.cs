using UnityEngine;

public class RotateControl : MonoBehaviour
{
    [SerializeField]
    private float rotAngleY = 1.0f;

    void Update()
    {
        // フレームごとに回転させる
        transform.Rotate(0.0f, rotAngleY, 0.0f);
    }
}
