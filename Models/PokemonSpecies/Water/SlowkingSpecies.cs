using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Slowking Species to store common natural stats of all Slowkings
	#region SlowkingSpecies
	public class SlowkingSpecies : PokemonSpecies
	{
#nullable enable
		private static SlowkingSpecies? _instance = null;
#nullable restore
        public static SlowkingSpecies Instance => _instance ?? (_instance = new SlowkingSpecies());

		#region SlowkingSpecies Constructor
		public SlowkingSpecies() : base(
			199,
			"Slowking",
			Water.Instance, Psychic.Instance,
			2.0,
			79.5,
			new PokemonStats(
				95, // HPs
				75, 80, // Attack & Defense
				100, 110, // Spacial Attack & Defense
				30 // Speed
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
				"Mega-Punch",
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Disable",
				"Flamethrower",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunder-Wave",
				"Earthquake",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Fire-Blast",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Yawn",
				"Skill-Swap",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Iron-Defense",
				"Block",
				"Calm-Mind",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Trump-Card",
				"Aqua-Tail",
				"Power-Gem",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Nasty-Plot",
				"Avalanche",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Foul-Play",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Heal-Pulse",
				"Incinerate",
				"Quash",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}