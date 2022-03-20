using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Beedrill PokemonInstance Class
	#region Beedrill
	public class Beedrill : PokemonInstance
	{
		#region Beedrill Constructors
		/// <summary>
		/// Beedrill Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Beedrill(string nickname, int level)
		: base(
				BeedrillSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beedrill Constructor only waiting for a Level
		/// </summary>
		public Beedrill(int level)
		: this( "Beedrill", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beedrill Constructor waiting for no params
		/// </summary>
		/*
		public Beedrill() : this( "Beedrill", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}