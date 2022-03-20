using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mewtwo Species to store common natural stats of all Mewtwos
	#region MewtwoSpecies
	public class MewtwoSpecies : PokemonSpecies
	{
#nullable enable
		private static MewtwoSpecies? _instance = null;
#nullable restore
        public static MewtwoSpecies Instance => _instance ?? (_instance = new MewtwoSpecies());

		#region MewtwoSpecies Constructor
		public MewtwoSpecies() : base(
			150,
			"Mewtwo",
			Psychic.Instance,
			2.0,
			122.0,
			new PokemonStats(
				106, // HPs
				110, 90, // Attack & Defense
				154, 90, // Spacial Attack & Defense
				130 // Speed
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
				"Pay-Day",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Disable",
				"Flamethrower",
				"Mist",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Confusion",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Recover",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Metronome",
				"Self-Destruct",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Amnesia",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Rock-Slide",
				"Tri-Attack",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
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
				"Future-Sight",
				"Rock-Smash",
				"Hail",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Signal-Beam",
				"Aerial-Ace",
				"Bulk-Up",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Miracle-Eye",
				"Natural-Gift",
				"Embargo",
				"Fling",
				"Me-First",
				"Power-Swap",
				"Guard-Swap",
				"Aura-Sphere",
				"Poison-Jab",
				"Aqua-Tail",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Avalanche",
				"Psycho-Cut",
				"Zen-Headbutt",
				"Rock-Climb",
				"Trick-Room",
				"Stone-Edge",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Psystrike",
				"Confide",
				"Power-Up-Punch",
				"Laser-Focus",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}