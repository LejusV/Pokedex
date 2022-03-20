using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Changes the target's type to Water.
	public class MoveSoak : Move
	{
#nullable enable
		private static MoveSoak? _instance = null;
#nullable restore
        public static MoveSoak Instance => _instance ?? (_instance = new MoveSoak());

		public MoveSoak() : base(
			"Soak",
			Water.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}