using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Blipbug Species to store common natural stats of all Blipbugs
	#region SpeciesBlipbug
	public class SpeciesBlipbug : PokemonSpecies
	{
#nullable enable
		private static SpeciesBlipbug? _instance = null;
#nullable restore
        public static SpeciesBlipbug Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBlipbug();
                }
                return _instance;
            }
        }

		#region SpeciesBlipbug Constructor
		public SpeciesBlipbug() : base(
			824,
			"Blipbug",
			0.4,
			8.0,
			25, // HPs
			20, 20, // Attack & Defense
			25, 45, // Special Attack & Defense
			45		
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

	//Blipbug PokemonInstance Class
	#region Blipbug
	public class BlipbugInstance : PokemonInstance
	{
		#region Blipbug Constructors
		/// <summary>
		/// Blipbug Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BlipbugInstance(string nickname, int level)
		: base(
				SpeciesBlipbug.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blipbug Builder only waiting for a Level
		/// </summary>
		public BlipbugInstance(int level)
		: base(
				SpeciesBlipbug.Instance, // PokemonInstance Species
				"Blipbug", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blipbug Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BlipbugInstance() : base(
			SpeciesBlipbug.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}