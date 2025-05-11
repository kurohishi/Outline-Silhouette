using UnityEngine;
public class RenderSwitch : MonoBehaviour
{
    [SerializeField] private int num = 0;
    private void Start()
    {
        num = gameObject.layer;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(gameObject.layer == num) OnRenderSwitch(gameObject,0);
            else OnRenderSwitch(gameObject, num);
        }
    }
    private void OnRenderSwitch(GameObject targetObject, int layer)
    {
        targetObject.layer = layer;

        // �P���̑S�Ă̎q�I�u�W�F�N�g��ύX����ꍇ
        foreach (Transform child in targetObject.transform)
        {
            GameObject childObject = child.gameObject;
            childObject.layer = layer;

            // �A�Ȃ�S�Ă̎q�I�u�W�F�N�g�̃��C���[��ύX����ꍇ
            OnRenderSwitch(childObject, layer);
        }
    }
}
