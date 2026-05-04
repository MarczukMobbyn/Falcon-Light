using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 movementVector;


    Vector3 startPosition;
    Vector3 endPosition;
    float movementFactor;

    private void Start()
    {
        startPosition = transform.position;
        endPosition = startPosition + movementVector;
    }

    private void Update()
    {
        movementFactor = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(startPosition, endPosition, movementFactor);
    }
}
