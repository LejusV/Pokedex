using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Greedent Species to store common natural stats of all Greedents
	#region SpeciesGreedent
	public class SpeciesGreedent : PokemonSpecies
	{
#nullable enable
		private static SpeciesGreedent? _instance = null;
#nullable restore
        public static SpeciesGreedent Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGreedent();
                }
                return _instance;
            }
        }

		#region SpeciesGreedent Constructor
		public SpeciesGreedent() : base(
			"Greedent",
			0.6,
			6.0,
			120, // HPs
			95, 95, // Attack & Defense
			55, 75, // Special Attack & Defense
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

	//Greedent PokemonInstance Class
	#region Greedent
	public class GreedentInstance : PokemonInstance
	{
		#region Greedent Constructors
		/// <summary>
		/// Greedent Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GreedentInstance(string nickname, int level)
		: base(
				820,
				SpeciesGreedent.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Greedent Builder only waiting for a Level
		/// </summary>
		public GreedentInstance(int level)
		: base(
				820,
				SpeciesGreedent.Instance, // PokemonInstance Species
				"Greedent", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Greedent Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Greedent() : base(
			820,
			SpeciesGreedent.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}