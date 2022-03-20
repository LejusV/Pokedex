using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveThunderousKick : Move
	{
#nullable enable
		private static MoveThunderousKick? _instance = null;
#nullable restore
        public static MoveThunderousKick Instance => _instance ?? (_instance = new MoveThunderousKick());

		public MoveThunderousKick() : base(
			"Thunderous-Kick",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}