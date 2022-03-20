using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Azumarill PokemonInstance Class
	#region Azumarill
	public class Azumarill : PokemonInstance
	{
		#region Azumarill Constructors
		/// <summary>
		/// Azumarill Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Azumarill(string nickname, int level)
		: base(
				AzumarillSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azumarill Constructor only waiting for a Level
		/// </summary>
		public Azumarill(int level)
		: this( "Azumarill", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azumarill Constructor waiting for no params
		/// </summary>
		/*
		public Azumarill() : this( "Azumarill", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}