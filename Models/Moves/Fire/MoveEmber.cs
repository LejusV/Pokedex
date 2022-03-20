using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to burn the target.
	public class MoveEmber : Move
	{
#nullable enable
		private static MoveEmber? _instance = null;
#nullable restore
        public static MoveEmber Instance => _instance ?? (_instance = new MoveEmber());

		public MoveEmber() : base(
			"Ember",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			25, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}