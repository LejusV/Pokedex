using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveFuryAttack : Move
	{
#nullable enable
		private static MoveFuryAttack? _instance = null;
#nullable restore
        public static MoveFuryAttack Instance => _instance ?? (_instance = new MoveFuryAttack());

		public MoveFuryAttack() : base(
			"Fury-Attack",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 15,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}