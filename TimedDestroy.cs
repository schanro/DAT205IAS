using UnityEngine;

public class TimedDestroy : MonoBehaviour
{
    [Tooltip("Base lifetime of the object in seconds.")]
    public float lifetime = 3f;

    [Tooltip("Adds up to this many seconds randomly to the lifetime. Set to 0 for no randomness.")]
    public float additionalLifetime = 0f;

    private float _finalLifetime;

    void Start()
    {
        // Determine final lifetime
        if (additionalLifetime > 0f)
        {
            float randomExtra = Random.Range(0f, additionalLifetime);
            _finalLifetime = lifetime + randomExtra;
        }
        else
        {
            _finalLifetime = lifetime;
        }

        // Destroy this GameObject after the calculated time
        Destroy(gameObject, _finalLifetime);
    }
}
