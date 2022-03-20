using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Can only be used as the first move after the user enters battle.
	public class MoveFirstImpression : Move
	{
#nullable enable
		private static MoveFirstImpression? _instance = null;
#nullable restore
        public static MoveFirstImpression Instance => _instance ?? (_instance = new MoveFirstImpression());

		public MoveFirstImpression() : base(
			"First-Impression",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 90,// PP & Pow
			100, 2 // Acc & Priority
		) {}
	}
}