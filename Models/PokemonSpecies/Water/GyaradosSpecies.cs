using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gyarados Species to store common natural stats of all Gyaradoss
	#region GyaradosSpecies
	public class GyaradosSpecies : PokemonSpecies
	{
#nullable enable
		private static GyaradosSpecies? _instance = null;
#nullable restore
        public static GyaradosSpecies Instance => _instance ?? (_instance = new GyaradosSpecies());

		#region GyaradosSpecies Constructor
		public GyaradosSpecies() : base(
			130,
			"Gyarados",
			Water.Instance, Flying.Instance,
			6.5,
			235.0,
			new PokemonStats(
				95, // HPs
				125, 79, // Attack & Defense
				60, 100, // Spacial Attack & Defense
				81 // Speed
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
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Flamethrower",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Strength",
				"Dragon-Rage",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Waterfall",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Scary-Face",
				"Zap-Cannon",
				"Icy-Wind",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Crunch",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Torment",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Dive",
				"Bounce",
				"Dragon-Dance",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Giga-Impact",
				"Avalanche",
				"Ice-Fang",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Round",
				"Scald",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Hurricane",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}