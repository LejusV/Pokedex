using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to make the target flinch.
	public class MoveZenHeadbutt : Move
	{
#nullable enable
		private static MoveZenHeadbutt? _instance = null;
#nullable restore
        public static MoveZenHeadbutt Instance => _instance ?? (_instance = new MoveZenHeadbutt());

		public MoveZenHeadbutt() : base(
			"Zen-Headbutt",
			Psychic.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}