using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to poison the target.
	public class MovePoisonJab : Move
	{
#nullable enable
		private static MovePoisonJab? _instance = null;
#nullable restore
        public static MovePoisonJab Instance => _instance ?? (_instance = new MovePoisonJab());

		public MovePoisonJab() : base(
			"Poison-Jab",
			Poison.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}