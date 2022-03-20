using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveOriginPulse : Move
	{
#nullable enable
		private static MoveOriginPulse? _instance = null;
#nullable restore
        public static MoveOriginPulse Instance => _instance ?? (_instance = new MoveOriginPulse());

		public MoveOriginPulse() : base(
			"Origin-Pulse",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 110,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}