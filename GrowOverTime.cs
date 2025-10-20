using UnityEngine;

public class GrowOverTime : MonoBehaviour
{
    [Tooltip("How fast the object grows per second.")]
    public float growthSpeed = 0.5f;

    [Tooltip("Optional maximum scale. Set to 0 for no limit.")]
    public float maxScale = 0f;

    void Update()
    {
        // Calculate growth amount for this frame
        Vector3 growth = Vector3.one * growthSpeed * Time.deltaTime;

        // Apply growth
        transform.localScale += growth;

        // Optional cap
        if (maxScale > 0f && transform.localScale.x >= maxScale)
        {
            transform.localScale = new Vector3(maxScale, maxScale, maxScale);
        }
    }
}
