using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Appletun Species to store common natural stats of all Appletuns
	#region SpeciesAppletun
	public class SpeciesAppletun : PokemonSpecies
	{
#nullable enable
		private static SpeciesAppletun? _instance = null;
#nullable restore
        public static SpeciesAppletun Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAppletun();
                }
                return _instance;
            }
        }

		#region SpeciesAppletun Constructor
		public SpeciesAppletun() : base(
			842,
			"Appletun",
			0.4,
			13.0,
			110, // HPs
			85, 80, // Attack & Defense
			100, 80, // Special Attack & Defense
			30		
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

	//Appletun PokemonInstance Class
	#region Appletun
	public class AppletunInstance : PokemonInstance
	{
		#region Appletun Constructors
		/// <summary>
		/// Appletun Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AppletunInstance(string nickname, int level)
		: base(
				SpeciesAppletun.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Appletun Builder only waiting for a Level
		/// </summary>
		public AppletunInstance(int level)
		: base(
				SpeciesAppletun.Instance, // PokemonInstance Species
				"Appletun", level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Appletun Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public AppletunInstance() : base(
			SpeciesAppletun.Instance, // PokemonInstance Species
			Grass.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}