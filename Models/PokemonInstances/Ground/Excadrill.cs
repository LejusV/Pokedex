using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Excadrill PokemonInstance Class
	#region Excadrill
	public class Excadrill : PokemonInstance
	{
		#region Excadrill Constructors
		/// <summary>
		/// Excadrill Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Excadrill(string nickname, int level)
		: base(
				ExcadrillSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Excadrill Constructor only waiting for a Level
		/// </summary>
		public Excadrill(int level)
		: this( "Excadrill", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Excadrill Constructor waiting for no params
		/// </summary>
		/*
		public Excadrill() : this( "Excadrill", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}