using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Heals the user by half its max HP.
	public class MoveSoftBoiled : Move
	{
#nullable enable
		private static MoveSoftBoiled? _instance = null;
#nullable restore
        public static MoveSoftBoiled Instance => _instance ?? (_instance = new MoveSoftBoiled());

		public MoveSoftBoiled() : base(
			"Soft-Boiled",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}