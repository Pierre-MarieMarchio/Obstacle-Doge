using UnityEngine;


public class HitCollision : MonoBehaviour
{
    private ColorChanger colorChanger;
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        colorChanger = new ColorChanger(Color.red);
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter()
    {
        HitOnWall();
    }

    private void HitOnWall()
    {

        ChangeColorIfValid();
        Scorer.TotalHitNumber = 1;
        Debug.Log($"Ouchhh! Watch out! you have hited {Scorer.TotalHitNumber} time an obstacle");
    }

    private void ChangeColorIfValid()
    {
        if (meshRenderer != null)
        {
            colorChanger.ChangeColor(meshRenderer);

        }
        else
        {
            Debug.LogWarning("MeshRenderer not found on this object.");
        }
    }
}
