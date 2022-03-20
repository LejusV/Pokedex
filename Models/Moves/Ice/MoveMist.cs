using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Protects the user's stats from being changed by enemy moves.
	public class MoveMist : Move
	{
#nullable enable
		private static MoveMist? _instance = null;
#nullable restore
        public static MoveMist Instance => _instance ?? (_instance = new MoveMist());

		public MoveMist() : base(
			"Mist",
			Ice.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}