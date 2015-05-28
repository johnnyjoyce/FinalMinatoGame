public class Vitals : ModifiedStat {
	private int currentValue;

	public Vitals(){
		currentValue = 0;
		ExpToLevel = 50;
		LevelModifier = 1.1f;

	}

	/*public int CurrentValue{
		get{	if(currentValue > AdjustedBaseValue)
			return currentValue;	}
		set{	currentValue = value;	}

	}*/

}

public enum VitalName{
	Health,
	Stamina,
	Chakra
}
