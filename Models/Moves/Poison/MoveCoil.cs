using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack, Defense, and accuracy by one stage each.
	public class MoveCoil : Move
	{
#nullable enable
		private static MoveCoil? _instance = null;
#nullable restore
        public static MoveCoil Instance => _instance ?? (_instance = new MoveCoil());

		public MoveCoil() : base(
			"Coil",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}