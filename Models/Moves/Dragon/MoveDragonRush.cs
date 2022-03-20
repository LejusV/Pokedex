using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to make the target flinch.
	public class MoveDragonRush : Move
	{
#nullable enable
		private static MoveDragonRush? _instance = null;
#nullable restore
        public static MoveDragonRush Instance => _instance ?? (_instance = new MoveDragonRush());

		public MoveDragonRush() : base(
			"Dragon-Rush",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			75, 0 // Acc & Priority
		) {}
	}
}