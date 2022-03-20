using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Ends wild battles.  Forces trainers to switch Pokémon.
	public class MoveDragonTail : Move
	{
#nullable enable
		private static MoveDragonTail? _instance = null;
#nullable restore
        public static MoveDragonTail Instance => _instance ?? (_instance = new MoveDragonTail());

		public MoveDragonTail() : base(
			"Dragon-Tail",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 60,// PP & Pow
			90, -6 // Acc & Priority
		) {}
	}
}