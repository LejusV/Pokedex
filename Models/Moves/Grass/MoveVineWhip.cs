using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveVineWhip : Move
	{
#nullable enable
		private static MoveVineWhip? _instance = null;
#nullable restore
        public static MoveVineWhip Instance => _instance ?? (_instance = new MoveVineWhip());

		public MoveVineWhip() : base(
			"Vine-Whip",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 45,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}