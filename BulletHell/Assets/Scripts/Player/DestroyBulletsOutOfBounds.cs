using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    void Update()
    {
        if (!IsVisible())
        {
            Destroy(gameObject);
        }
    }

    bool IsVisible()
    {
        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(transform.position);
        return viewportPosition.x > 0 && viewportPosition.x < 1 && viewportPosition.y > 0 && viewportPosition.y < 1;
    }
}
