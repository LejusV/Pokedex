using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Weepinbell PokemonInstance Class
	#region Weepinbell
	public class Weepinbell : PokemonInstance
	{
		#region Weepinbell Constructors
		/// <summary>
		/// Weepinbell Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Weepinbell(string nickname, int level)
		: base(
				WeepinbellSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weepinbell Constructor only waiting for a Level
		/// </summary>
		public Weepinbell(int level)
		: this( "Weepinbell", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weepinbell Constructor waiting for no params
		/// </summary>
		/*
		public Weepinbell() : this( "Weepinbell", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}