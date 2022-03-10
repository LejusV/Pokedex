using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//User faints.
	public class MoveExplosion : Move
	{
		public MoveExplosion() : base(
			"Explosion",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 250,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}