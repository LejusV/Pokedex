using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSupersonicSkystrikePhysical : Move
	{
#nullable enable
		private static MoveSupersonicSkystrikePhysical? _instance = null;
#nullable restore
        public static MoveSupersonicSkystrikePhysical Instance => _instance ?? (_instance = new MoveSupersonicSkystrikePhysical());

		public MoveSupersonicSkystrikePhysical() : base(
			"Supersonic-Skystrike--Physical",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}