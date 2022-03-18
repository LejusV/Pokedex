using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Grapploct Species to store common natural stats of all Grapplocts
	#region SpeciesGrapploct
	public class SpeciesGrapploct : PokemonSpecies
	{
#nullable enable
		private static SpeciesGrapploct? _instance = null;
#nullable restore
        public static SpeciesGrapploct Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGrapploct();
                }
                return _instance;
            }
        }

		#region SpeciesGrapploct Constructor
		public SpeciesGrapploct() : base(
			853,
			"Grapploct",
			1.6,
			39.0,
			80, // HPs
			118, 90, // Attack & Defense
			70, 80, // Special Attack & Defense
			42		
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

	//Grapploct PokemonInstance Class
	#region Grapploct
	public class GrapploctInstance : PokemonInstance
	{
		#region Grapploct Constructors
		/// <summary>
		/// Grapploct Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GrapploctInstance(string nickname, int level)
		: base(
				SpeciesGrapploct.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grapploct Builder only waiting for a Level
		/// </summary>
		public GrapploctInstance(int level)
		: base(
				SpeciesGrapploct.Instance, // PokemonInstance Species
				"Grapploct", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grapploct Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GrapploctInstance() : base(
			SpeciesGrapploct.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}