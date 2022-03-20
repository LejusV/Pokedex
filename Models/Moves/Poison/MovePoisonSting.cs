using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to poison the target.
	public class MovePoisonSting : Move
	{
#nullable enable
		private static MovePoisonSting? _instance = null;
#nullable restore
        public static MovePoisonSting Instance => _instance ?? (_instance = new MovePoisonSting());

		public MovePoisonSting() : base(
			"Poison-Sting",
			Poison.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			35, 15,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}