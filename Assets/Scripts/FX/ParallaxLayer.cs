using Lean.Transition.Method;
using UnityEngine;

public class ParallaxLayer : MonoBehaviour
{
    public float scrollSpeed = -1000000f;
    private float spriteWidth;
    private Vector3 startPosition;

    private void Start()
    {
        spriteWidth = GetComponentInChildren<SpriteRenderer>().bounds.size.x;
        startPosition = transform.position;
    }

    private void FixedUpdate()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, spriteWidth);
        transform.position = startPosition + Vector3.left * newPosition;
    }
        //unused sin wave
        // float time = Time.time;
        // float offset = Mathf.Sin(time * scrollSpeed);
        // float newPosition = offset * spriteWidth;
        // transform.position = startPosition + Vector3.left * newPosition;
}