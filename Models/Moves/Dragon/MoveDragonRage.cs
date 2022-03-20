using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts 40 points of damage.
	public class MoveDragonRage : Move
	{
#nullable enable
		private static MoveDragonRage? _instance = null;
#nullable restore
        public static MoveDragonRage Instance => _instance ?? (_instance = new MoveDragonRage());

		public MoveDragonRage() : base(
			"Dragon-Rage",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}