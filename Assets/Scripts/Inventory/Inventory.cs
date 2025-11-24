using UnityEngine;
using System.Collections.Generic;
using UnityEditor.Search;
using Unity.VisualScripting;

public class Inventory : MonoBehaviour
{
    Transform worldItemstransform;

    [Header("Game Manager")]
    [SerializeField] private GameManager gameManager;

    [Header("Inventory")]
    [SerializeField] private List<ItemObject> items = new List<ItemObject>();
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();

        Transform worldItemsTransform = GameObject.Find("WorldItems").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
           SortInventory();
        }
    }

    public void AddItemToInventory (ItemObject item)
    { 
        items.Add(item); 
    }

    public void RemoveItemFromInventory ()
    {  
        if (gameManager.currentState.GetType() == typeof(PlayState) && items.Count > 0)
        {

            ItemObject item = items[0];

            Vector3 currentPosition = transform.position;
            Vector3 forward = transform.forward;

            Vector3 newPosition = currentPosition + forward;
            newPosition += new Vector3(0, 1, 0);

            Quaternion currentRotation = transform.rotation;
            Quaternion newRotation = currentRotation * Quaternion.Euler(0, 0, 180);

            GameObject newItem = Instantiate(item.gameObject, newPosition, newRotation, worldItemstransform);
            newItem.SetActive(true);

            items.Remove(item);
            Destroy(item.gameObject);

        }
      
    }

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        ItemObject collisionItem = hit.gameObject.GetComponent<ItemObject>();

        if (collisionItem != null)
        {
            items.Add(collisionItem);
            
            collisionItem.gameObject.SetActive(false);
        }

    }

    public void SortInventory()
    {

      items.Sort();

    }

}
