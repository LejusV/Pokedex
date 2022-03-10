using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to inflict a status effect which depends upon the terrain.
	public class MoveSecretPower : Move
	{
		public MoveSecretPower() : base(
			"Secret-Power",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}