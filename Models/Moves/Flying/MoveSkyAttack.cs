using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User charges for one turn before attacking.  Has a 30% chance to make the target flinch.
	public class MoveSkyAttack : Move
	{
#nullable enable
		private static MoveSkyAttack? _instance = null;
#nullable restore
        public static MoveSkyAttack Instance => _instance ?? (_instance = new MoveSkyAttack());

		public MoveSkyAttack() : base(
			"Sky-Attack",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 140,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}