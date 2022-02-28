using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveAllOutPummelingSpecial : Move
	{
		public MoveAllOutPummelingSpecial() : base(
			"All-Out-Pummeling--Special",
			Fighting.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}