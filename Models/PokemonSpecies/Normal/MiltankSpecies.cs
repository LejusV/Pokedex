using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Miltank Species to store common natural stats of all Miltanks
	#region MiltankSpecies
	public class MiltankSpecies : PokemonSpecies
	{
#nullable enable
		private static MiltankSpecies? _instance = null;
#nullable restore
        public static MiltankSpecies Instance => _instance ?? (_instance = new MiltankSpecies());

		#region MiltankSpecies Constructor
		public MiltankSpecies() : base(
			241,
			"Miltank",
			Normal.Instance,
			1.2,
			75.5,
			new PokemonStats(
				95, // HPs
				80, 105, // Attack & Defense
				40, 70, // Spacial Attack & Defense
				100 // Speed
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Stomp",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Metronome",
				"Dizzy-Punch",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Milk-Drink",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Present",
				"Frustration",
				"Dynamic-Punch",
				"Sweet-Scent",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Block",
				"Shock-Wave",
				"Water-Pulse",
				"Wake-Up-Slap",
				"Hammer-Arm",
				"Gyro-Ball",
				"Natural-Gift",
				"Fling",
				"Punishment",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Iron-Head",
				"Captivate",
				"Stealth-Rock",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Heart-Stamp",
				"Belch",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}