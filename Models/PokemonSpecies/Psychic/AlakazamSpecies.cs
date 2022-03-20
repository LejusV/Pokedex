using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Alakazam Species to store common natural stats of all Alakazams
	#region AlakazamSpecies
	public class AlakazamSpecies : PokemonSpecies
	{
#nullable enable
		private static AlakazamSpecies? _instance = null;
#nullable restore
        public static AlakazamSpecies Instance => _instance ?? (_instance = new AlakazamSpecies());

		#region AlakazamSpecies Constructor
		public AlakazamSpecies() : base(
			65,
			"Alakazam",
			Psychic.Instance,
			1.5,
			48.0,
			new PokemonStats(
				55, // HPs
				50, 45, // Attack & Defense
				135, 95, // Spacial Attack & Defense
				120 // Speed
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
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Disable",
				"Psybeam",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Metronome",
				"Skull-Bash",
				"Kinesis",
				"Dream-Eater",
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
				"Iron-Tail",
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
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Signal-Beam",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Miracle-Eye",
				"Natural-Gift",
				"Embargo",
				"Fling",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Psycho-Cut",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Ally-Switch",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}