using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveVeeveeVolley : Move
	{
#nullable enable
		private static MoveVeeveeVolley? _instance = null;
#nullable restore
        public static MoveVeeveeVolley Instance => _instance ?? (_instance = new MoveVeeveeVolley());

		public MoveVeeveeVolley() : base(
			"Veevee-Volley",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}