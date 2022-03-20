using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveWaterGun : Move
	{
#nullable enable
		private static MoveWaterGun? _instance = null;
#nullable restore
        public static MoveWaterGun Instance => _instance ?? (_instance = new MoveWaterGun());

		public MoveWaterGun() : base(
			"Water-Gun",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			25, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}