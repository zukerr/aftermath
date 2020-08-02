using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float sanity;
	public float hunger;
	public float rest;

	public float time_since_beginning = 0;
	public float current_time = 0;
	public int dayCounter = 0;

	public const float maxDamage = 100;

	public float leftArmWounds = maxDamage;
	public float rightArmWounds = maxDamage;
	public float leftLegWounds = maxDamage;
	public float rightLegWounds = maxDamage;
	public float CorpseWounds = maxDamage;
	public float HeadWounds = maxDamage;

	public const float max_pocket_weight = 200;
	public float remaining_pocket_weight = max_pocket_weight;

	public float max_additional_weight = 0;
	public float remaining_additional_weight = 0;

	public List<Item> pocketItems;
	public List<Item> additionalItems;

	// Use this for initialization
	void Start () {

		pocketItems = new List<Item> ();
		additionalItems = new List<Item> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddItem(Item _item)
	{
		if (_item.container) 
		{
			max_additional_weight = _item.weight;
			remaining_additional_weight = max_additional_weight;
		} 
		else 
		{
			if (_item.pocket) 
			{
				if (remaining_pocket_weight >= _item.weight) 
				{
					pocketItems.Add (_item);
					remaining_pocket_weight -= _item.weight;
				} 
				else 
				{
					Debug.Log ("You can't put any more items in your pockets!");
				}
			}

			if (!_item.pocket) 
			{
				if (remaining_additional_weight >= _item.weight)
				{
					additionalItems.Add (_item);
					remaining_additional_weight -= _item.weight;
				} 
				else 
				{
					Debug.Log ("You can't put any more items in your additional container!");
				}
			}
		}
	}

	public void PassTime(float t)
	{
		time_since_beginning += t;
		if (current_time + t > 24f) 
		{
			current_time += (t - 24);
			NextDay ();
		} 
		else 
		{
			current_time += t;
		}
	}

	public void NextDay()
	{
		dayCounter++;

		foreach (Item item in pocketItems) 
		{
			if (item.rotting) 
			{
				item.progress_of_rotting += item.speed_of_rotting;
				if (item.progress_of_rotting >= 1) 
				{
					item.itsRotted = true;
				}
			}
		}

		foreach (Item item in additionalItems) 
		{
			if (item.rotting) 
			{
				item.progress_of_rotting += item.speed_of_rotting;
				if (item.progress_of_rotting >= 1) 
				{
					item.itsRotted = true;
				}
			}
		}
	}
}
