using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum evntType
{
	normal,
	item,
	announcement
};

public class EventUnit {


	public int buttonsQuantity;
	public string textToDisplay;
	public string text1 = "";
	public string text2 = "";
	public string text3 = "";
	public string text4 = "";
	public string text5 = "";
	public string text6 = "";

	public EventUnit ev1 = null;
	public EventUnit ev2 = null;
	public EventUnit ev3 = null;
	public EventUnit ev4 = null;
	public EventUnit ev5 = null;
	public EventUnit ev6 = null;

	public float duration = 0;

	public evntType evType = evntType.normal;

	//variables for items
	public bool pickedUp = false;
	public Item carriedItem = null;
}
