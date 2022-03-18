using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Slurpuff Species to store common natural stats of all Slurpuffs
	#region SpeciesSlurpuff
	public class SpeciesSlurpuff : PokemonSpecies
	{
#nullable enable
		private static SpeciesSlurpuff? _instance = null;
#nullable restore
        public static SpeciesSlurpuff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSlurpuff();
                }
                return _instance;
            }
        }

		#region SpeciesSlurpuff Constructor
		public SpeciesSlurpuff() : base(
			685,
			"Slurpuff",
			0.8,
			5.0,
			82, // HPs
			80, 86, // Attack & Defense
			85, 75, // Special Attack & Defense
			72		
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
				"Tackle",
				"Flamethrower",
				"Surf",
				"Hyper-Beam",
				"Thunderbolt",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Cotton-Spore",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Facade",
				"Helping-Hand",
				"Wish",
				"Magic-Coat",
				"Endeavor",
				"Secret-Power",
				"Aromatherapy",
				"Fake-Tears",
				"Covet",
				"Calm-Mind",
				"Gastro-Acid",
				"Drain-Punch",
				"Energy-Ball",
				"Giga-Impact",
				"After-You",
				"Round",
				"Cotton-Guard",
				"Draining-Kiss",
				"Play-Rough",
				"Fairy-Wind",
				"Play-Nice",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Slurpuff PokemonInstance Class
	#region Slurpuff
	public class SlurpuffInstance : PokemonInstance
	{
		#region Slurpuff Constructors
		/// <summary>
		/// Slurpuff Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SlurpuffInstance(string nickname, int level)
		: base(
				SpeciesSlurpuff.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slurpuff Builder only waiting for a Level
		/// </summary>
		public SlurpuffInstance(int level)
		: base(
				SpeciesSlurpuff.Instance, // PokemonInstance Species
				"Slurpuff", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slurpuff Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SlurpuffInstance() : base(
			SpeciesSlurpuff.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}