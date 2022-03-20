using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to inflict a status effect which depends upon the terrain.
	public class MoveSecretPower : Move
	{
#nullable enable
		private static MoveSecretPower? _instance = null;
#nullable restore
        public static MoveSecretPower Instance => _instance ?? (_instance = new MoveSecretPower());

		public MoveSecretPower() : base(
			"Secret-Power",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}