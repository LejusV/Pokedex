using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveDragonEnergy : Move
	{
#nullable enable
		private static MoveDragonEnergy? _instance = null;
#nullable restore
        public static MoveDragonEnergy Instance => _instance ?? (_instance = new MoveDragonEnergy());

		public MoveDragonEnergy() : base(
			"Dragon-Energy",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}