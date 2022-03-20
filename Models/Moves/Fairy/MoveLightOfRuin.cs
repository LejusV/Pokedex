using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User receives 1/2 the damage inflicted in recoil.
	public class MoveLightOfRuin : Move
	{
#nullable enable
		private static MoveLightOfRuin? _instance = null;
#nullable restore
        public static MoveLightOfRuin Instance => _instance ?? (_instance = new MoveLightOfRuin());

		public MoveLightOfRuin() : base(
			"Light-Of-Ruin",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 140,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}