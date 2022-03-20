using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits any Pokémon that shares a type with the user.
	public class MoveSynchronoise : Move
	{
#nullable enable
		private static MoveSynchronoise? _instance = null;
#nullable restore
        public static MoveSynchronoise Instance => _instance ?? (_instance = new MoveSynchronoise());

		public MoveSynchronoise() : base(
			"Synchronoise",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}