using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Meloetta-Aria Species to store common natural stats of all Meloetta-Arias
	#region SpeciesMeloetta-Aria
	public class SpeciesMeloettaAria : PokemonSpecies
	{
#nullable enable
		private static SpeciesMeloettaAria? _instance = null;
#nullable restore
        public static SpeciesMeloettaAria Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMeloettaAria();
                }
                return _instance;
            }
        }

		#region SpeciesMeloetta-Aria Constructor
		public SpeciesMeloettaAria() : base(
			"Meloetta-Aria",
			0.6,
			6.5,
			100, // HPs
			77, 77, // Attack & Defense
			128, 128, // Special Attack & Defense
			90		
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

	//Meloetta-Aria PokemonInstance Class
	#region Meloetta-Aria
	public class MeloettaAriaInstance : PokemonInstance
	{
		#region Meloetta-Aria Constructors
		/// <summary>
		/// Meloetta-Aria Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MeloettaAriaInstance(string nickname, int level)
		: base(
				648,
				SpeciesMeloettaAria.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meloetta-Aria Builder only waiting for a Level
		/// </summary>
		public MeloettaAriaInstance(int level)
		: base(
				648,
				SpeciesMeloettaAria.Instance, // PokemonInstance Species
				"Meloetta-Aria", level,
				Normal.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meloetta-Aria Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MeloettaAria() : base(
			648,
			SpeciesMeloettaAria.Instance, // PokemonInstance Species
			Normal.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}