using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Orbeetle Species to store common natural stats of all Orbeetles
	#region SpeciesOrbeetle
	public class SpeciesOrbeetle : PokemonSpecies
	{
#nullable enable
		private static SpeciesOrbeetle? _instance = null;
#nullable restore
        public static SpeciesOrbeetle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesOrbeetle();
                }
                return _instance;
            }
        }

		#region SpeciesOrbeetle Constructor
		public SpeciesOrbeetle() : base(
			826,
			"Orbeetle",
			0.4,
			40.8,
			60, // HPs
			45, 110, // Attack & Defense
			80, 120, // Special Attack & Defense
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
				
			};
		}
		#endregion
	}
	#endregion

	//Orbeetle PokemonInstance Class
	#region Orbeetle
	public class OrbeetleInstance : PokemonInstance
	{
		#region Orbeetle Constructors
		/// <summary>
		/// Orbeetle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public OrbeetleInstance(string nickname, int level)
		: base(
				SpeciesOrbeetle.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Orbeetle Builder only waiting for a Level
		/// </summary>
		public OrbeetleInstance(int level)
		: base(
				SpeciesOrbeetle.Instance, // PokemonInstance Species
				"Orbeetle", level,
				Bug.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Orbeetle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public OrbeetleInstance() : base(
			SpeciesOrbeetle.Instance, // PokemonInstance Species
			Bug.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}