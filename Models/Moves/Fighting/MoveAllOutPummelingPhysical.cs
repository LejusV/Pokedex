using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveAllOutPummelingPhysical : Move
	{
		public MoveAllOutPummelingPhysical() : base(
			"All-Out-Pummeling--Physical",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}