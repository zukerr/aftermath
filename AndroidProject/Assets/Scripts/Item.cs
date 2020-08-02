using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {

	public string name;
	//either weight of the item or max weight of the container
	public float weight = 0f;
	public bool pocket = true;
	public bool container = false;

	//Food variables
	public bool food = false;
	public bool rotting = false;
	public float speed_of_rotting = 0.5f;
	//if its on 1 its rotted
	public float progress_of_rotting = 0f;
	public bool itsRotted = false;
}
