using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePhotonGeyser : Move
	{
#nullable enable
		private static MovePhotonGeyser? _instance = null;
#nullable restore
        public static MovePhotonGeyser Instance => _instance ?? (_instance = new MovePhotonGeyser());

		public MovePhotonGeyser() : base(
			"Photon-Geyser",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}