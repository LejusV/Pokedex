using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePhotonGeyser : Move
	{
		public MovePhotonGeyser() : base(
			"Photon-Geyser",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 100,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}