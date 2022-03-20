using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Cures the target of a major status ailment and heals the user for 50% of its max HP.
	public class MovePurify : Move
	{
#nullable enable
		private static MovePurify? _instance = null;
#nullable restore
        public static MovePurify Instance => _instance ?? (_instance = new MovePurify());

		public MovePurify() : base(
			"Purify",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}