using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User receives 1/4 the damage it inflicts in recoil.
	public class MoveHeadCharge : Move
	{
#nullable enable
		private static MoveHeadCharge? _instance = null;
#nullable restore
        public static MoveHeadCharge Instance => _instance ?? (_instance = new MoveHeadCharge());

		public MoveHeadCharge() : base(
			"Head-Charge",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}