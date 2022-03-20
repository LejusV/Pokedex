using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power increases when this move has less PP, up to a maximum of 200.
	public class MoveTrumpCard : Move
	{
#nullable enable
		private static MoveTrumpCard? _instance = null;
#nullable restore
        public static MoveTrumpCard Instance => _instance ?? (_instance = new MoveTrumpCard());

		public MoveTrumpCard() : base(
			"Trump-Card",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}