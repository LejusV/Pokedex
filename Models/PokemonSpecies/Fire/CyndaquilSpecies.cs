using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cyndaquil Species to store common natural stats of all Cyndaquils
	#region CyndaquilSpecies
	public class CyndaquilSpecies : PokemonSpecies
	{
#nullable enable
		private static CyndaquilSpecies? _instance = null;
#nullable restore
        public static CyndaquilSpecies Instance => _instance ?? (_instance = new CyndaquilSpecies());

		#region CyndaquilSpecies Constructor
		public CyndaquilSpecies() : base(
			155,
			"Cyndaquil",
			Fire.Instance,
			0.5,
			7.9,
			new PokemonStats(
				39, // HPs
				52, 43, // Attack & Defense
				60, 50, // Spacial Attack & Defense
				65 // Speed
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
				"Double-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Ember",
				"Flamethrower",
				"Submission",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Defense-Curl",
				"Fire-Blast",
				"Swift",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Nature-Power",
				"Eruption",
				"Secret-Power",
				"Crush-Claw",
				"Overheat",
				"Extrasensory",
				"Aerial-Ace",
				"Howl",
				"Covet",
				"Natural-Gift",
				"Flare-Blitz",
				"Lava-Plume",
				"Captivate",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Inferno",
				"Fire-Pledge",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Burn-Up"
			};
		}
		#endregion
	}
	#endregion
}