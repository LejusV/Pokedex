using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Azurill PokemonInstance Class
	#region Azurill
	public class Azurill : PokemonInstance
	{
		#region Azurill Constructors
		/// <summary>
		/// Azurill Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Azurill(string nickname, int level)
		: base(
				AzurillSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azurill Constructor only waiting for a Level
		/// </summary>
		public Azurill(int level)
		: this( "Azurill", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azurill Constructor waiting for no params
		/// </summary>
		/*
		public Azurill() : this( "Azurill", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}