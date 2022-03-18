using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Kubfu Species to store common natural stats of all Kubfus
	#region SpeciesKubfu
	public class SpeciesKubfu : PokemonSpecies
	{
#nullable enable
		private static SpeciesKubfu? _instance = null;
#nullable restore
        public static SpeciesKubfu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKubfu();
                }
                return _instance;
            }
        }

		#region SpeciesKubfu Constructor
		public SpeciesKubfu() : base(
			891,
			"Kubfu",
			0.6,
			12.0,
			60, // HPs
			90, 60, // Attack & Defense
			53, 50, // Special Attack & Defense
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
				
			};
		}
		#endregion
	}
	#endregion

	//Kubfu PokemonInstance Class
	#region Kubfu
	public class KubfuInstance : PokemonInstance
	{
		#region Kubfu Constructors
		/// <summary>
		/// Kubfu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KubfuInstance(string nickname, int level)
		: base(
				SpeciesKubfu.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kubfu Builder only waiting for a Level
		/// </summary>
		public KubfuInstance(int level)
		: base(
				SpeciesKubfu.Instance, // PokemonInstance Species
				"Kubfu", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kubfu Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KubfuInstance() : base(
			SpeciesKubfu.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}