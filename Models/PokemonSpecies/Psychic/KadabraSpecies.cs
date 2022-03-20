using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Kadabra Species to store common natural stats of all Kadabras
	#region KadabraSpecies
	public class KadabraSpecies : PokemonSpecies
	{
#nullable enable
		private static KadabraSpecies? _instance = null;
#nullable restore
        public static KadabraSpecies Instance => _instance ?? (_instance = new KadabraSpecies());

		#region KadabraSpecies Constructor
		public KadabraSpecies() : base(
			64,
			"Kadabra",
			Psychic.Instance,
			1.3,
			56.5,
			new PokemonStats(
				40, // HPs
				35, 30, // Attack & Defense
				120, 70, // Spacial Attack & Defense
				105 // Speed
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
				"Energy-Ball",
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