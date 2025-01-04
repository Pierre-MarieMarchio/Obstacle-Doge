using UnityEngine;

public class VisibleDropBehavior : IDropBehavior
{
    private Rigidbody rigidbody;
    public void ExecuteDrop(GameObject gameObject)
    {
        Drop(gameObject);
    }

    private void Drop(GameObject gameObject)
    {
        if (rigidbody == null)
        {
            rigidbody = gameObject.GetComponent<Rigidbody>();
        }

        if (rigidbody)
        {
            rigidbody.useGravity = true;
        }
        else
        {
            Debug.LogWarning("No Rigidbody found on the object.");
        }
    }
}