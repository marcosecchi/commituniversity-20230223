using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletController : MonoBehaviour
{
    [Range(2, 50)]
    public float velocityMultiplier = 2.0f;

    [Range(1, 10)]
    public float angularVelocityMultiplier = 5.0f;

    private void Start()
    {
        var rb = GetComponent<Rigidbody>();
        var forwardDirection = transform.forward;
        rb.velocity = forwardDirection * velocityMultiplier;
        rb.angularVelocity = forwardDirection * angularVelocityMultiplier;
    }
}
