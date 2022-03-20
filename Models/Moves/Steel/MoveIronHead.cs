using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveIronHead : Move
	{
#nullable enable
		private static MoveIronHead? _instance = null;
#nullable restore
        public static MoveIronHead Instance => _instance ?? (_instance = new MoveIronHead());

		public MoveIronHead() : base(
			"Iron-Head",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}