using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveVacuumWave : Move
	{
#nullable enable
		private static MoveVacuumWave? _instance = null;
#nullable restore
        public static MoveVacuumWave Instance => _instance ?? (_instance = new MoveVacuumWave());

		public MoveVacuumWave() : base(
			"Vacuum-Wave",
			Fighting.Instance, // Move Type
			MoveCategory.Special, // Move Category
			30, 40,// PP & Pow
			100, 1 // Acc & Priority
		) {}
	}
}