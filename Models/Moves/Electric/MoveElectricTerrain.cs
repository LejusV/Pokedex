using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//For five turns, prevents all Pokémon on the ground from sleeping and strengthens their electric moves to 1.5× their power.
	public class MoveElectricTerrain : Move
	{
#nullable enable
		private static MoveElectricTerrain? _instance = null;
#nullable restore
        public static MoveElectricTerrain Instance => _instance ?? (_instance = new MoveElectricTerrain());

		public MoveElectricTerrain() : base(
			"Electric-Terrain",
			Electric.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}