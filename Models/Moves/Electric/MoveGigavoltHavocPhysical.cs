using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveGigavoltHavocPhysical : Move
	{
#nullable enable
		private static MoveGigavoltHavocPhysical? _instance = null;
#nullable restore
        public static MoveGigavoltHavocPhysical Instance => _instance ?? (_instance = new MoveGigavoltHavocPhysical());

		public MoveGigavoltHavocPhysical() : base(
			"Gigavolt-Havoc--Physical",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}