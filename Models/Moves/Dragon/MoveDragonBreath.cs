using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to paralyze the target.
	public class MoveDragonBreath : Move
	{
#nullable enable
		private static MoveDragonBreath? _instance = null;
#nullable restore
        public static MoveDragonBreath Instance => _instance ?? (_instance = new MoveDragonBreath());

		public MoveDragonBreath() : base(
			"Dragon-Breath",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}