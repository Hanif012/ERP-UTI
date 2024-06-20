using UnityEngine;

public class WaveMovement : MonoBehaviour
{
    public float speed = 2.0f; // Speed of the wave movement
    public float waveWidth = 10.0f; // Width of the wave (how far it moves before looping)
    private Vector3 startPosition;

    private float _lengthSprite;
    
    void Start()
    {
        startPosition = transform.position;
        _lengthSprite = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * speed, _lengthSprite);
        transform.position = startPosition + Vector3.left * newPosition;
    }
}
