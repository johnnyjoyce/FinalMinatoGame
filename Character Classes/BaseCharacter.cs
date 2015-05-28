using UnityEngine;
using System.Collections;
using System;		//allows access to the enum class

public class BaseCharacter : MonoBehaviour {

	private string name;
	private int level;
	private uint freeExp;	//unsigned integer

	private Attribute[] primaryAttribute;
	private Vitals[] vitals;
	private Skills[] skills;

	public void Awake(){
		name = string.Empty;
		level = 0;
		freeExp = 0;

		primaryAttribute = new Attribute[Enum.GetValues(typeof(AttributeName)).Length];
		vitals = new Vitals[Enum.GetValues(typeof(VitalName)).Length];
		skills = new Skills[Enum.GetValues(typeof(SkillName)).Length];
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public string Name{
		get{	return name;	}
		set{	name = value;	}
	}

	public int Level{
		get{	return level;	}
		set{	level = value;	}
	}

	public uint FreeExp{
		get{	return freeExp;	}
		set{	freeExp = value;	}
	}

	public void AddExp(uint exp){
		freeExp += exp;

		CalculateLevel();
	}
	//take average of all of the players skills and assign that as the player level
	public void CalculateLevel(){
	}

	/*private void SetupPrimaryAttributes(){
		for (int cnt = 0; cnt < primaryAttribute.Length; cnt++) {
			primaryAttribute[cnt] = new Attribute();
		}
	}

	private void SetupVitals(){
		for (int cnt = 0; cnt < vitals.Length; cnt++) {
			vitals[cnt] = new Vitals();
	}

	private void SetupSkills(){
			for (int cnt = 0; cnt < skills.Length; cnt++) {
				skills[cnt] = new Skills();
	}*/
}