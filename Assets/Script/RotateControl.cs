using UnityEngine;

public class RotateControl : MonoBehaviour
{
    [SerializeField]
    private float rotAngleY = 1.0f;

    void Update()
    {
        // ƒtƒŒ[ƒ€‚²‚Æ‚É‰ñ“]‚³‚¹‚é
        transform.Rotate(0.0f, rotAngleY, 0.0f);
    }
}
