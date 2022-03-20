using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Causes a one-hit KO.
	public class MoveHornDrill : Move
	{
#nullable enable
		private static MoveHornDrill? _instance = null;
#nullable restore
        public static MoveHornDrill Instance => _instance ?? (_instance = new MoveHornDrill());

		public MoveHornDrill() : base(
			"Horn-Drill",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, null,// PP & Pow
			30, 0 // Acc & Priority
		) {}
	}
}