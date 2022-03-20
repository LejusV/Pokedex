using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lapras Species to store common natural stats of all Laprass
	#region LaprasSpecies
	public class LaprasSpecies : PokemonSpecies
	{
#nullable enable
		private static LaprasSpecies? _instance = null;
#nullable restore
        public static LaprasSpecies Instance => _instance ?? (_instance = new LaprasSpecies());

		#region LaprasSpecies Constructor
		public LaprasSpecies() : base(
			131,
			"Lapras",
			Water.Instance, Ice.Instance,
			2.5,
			220.0,
			new PokemonStats(
				130, // HPs
				85, 80, // Attack & Defense
				85, 95, // Spacial Attack & Defense
				60 // Speed
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
				"Headbutt",
				"Horn-Drill",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Roar",
				"Sing",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Dragon-Rage",
				"Thunderbolt",
				"Thunder",
				"Fissure",
				"Toxic",
				"Psychic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Reflect",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Dream-Eater",
				"Psywave",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Zap-Cannon",
				"Foresight",
				"Perish-Song",
				"Icy-Wind",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Future-Sight",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Tickle",
				"Signal-Beam",
				"Sheer-Cold",
				"Block",
				"Dragon-Dance",
				"Shock-Wave",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Giga-Impact",
				"Avalanche",
				"Ice-Shard",
				"Zen-Headbutt",
				"Iron-Head",
				"Captivate",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Frost-Breath",
				"Drill-Run",
				"Freeze-Dry",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}