using UnityEngine;

class InvisibleDropBehavior : IDropBehavior
{

    private ObjectRenderer objectRenderer;
    private Rigidbody rigidbody;
    public void ExecuteDrop(GameObject gameObject)
    {
        SetVisible(gameObject);
        Drop(gameObject);
    }

    private void SetVisible(GameObject gameObject)
    {
        objectRenderer = gameObject.GetComponent<ObjectRenderer>();

        if (objectRenderer == null)
        {
            objectRenderer = gameObject.AddComponent<ObjectRenderer>();
        }

        if (objectRenderer != null)
        {
            objectRenderer.Show();
        }
        else
        {
            Debug.LogWarning("ObjectRenderer not found on the GameObject!");
        }
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