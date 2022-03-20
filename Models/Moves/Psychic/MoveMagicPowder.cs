using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveMagicPowder : Move
	{
#nullable enable
		private static MoveMagicPowder? _instance = null;
#nullable restore
        public static MoveMagicPowder Instance => _instance ?? (_instance = new MoveMagicPowder());

		public MoveMagicPowder() : base(
			"Magic-Powder",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}