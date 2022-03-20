using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User receives 1/2 the damage inflicted in recoil.
	public class MoveHeadSmash : Move
	{
#nullable enable
		private static MoveHeadSmash? _instance = null;
#nullable restore
        public static MoveHeadSmash Instance => _instance ?? (_instance = new MoveHeadSmash());

		public MoveHeadSmash() : base(
			"Head-Smash",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 150,// PP & Pow
			80, 0 // Acc & Priority
		) {}
	}
}