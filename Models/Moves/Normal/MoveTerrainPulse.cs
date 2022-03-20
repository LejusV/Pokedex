using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveTerrainPulse : Move
	{
#nullable enable
		private static MoveTerrainPulse? _instance = null;
#nullable restore
        public static MoveTerrainPulse Instance => _instance ?? (_instance = new MoveTerrainPulse());

		public MoveTerrainPulse() : base(
			"Terrain-Pulse",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}