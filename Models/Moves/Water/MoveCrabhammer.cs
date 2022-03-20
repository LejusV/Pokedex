using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveCrabhammer : Move
	{
#nullable enable
		private static MoveCrabhammer? _instance = null;
#nullable restore
        public static MoveCrabhammer Instance => _instance ?? (_instance = new MoveCrabhammer());

		public MoveCrabhammer() : base(
			"Crabhammer",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}