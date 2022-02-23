using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User takes 1/3 the damage inflicted in recoil.  Has a 10% chance to paralyze the target.
	public class MoveVoltTackle : Move
	{
		public MoveVoltTackle() : base(
			"Volt-Tackle",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 120,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}