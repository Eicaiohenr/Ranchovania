﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour {

	public Texture2D map;
	public ColorTile[] colorTile;

	void Start () {
		GenerateLevel();
	}
	
	void GenerateLevel(){
		for (int x = 0; x < map.width; x++)
		{
			for (int y = 0; y < map.height; y++)
			{
				GenerateTile(x, y);
			}
		}
	}
	void GenerateTile(int x, int y){
		
		Color pixelColor = map.GetPixel(x, y);
		Debug.Log(pixelColor);
		if(pixelColor.a == 0){
			Debug.Log("Transparente");
			return;
		}
		foreach (ColorTile tile in colorTile)
		{
			//if(tile.color.Equals(pixelColor)){
				Vector2 position = new Vector2(x, y);
				Instantiate(tile.prefab, position, Quaternion.identity, transform);
			//}
		}
	}
}
