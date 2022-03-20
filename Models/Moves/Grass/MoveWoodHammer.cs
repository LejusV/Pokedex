using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User receives 1/3 the damage inflicted in recoil.
	public class MoveWoodHammer : Move
	{
#nullable enable
		private static MoveWoodHammer? _instance = null;
#nullable restore
        public static MoveWoodHammer Instance => _instance ?? (_instance = new MoveWoodHammer());

		public MoveWoodHammer() : base(
			"Wood-Hammer",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}