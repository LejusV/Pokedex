using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Changes the terrain to Psychic Terrain after inflicting damage.
	public class MoveGenesisSupernova : Move
	{
		public MoveGenesisSupernova() : base(
			"Genesis-Supernova",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, 185,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}