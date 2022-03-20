using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveHeadbutt : Move
	{
#nullable enable
		private static MoveHeadbutt? _instance = null;
#nullable restore
        public static MoveHeadbutt Instance => _instance ?? (_instance = new MoveHeadbutt());

		public MoveHeadbutt() : base(
			"Headbutt",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}