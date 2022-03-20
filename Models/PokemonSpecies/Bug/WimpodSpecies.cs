using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Wimpod Species to store common natural stats of all Wimpods
	#region WimpodSpecies
	public class WimpodSpecies : PokemonSpecies
	{
#nullable enable
		private static WimpodSpecies? _instance = null;
#nullable restore
        public static WimpodSpecies Instance => _instance ?? (_instance = new WimpodSpecies());

		#region WimpodSpecies Constructor
		public WimpodSpecies() : base(
			767,
			"Wimpod",
			Bug.Instance, Water.Instance,
			0.5,
			12.0,
			new PokemonStats(
				25, // HPs
				35, 40, // Attack & Defense
				20, 30, // Spacial Attack & Defense
				80 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Sand-Attack",
				"Surf",
				"Toxic",
				"Double-Team",
				"Harden",
				"Waterfall",
				"Leech-Life",
				"Rest",
				"Substitute",
				"Protect",
				"Spikes",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Hail",
				"Facade",
				"Taunt",
				"Aqua-Jet",
				"Wide-Guard",
				"Round",
				"Scald",
				"Struggle-Bug",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}