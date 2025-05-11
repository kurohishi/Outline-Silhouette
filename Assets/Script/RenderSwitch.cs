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

        // １つ下の全ての子オブジェクトを変更する場合
        foreach (Transform child in targetObject.transform)
        {
            GameObject childObject = child.gameObject;
            childObject.layer = layer;

            // 連なる全ての子オブジェクトのレイヤーを変更する場合
            OnRenderSwitch(childObject, layer);
        }
    }
}
