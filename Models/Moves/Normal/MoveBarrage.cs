using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveBarrage : Move
	{
#nullable enable
		private static MoveBarrage? _instance = null;
#nullable restore
        public static MoveBarrage Instance => _instance ?? (_instance = new MoveBarrage());

		public MoveBarrage() : base(
			"Barrage",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 15,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}