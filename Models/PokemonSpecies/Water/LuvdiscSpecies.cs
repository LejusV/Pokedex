using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Luvdisc Species to store common natural stats of all Luvdiscs
	#region LuvdiscSpecies
	public class LuvdiscSpecies : PokemonSpecies
	{
#nullable enable
		private static LuvdiscSpecies? _instance = null;
#nullable restore
        public static LuvdiscSpecies Instance => _instance ?? (_instance = new LuvdiscSpecies());

		#region LuvdiscSpecies Constructor
		public LuvdiscSpecies() : base(
			370,
			"Luvdisc",
			Water.Instance,
			0.6,
			8.7,
			new PokemonStats(
				43, // HPs
				30, 55, // Attack & Defense
				40, 65, // Spacial Attack & Defense
				97 // Speed
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
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Supersonic",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Agility",
				"Mimic",
				"Double-Team",
				"Waterfall",
				"Swift",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sweet-Kiss",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Lucky-Chant",
				"Aqua-Ring",
				"Captivate",
				"Aqua-Jet",
				"Soak",
				"Entrainment",
				"Round",
				"Scald",
				"Heal-Pulse",
				"Heart-Stamp",
				"Draining-Kiss",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}