using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage and can hit Bounce and Fly users.
	public class MoveSkyUppercut : Move
	{
#nullable enable
		private static MoveSkyUppercut? _instance = null;
#nullable restore
        public static MoveSkyUppercut Instance => _instance ?? (_instance = new MoveSkyUppercut());

		public MoveSkyUppercut() : base(
			"Sky-Uppercut",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 85,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}