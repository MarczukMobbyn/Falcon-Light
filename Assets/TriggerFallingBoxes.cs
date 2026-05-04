using UnityEngine;

public class TriggerFallingBoxes : MonoBehaviour
{
    [SerializeField] private GameObject[] fallingBoxes;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player hit the collider");
            foreach (GameObject box in fallingBoxes)
            {
                box.gameObject.SetActive(true);
            }
        }
    }
}
