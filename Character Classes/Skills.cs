public class Skills : ModifiedStat {
	private bool known;

	public Skills(){
		known = false;
		ExpToLevel = 25;
		LevelModifier = 1.1f;
	}

	public bool Known{
		get{	return known;	}
		set{	known = value;	}
	}
}

public enum SkillName{
	Melee,
	Rasengan,
	Kunai_Teleport,
	Sage_Mode
}
