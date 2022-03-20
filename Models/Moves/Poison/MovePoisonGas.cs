using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Poisons the target.
	public class MovePoisonGas : Move
	{
#nullable enable
		private static MovePoisonGas? _instance = null;
#nullable restore
        public static MovePoisonGas Instance => _instance ?? (_instance = new MovePoisonGas());

		public MovePoisonGas() : base(
			"Poison-Gas",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}