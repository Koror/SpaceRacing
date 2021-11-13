using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float backwardOffset;
    [SerializeField] private float upOffset;

    private Vector3 tempAngles;

    private void Start()
    {
        tempAngles = transform.eulerAngles;
    }

    private void Update()
    {
        transform.position = target.position;
        tempAngles.y = target.eulerAngles.y;
        transform.eulerAngles = tempAngles;
        transform.position -= transform.forward* backwardOffset;
        transform.position += transform.up * upOffset;
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }

}
