using System.Collections.Generic;

public class ModifiedStat : BaseStat {

	private List<ModifyingAttribute> modifications;	//a list of attributes that modify this stat
	private int modValue;	//the amount added to the baseValue from the modifiers

	public ModifiedStat(){
		modifications = new List<ModifyingAttribute>();
		modValue = 0;
	}

	public void AddModifier(ModifyingAttribute mod){
		modifications.Add (mod);
	}

	private void CalculateModValue(){
		modValue = 0;

		if (modifications.Count > 0) {
			foreach(ModifyingAttribute att in modifications)
				modValue += (int)(att.attribute.AdjustedBaseValue * att.ratio);
		}

		/*public new int AdjustBaseValue {
			get{	return BaseValue + BuffValue + modValue;	}
		}

		public void Update(){
			CalculateModValue();

		}*/
	}
	public struct ModifyingAttribute{
		public Attribute attribute;
		public float ratio;
	}
}