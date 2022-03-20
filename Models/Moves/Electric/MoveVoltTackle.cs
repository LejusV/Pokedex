using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User takes 1/3 the damage inflicted in recoil.  Has a 10% chance to paralyze the target.
	public class MoveVoltTackle : Move
	{
#nullable enable
		private static MoveVoltTackle? _instance = null;
#nullable restore
        public static MoveVoltTackle Instance => _instance ?? (_instance = new MoveVoltTackle());

		public MoveVoltTackle() : base(
			"Volt-Tackle",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}