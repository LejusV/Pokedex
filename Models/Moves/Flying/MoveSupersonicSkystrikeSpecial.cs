using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSupersonicSkystrikeSpecial : Move
	{
#nullable enable
		private static MoveSupersonicSkystrikeSpecial? _instance = null;
#nullable restore
        public static MoveSupersonicSkystrikeSpecial Instance => _instance ?? (_instance = new MoveSupersonicSkystrikeSpecial());

		public MoveSupersonicSkystrikeSpecial() : base(
			"Supersonic-Skystrike--Special",
			Flying.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}