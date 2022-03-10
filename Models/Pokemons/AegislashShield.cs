using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Aegislash-Shield Species to store common natural stats of all Aegislash-Shields
	#region SpeciesAegislash-Shield
	public class SpeciesAegislashShield : PokemonSpecies
	{
#nullable enable
		private static SpeciesAegislashShield? _instance = null;
#nullable restore
        public static SpeciesAegislashShield Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAegislashShield();
                }
                return _instance;
            }
        }

		#region SpeciesAegislash-Shield Constructor
		public SpeciesAegislashShield() : base(
			"Aegislash-Shield",
			1.7,
			53.0,
			60, // HPs
			50, 140, // Attack & Defense
			50, 140, // Special Attack & Defense
			60		
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
				"Swords-Dance",
				"Cut",
				"Hyper-Beam",
				"Toxic",
				"Double-Team",
				"Reflect",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Shock-Wave",
				"Gyro-Ball",
				"Power-Trick",
				"Magnet-Rise",
				"Night-Slash",
				"Giga-Impact",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Flash-Cannon",
				"Iron-Head",
				"Head-Smash",
				"Autotomize",
				"After-You",
				"Round",
				"Retaliate",
				"Sacred-Sword",
				"Kings-Shield",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Aegislash-Shield PokemonInstance Class
	#region Aegislash-Shield
	public class AegislashShieldInstance : PokemonInstance
	{
		#region Aegislash-Shield Constructors
		/// <summary>
		/// Aegislash-Shield Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AegislashShieldInstance(string nickname, int level)
		: base(
				681,
				SpeciesAegislashShield.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aegislash-Shield Builder only waiting for a Level
		/// </summary>
		public AegislashShieldInstance(int level)
		: base(
				681,
				SpeciesAegislashShield.Instance, // PokemonInstance Species
				"Aegislash-Shield", level,
				Steel.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aegislash-Shield Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public AegislashShield() : base(
			681,
			SpeciesAegislashShield.Instance, // PokemonInstance Species
			Steel.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}