using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User takes 1/4 its max HP in recoil.
	public class MoveStruggle : Move
	{
#nullable enable
		private static MoveStruggle? _instance = null;
#nullable restore
        public static MoveStruggle Instance => _instance ?? (_instance = new MoveStruggle());

		public MoveStruggle() : base(
			"Struggle",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, 50,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}