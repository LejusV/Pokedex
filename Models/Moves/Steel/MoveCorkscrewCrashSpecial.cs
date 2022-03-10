using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveCorkscrewCrashSpecial : Move
	{
		public MoveCorkscrewCrashSpecial() : base(
			"Corkscrew-Crash--Special",
			Steel.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}