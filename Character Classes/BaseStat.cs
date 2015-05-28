public class BaseStat{
	private int baseValue;			//the base value of this stat
	private int buffValue;			//the amount of buff to this stat
	private int expToLevel;		//the total amount of exp needed to raise this skill
	private float levelModifier;	//the modifier applied to the exp to raise the skill

	public BaseStat(){
		baseValue = 0;
		buffValue = 0;
		levelModifier = 1.1f;
		expToLevel = 100;
	}

#region Getters and Setters
	public int BaseValue{
		get{	return baseValue;	}
		set{	baseValue = value;	}
	}

	public int BuffValue{
		get{	return buffValue;	}
		set{	baseValue = value;	}
	}

	public int ExpToLevel{
		get{	return expToLevel;	}
		set{	expToLevel = value;	}
	}

	public float LevelModifier{
		get{	return levelModifier;	}
		set{	levelModifier = value;	}
	}
#endregion

	private int CalculateExpToLevel(){
		return (int)(expToLevel * levelModifier);

	}

	public void LevelUp(){
		expToLevel = CalculateExpToLevel ();
		baseValue++;

	}

	public int AdjustedBaseValue{
		get {	return baseValue + buffValue;	}
	
	}
}
