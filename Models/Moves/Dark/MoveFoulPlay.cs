using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Calculates damage with the target's attacking stat.
	public class MoveFoulPlay : Move
	{
#nullable enable
		private static MoveFoulPlay? _instance = null;
#nullable restore
        public static MoveFoulPlay Instance => _instance ?? (_instance = new MoveFoulPlay());

		public MoveFoulPlay() : base(
			"Foul-Play",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 95,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}