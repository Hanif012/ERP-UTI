using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
   private float _startingPost;
   private float _lengthSprite;
   public float ParallaxAmount;
   public Camera MainCam;

   private void Start()
   {
        _startingPost = transform.position.x;
        _lengthSprite = GetComponent<SpriteRenderer>().bounds.size.x;
   }
   private void Update()
   {
        Vector3 position = MainCam.transform.position;
        float temp = position.x*(1-ParallaxAmount);
        float distance = position.x * ParallaxAmount;

        Vector3 NewPos = new Vector3(_startingPost + distance, transform.position.y, transform.position.z);

        transform.position = NewPos;

        if(temp > _startingPost + _lengthSprite / 2)
        {
            _startingPost += _lengthSprite;
        }
        else if(temp < _startingPost - _lengthSprite / 2)
        {
            _startingPost -= _lengthSprite;
        }
   }
}
