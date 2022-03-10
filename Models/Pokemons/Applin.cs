using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Applin Species to store common natural stats of all Applins
	#region SpeciesApplin
	public class SpeciesApplin : PokemonSpecies
	{
#nullable enable
		private static SpeciesApplin? _instance = null;
#nullable restore
        public static SpeciesApplin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesApplin();
                }
                return _instance;
            }
        }

		#region SpeciesApplin Constructor
		public SpeciesApplin() : base(
			"Applin",
			0.2,
			0.5,
			40, // HPs
			40, 80, // Attack & Defense
			40, 40, // Special Attack & Defense
			20		
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

	//Applin PokemonInstance Class
	#region Applin
	public class ApplinInstance : PokemonInstance
	{
		#region Applin Constructors
		/// <summary>
		/// Applin Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ApplinInstance(string nickname, int level)
		: base(
				840,
				SpeciesApplin.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Applin Builder only waiting for a Level
		/// </summary>
		public ApplinInstance(int level)
		: base(
				840,
				SpeciesApplin.Instance, // PokemonInstance Species
				"Applin", level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Applin Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Applin() : base(
			840,
			SpeciesApplin.Instance, // PokemonInstance Species
			Grass.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}