using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Vulpix PokemonInstance Class
	#region Vulpix
	public class Vulpix : PokemonInstance
	{
		#region Vulpix Constructors
		/// <summary>
		/// Vulpix Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Vulpix(string nickname, int level)
		: base(
				VulpixSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vulpix Constructor only waiting for a Level
		/// </summary>
		public Vulpix(int level)
		: this( "Vulpix", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vulpix Constructor waiting for no params
		/// </summary>
		/*
		public Vulpix() : this( "Vulpix", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}