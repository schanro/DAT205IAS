using UnityEngine;

public class MirrorInstantiate : MonoBehaviour
{
    public GameObject prefab;  // Assign in Inspector

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;

            // Convert screen point to world position
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane + 5f));

            // Instantiate object at mouse position
            Instantiate(prefab, worldPos, Quaternion.identity);

            // Determine mirrored X position
            float screenMid = Screen.width / 2f;
            float mirroredX = screenMid - (mousePos.x - screenMid);

            Vector3 mirroredScreenPos = new Vector3(mirroredX, mousePos.y, mousePos.z);
            Vector3 mirroredWorldPos = Camera.main.ScreenToWorldPoint(new Vector3(mirroredScreenPos.x, mirroredScreenPos.y, Camera.main.nearClipPlane + 5f));

            // Instantiate mirrored object
            Instantiate(prefab, mirroredWorldPos, Quaternion.identity);
        }
    }
}
