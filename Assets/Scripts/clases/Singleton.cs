using UnityEngine;
using System.Collections;

public class Singleton
{
	private static Singleton instance;
	
	private Singleton() {}

	public int madera;
	public int comida;
	public int piedra;
	
	public static Singleton Instance
	{
		get 
		{
			if (instance == null)
			{
				instance = new Singleton();
			}
			return instance;
		}
	}
}
