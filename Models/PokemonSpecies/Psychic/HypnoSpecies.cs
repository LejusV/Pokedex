using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Hypno Species to store common natural stats of all Hypnos
	#region HypnoSpecies
	public class HypnoSpecies : PokemonSpecies
	{
#nullable enable
		private static HypnoSpecies? _instance = null;
#nullable restore
        public static HypnoSpecies Instance => _instance ?? (_instance = new HypnoSpecies());

		#region HypnoSpecies Constructor
		public HypnoSpecies() : base(
			97,
			"Hypno",
			Psychic.Instance,
			1.6,
			75.6,
			new PokemonStats(
				85, // HPs
				73, 70, // Attack & Defense
				73, 115, // Spacial Attack & Defense
				67 // Speed
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
				"Pound",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Disable",
				"Psybeam",
				"Hyper-Beam",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Meditate",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Metronome",
				"Skull-Bash",
				"Dream-Eater",
				"Poison-Gas",
				"Flash",
				"Psywave",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Zap-Cannon",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Torment",
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
				"Signal-Beam",
				"Calm-Mind",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Fling",
				"Drain-Punch",
				"Focus-Blast",
				"Switcheroo",
				"Giga-Impact",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Synchronoise",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}