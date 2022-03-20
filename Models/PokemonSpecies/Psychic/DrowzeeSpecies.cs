using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Drowzee Species to store common natural stats of all Drowzees
	#region DrowzeeSpecies
	public class DrowzeeSpecies : PokemonSpecies
	{
#nullable enable
		private static DrowzeeSpecies? _instance = null;
#nullable restore
        public static DrowzeeSpecies Instance => _instance ?? (_instance = new DrowzeeSpecies());

		#region DrowzeeSpecies Constructor
		public DrowzeeSpecies() : base(
			96,
			"Drowzee",
			Psychic.Instance,
			1.0,
			32.4,
			new PokemonStats(
				60, // HPs
				48, 45, // Attack & Defense
				43, 90, // Spacial Attack & Defense
				42 // Speed
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
				"Barrier",
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
				"Flatter",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Role-Play",
				"Assist",
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
				"Guard-Swap",
				"Drain-Punch",
				"Nasty-Plot",
				"Psycho-Cut",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Power-Split",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Synchronoise",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch",
				"Psychic-Terrain"
			};
		}
		#endregion
	}
	#endregion
}