using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveRockBlast : Move
	{
#nullable enable
		private static MoveRockBlast? _instance = null;
#nullable restore
        public static MoveRockBlast Instance => _instance ?? (_instance = new MoveRockBlast());

		public MoveRockBlast() : base(
			"Rock-Blast",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 25,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}