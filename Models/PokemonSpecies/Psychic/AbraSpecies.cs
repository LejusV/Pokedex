using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Abra Species to store common natural stats of all Abras
	#region AbraSpecies
	public class AbraSpecies : PokemonSpecies
	{
#nullable enable
		private static AbraSpecies? _instance = null;
#nullable restore
        public static AbraSpecies Instance => _instance ?? (_instance = new AbraSpecies());

		#region AbraSpecies Constructor
		public AbraSpecies() : base(
			63,
			"Abra",
			Psychic.Instance,
			0.9,
			19.5,
			new PokemonStats(
				25, // HPs
				20, 15, // Attack & Defense
				105, 55, // Spacial Attack & Defense
				90 // Speed
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
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
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
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
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
				"Natural-Gift",
				"Embargo",
				"Fling",
				"Psycho-Shift",
				"Power-Trick",
				"Guard-Swap",
				"Drain-Punch",
				"Energy-Ball",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Guard-Split",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Ally-Switch",
				"Confide",
				"Dazzling-Gleam",
				"Psychic-Terrain"
			};
		}
		#endregion
	}
	#endregion
}