using UnityEngine;

public class Entity : MonoBehaviour
{
    [Header("Status")]
    public float maxHitPoint;
    public float maxStaggerPoint;
    protected float currentHitPoint;
    protected float currentStaggerPoint;
    public float speed;

    void Start()
    {
        currentHitPoint = maxHitPoint;
        currentStaggerPoint = maxStaggerPoint;
    }
}
