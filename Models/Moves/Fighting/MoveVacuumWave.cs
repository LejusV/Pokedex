using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveVacuumWave : Move
	{
		public MoveVacuumWave() : base(
			"Vacuum-Wave",
			Fighting.Instance, // Move Type
			MoveCategory.Special, // Move Category
			30, 40,// PP & Pow
			1.0, 1 // Acc & Priority
		) {}
	}
}