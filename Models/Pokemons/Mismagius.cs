using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mismagius Species to store common natural stats of all Mismagiuss
	#region SpeciesMismagius
	public class SpeciesMismagius : PokemonSpecies
	{
#nullable enable
		private static SpeciesMismagius? _instance = null;
#nullable restore
        public static SpeciesMismagius Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMismagius();
                }
                return _instance;
            }
        }

		#region SpeciesMismagius Constructor
		public SpeciesMismagius() : base(
			429,
			"Mismagius",
			0.9,
			4.4,
			60, // HPs
			60, 60, // Attack & Defense
			105, 105, // Special Attack & Defense
			105		
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
				"Growl",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Magic-Coat",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Aerial-Ace",
				"Magical-Leaf",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Lucky-Chant",
				"Sucker-Punch",
				"Dark-Pulse",
				"Power-Gem",
				"Energy-Ball",
				"Giga-Impact",
				"Trick-Room",
				"Captivate",
				"Charge-Beam",
				"Ominous-Wind",
				"Wonder-Room",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Phantom-Force",
				"Confide",
				"Mystical-Fire",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Mismagius PokemonInstance Class
	#region Mismagius
	public class MismagiusInstance : PokemonInstance
	{
		#region Mismagius Constructors
		/// <summary>
		/// Mismagius Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MismagiusInstance(string nickname, int level)
		: base(
				SpeciesMismagius.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mismagius Builder only waiting for a Level
		/// </summary>
		public MismagiusInstance(int level)
		: base(
				SpeciesMismagius.Instance, // PokemonInstance Species
				"Mismagius", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mismagius Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MismagiusInstance() : base(
			SpeciesMismagius.Instance, // PokemonInstance Species
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}