using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// This code is going to have a reference to the UI so it can display the item
public class InventoryHandler : MonoBehaviour
{
    private const int INVENTORYSPACE = 4;

    [SerializeField]
    public Item currentItem;
    public Image itemImage;
    public Item[] inventory = new Item[INVENTORYSPACE];

    bool canPickUp = false;
    public GameObject groundItem;

    private int inventoryIndex = 0;

    public PlayerMovement playMove;

    public void Awake()
    {
        playMove = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        PlayerInput();
    }

    public void PlayerInput()
    {
        // swapping item
        //probably better way but idk yet, get it to work first
        if (Input.GetKeyDown(KeyCode.Alpha1)) { SwapItem(inventory[0], 0); }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { SwapItem(inventory[1], 1); }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { SwapItem(inventory[2], 2); }           
        if (Input.GetKeyDown(KeyCode.Alpha4)) { SwapItem(inventory[3], 3); }

        if (canPickUp && Input.GetKeyDown(KeyCode.E))
        {
            PickUpItem();
        }
           
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Item")
        {
            canPickUp = true;
            groundItem = collision.gameObject;
            Debug.Log("We can pick up this item!");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        canPickUp = false;
        groundItem = null;
    }


    public void DisplayItem()
    {
        SoundManager.PlaySound(SoundType.SWITCHITEM);
        itemImage.sprite = currentItem.ItemDisplay;
    }
    public void UseItem()
    {
        currentItem.UseItem();
    }
    public void DropItem()
    {
        Instantiate(currentItem, playMove.rb.transform.position, Quaternion.identity);
        Destroy(currentItem);
    }
    public void SwapItem(Item newItem, int index)
    {
        inventoryIndex = index;
        
       if (newItem != null)
        {
            currentItem = newItem;
            Debug.Log("Item Switched to " + currentItem.ItemName);
            DisplayItem();
        }
        else
        {
            SoundManager.PlaySound(SoundType.ERROR);
            Debug.Log("No Item exists");
        }
        
    }

    public void PickUpItem()
    {
        inventory[inventoryIndex] = groundItem.GetComponent<EnemyDrops>().item;
        SwapItem(groundItem.GetComponent<EnemyDrops>().item, inventoryIndex);
        Destroy(groundItem);
    }

}