using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot {
	public Button btn;
	public Item itm;
}

public class Inventory : MonoBehaviour {


	public PlayerController playa;
	public GameObject[] pocketTableButtons;
	public Slot[] pocketInventory;
	private int extraPage = 0;
	public bool inventoryInit = false;


	// Use this for initialization
	void Start () {
		pocketTableButtons = GameObject.FindGameObjectsWithTag ("InventoryButton");
		pocketInventory = new Slot[8];
		for(int i = 0; i < 8; i++)
		{
			pocketInventory[i] = new Slot ();
		}
		InventorySetup ();
		inventoryInit = true;
	}

	void OnEnable() 
	{
		if (inventoryInit) {
			InventorySetup ();
		}
		extraPage = 0;
	}
		
	// Update is called once per frame
	void Update () {
		
	}

	public void InventorySetup()
	{
		for (int i = 0; i < 8; i++) 
		{
			pocketInventory [i].btn = pocketTableButtons [i].GetComponent<Button> ();
			if (i < playa.pocketItems.Count)
			{
				Debug.Log ("entered if in inventory setup");
				pocketInventory [i].itm = playa.pocketItems [i];
				pocketInventory [i].btn.transform.GetChild (0).GetComponent<Text> ().text = pocketInventory [i].itm.name;
				pocketTableButtons [i].transform.GetChild (0).GetComponent<Text> ().text = pocketInventory [i].itm.name;
			}
			else 
			{
				Debug.Log ("entered else in inventory setup");
				pocketInventory [i].itm = null;
				pocketInventory [i].btn.transform.GetChild (0).GetComponent<Text> ().text = "";
			}

		}
	}

	public void Next()
	{
		extraPage++;
		for (int i = 0; i < 8; i++) 
		{
			if (i + (8 * extraPage) < playa.pocketItems.Count)
			{
				pocketInventory [i].itm = playa.pocketItems [i + (8 * extraPage)];
				pocketInventory [i].btn.transform.GetChild (0).GetComponent<Text> ().text = pocketInventory [i].itm.name;
				pocketTableButtons [i].transform.GetChild (0).GetComponent<Text> ().text = pocketInventory [i].itm.name;
			} 
			else 
			{
				pocketInventory [i].itm = null;
				pocketInventory [i].btn.transform.GetChild (0).GetComponent<Text> ().text = "";
			}
		}

	}

	public void Previous()
	{
		if (extraPage >= 1) 
		{
			extraPage--;
		}
		for (int i = 0; i < 8; i++) 
		{
			if (i + (8 * extraPage) < playa.pocketItems.Count) 
			{
				pocketInventory [i].itm = playa.pocketItems [i + (8 * extraPage)];
				pocketInventory [i].btn.transform.GetChild (0).GetComponent<Text> ().text = pocketInventory [i].itm.name;
				pocketTableButtons [i].transform.GetChild (0).GetComponent<Text> ().text = pocketInventory [i].itm.name;
			}
			else 
			{
				pocketInventory [i].itm = null;
				pocketInventory [i].btn.transform.GetChild (0).GetComponent<Text> ().text = "";
			}
		}
	}
}
