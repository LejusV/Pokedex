using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to lower the target's Special Defense by one stage.
	public class MoveEarthPower : Move
	{
#nullable enable
		private static MoveEarthPower? _instance = null;
#nullable restore
        public static MoveEarthPower Instance => _instance ?? (_instance = new MoveEarthPower());

		public MoveEarthPower() : base(
			"Earth-Power",
			Ground.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}