using UnityEngine;
using System.Collections;

/*
 * Make an object scroll in a direction,
 * looping after travelling a certain distance
 */
public class ScrollingSprite : MonoBehaviour
{
    //How far the object crolls before looping
    [SerializeField]
    private float loopDistance;
    [SerializeField]
    private float speed;
    [SerializeField]
    private Vector3 direction;

    //How far the object has scrolled so far
    private Vector3 displacement;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
        direction.Normalize();
    }

    void Update()
    {
        displacement += direction * speed * Time.deltaTime;

        if(displacement.sqrMagnitude > loopDistance * loopDistance)
        {
            displacement -= direction * loopDistance;
        }

        transform.position = startPos + displacement;
    }
}
