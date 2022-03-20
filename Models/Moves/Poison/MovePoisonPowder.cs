using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Poisons the target.
	public class MovePoisonPowder : Move
	{
#nullable enable
		private static MovePoisonPowder? _instance = null;
#nullable restore
        public static MovePoisonPowder Instance => _instance ?? (_instance = new MovePoisonPowder());

		public MovePoisonPowder() : base(
			"Poison-Powder",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			35, null,// PP & Pow
			75, 0 // Acc & Priority
		) {}
	}
}