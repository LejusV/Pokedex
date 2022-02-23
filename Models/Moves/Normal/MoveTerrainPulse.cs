using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveTerrainPulse : Move
	{
		public MoveTerrainPulse() : base(
			"Terrain-Pulse",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 50,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}