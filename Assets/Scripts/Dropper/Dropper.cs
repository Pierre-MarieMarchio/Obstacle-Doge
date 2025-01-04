using UnityEditor.Rendering;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float dropTimer = 0.0f;
    [SerializeField] bool isVisibleDrop = true;

    private float _timeToDrop;
    private bool isDroped = false;
    private IDropBehavior _dropBehavior;


    private void Awake()
    {
        _dropBehavior = isVisibleDrop ? new VisibleDropBehavior() : new InvisibleDropBehavior();
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        ObjectVisibility();
    }

    private void Start()
    {
        _timeToDrop = Time.time + dropTimer;
    }

    private void Update()
    {
        if (Time.time >= _timeToDrop && !isDroped)
        {
            isDroped = true;
            _dropBehavior.ExecuteDrop(gameObject);

        }
    }

    private void ObjectVisibility()
    {
        ObjectRenderer objectRenderer = gameObject.GetComponent<ObjectRenderer>();

        if (objectRenderer == null)
        {
            objectRenderer = gameObject.AddComponent<ObjectRenderer>();
        }

        if (isVisibleDrop)
        {
            objectRenderer.Show();
        }
        else
        {
            objectRenderer.Hide();
        }
    }
}
