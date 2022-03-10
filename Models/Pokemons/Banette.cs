using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Banette Species to store common natural stats of all Banettes
	#region SpeciesBanette
	public class SpeciesBanette : PokemonSpecies
	{
#nullable enable
		private static SpeciesBanette? _instance = null;
#nullable restore
        public static SpeciesBanette Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBanette();
                }
                return _instance;
            }
        }

		#region SpeciesBanette Constructor
		public SpeciesBanette() : base(
			"Banette",
			1.1,
			12.5,
			64, // HPs
			115, 65, // Attack & Defense
			83, 63, // Special Attack & Defense
			65		
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Mimic",
				"Screech",
				"Double-Team",
				"Metronome",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Knock-Off",
				"Skill-Swap",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Dark-Pulse",
				"Giga-Impact",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Trick-Room",
				"Captivate",
				"Charge-Beam",
				"Ominous-Wind",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Hex",
				"Phantom-Force",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Banette PokemonInstance Class
	#region Banette
	public class BanetteInstance : PokemonInstance
	{
		#region Banette Constructors
		/// <summary>
		/// Banette Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BanetteInstance(string nickname, int level)
		: base(
				354,
				SpeciesBanette.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Banette Builder only waiting for a Level
		/// </summary>
		public BanetteInstance(int level)
		: base(
				354,
				SpeciesBanette.Instance, // PokemonInstance Species
				"Banette", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Banette Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Banette() : base(
			354,
			SpeciesBanette.Instance, // PokemonInstance Species
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}