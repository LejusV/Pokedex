using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power doubles every turn this move is used in succession after the first, maxing out after five turns.
	public class MoveFuryCutter : Move
	{
#nullable enable
		private static MoveFuryCutter? _instance = null;
#nullable restore
        public static MoveFuryCutter Instance => _instance ?? (_instance = new MoveFuryCutter());

		public MoveFuryCutter() : base(
			"Fury-Cutter",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 40,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}