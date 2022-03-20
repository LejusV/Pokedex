using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Basculin-Red-Striped Species to store common natural stats of all Basculin-Red-Stripeds
	#region Basculin-Red-StripedSpecies
	public class BasculinRedStripedSpecies : PokemonSpecies
	{
#nullable enable
		private static BasculinRedStripedSpecies? _instance = null;
#nullable restore
        public static BasculinRedStripedSpecies Instance => _instance ?? (_instance = new BasculinRedStripedSpecies());

		#region Basculin-Red-StripedSpecies Constructor
		public BasculinRedStripedSpecies() : base(
			550,
			"Basculin-Red-Striped",
			Water.Instance,
			1.0,
			18.0,
			new PokemonStats(
				70, // HPs
				92, 65, // Attack & Defense
				80, 55, // Spacial Attack & Defense
				98 // Speed
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
				"Cut",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Tail-Whip",
				"Bite",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Bubble-Beam",
				"Toxic",
				"Agility",
				"Rage",
				"Double-Team",
				"Waterfall",
				"Swift",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Scary-Face",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Taunt",
				"Superpower",
				"Revenge",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Muddy-Water",
				"Bounce",
				"Mud-Shot",
				"Brine",
				"Aqua-Tail",
				"Zen-Headbutt",
				"Aqua-Jet",
				"Head-Smash",
				"Soak",
				"Round",
				"Chip-Away",
				"Scald",
				"Final-Gambit",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}