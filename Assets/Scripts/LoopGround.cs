using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _width = 6f;

    private SpriteRenderer spriteRenderer;

    private Vector2 _startSize;

  private  void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        _startSize = new Vector2(spriteRenderer.size.x, spriteRenderer.size.y);
    }

   private void Update()
    {
        spriteRenderer.size = new Vector2(spriteRenderer.size.x + _speed * Time.deltaTime, spriteRenderer.size.y);
        if (spriteRenderer.size.x > _width )
        {
            spriteRenderer.size = _startSize;
        }
    }
}
