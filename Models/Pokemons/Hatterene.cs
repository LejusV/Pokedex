using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Hatterene Species to store common natural stats of all Hatterenes
	#region SpeciesHatterene
	public class SpeciesHatterene : PokemonSpecies
	{
#nullable enable
		private static SpeciesHatterene? _instance = null;
#nullable restore
        public static SpeciesHatterene Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHatterene();
                }
                return _instance;
            }
        }

		#region SpeciesHatterene Constructor
		public SpeciesHatterene() : base(
			858,
			"Hatterene",
			2.1,
			5.1,
			57, // HPs
			90, 95, // Attack & Defense
			136, 103, // Special Attack & Defense
			29		
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

	//Hatterene PokemonInstance Class
	#region Hatterene
	public class HattereneInstance : PokemonInstance
	{
		#region Hatterene Constructors
		/// <summary>
		/// Hatterene Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HattereneInstance(string nickname, int level)
		: base(
				SpeciesHatterene.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hatterene Builder only waiting for a Level
		/// </summary>
		public HattereneInstance(int level)
		: base(
				SpeciesHatterene.Instance, // PokemonInstance Species
				"Hatterene", level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hatterene Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HattereneInstance() : base(
			SpeciesHatterene.Instance, // PokemonInstance Species
			Psychic.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}