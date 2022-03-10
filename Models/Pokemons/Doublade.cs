using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Doublade Species to store common natural stats of all Doublades
	#region SpeciesDoublade
	public class SpeciesDoublade : PokemonSpecies
	{
#nullable enable
		private static SpeciesDoublade? _instance = null;
#nullable restore
        public static SpeciesDoublade Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDoublade();
                }
                return _instance;
            }
        }

		#region SpeciesDoublade Constructor
		public SpeciesDoublade() : base(
			"Doublade",
			0.8,
			4.5,
			59, // HPs
			110, 150, // Attack & Defense
			45, 49, // Special Attack & Defense
			35		
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
				"Tackle",
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
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Shock-Wave",
				"Gyro-Ball",
				"Power-Trick",
				"Magnet-Rise",
				"Night-Slash",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Flash-Cannon",
				"Iron-Head",
				"Autotomize",
				"After-You",
				"Retaliate",
				"Sacred-Sword",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Doublade PokemonInstance Class
	#region Doublade
	public class DoubladeInstance : PokemonInstance
	{
		#region Doublade Constructors
		/// <summary>
		/// Doublade Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DoubladeInstance(string nickname, int level)
		: base(
				680,
				SpeciesDoublade.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Doublade Builder only waiting for a Level
		/// </summary>
		public DoubladeInstance(int level)
		: base(
				680,
				SpeciesDoublade.Instance, // PokemonInstance Species
				"Doublade", level,
				Steel.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Doublade Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Doublade() : base(
			680,
			SpeciesDoublade.Instance, // PokemonInstance Species
			Steel.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}