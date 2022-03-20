using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Meloetta-Aria Species to store common natural stats of all Meloetta-Arias
	#region Meloetta-AriaSpecies
	public class MeloettaAriaSpecies : PokemonSpecies
	{
#nullable enable
		private static MeloettaAriaSpecies? _instance = null;
#nullable restore
        public static MeloettaAriaSpecies Instance => _instance ?? (_instance = new MeloettaAriaSpecies());

		#region Meloetta-AriaSpecies Constructor
		public MeloettaAriaSpecies() : base(
			648,
			"Meloetta-Aria",
			Normal.Instance, Psychic.Instance,
			0.6,
			6.5,
			new PokemonStats(
				100, // HPs
				77, 77, // Attack & Defense
				128, 128, // Spacial Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Sing",
				"Psybeam",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Quick-Attack",
				"Double-Team",
				"Light-Screen",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Perish-Song",
				"Swagger",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Teeter-Dance",
				"Hyper-Voice",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Wake-Up-Slap",
				"U-Turn",
				"Close-Combat",
				"Payback",
				"Embargo",
				"Fling",
				"Last-Resort",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Trick-Room",
				"Stone-Edge",
				"Grass-Knot",
				"Charge-Beam",
				"Hone-Claws",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Acrobatics",
				"Retaliate",
				"Work-Up",
				"Dual-Chop",
				"Relic-Song",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}