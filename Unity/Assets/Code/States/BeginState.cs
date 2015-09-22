using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States				// Allows other scripts to access this file
{
	public class BeginState	: IStateBase	// Creates object & attaches IStateBase.cs to object
	{
		public BeginState()					// Constructor so object can be used
		{
			Debug.Log("Constructing BeginState");			
		}
		
		public void StateUpdate(){
		}
		public void ShowIt(){
		}
		
	}
}