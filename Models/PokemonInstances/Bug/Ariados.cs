using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ariados PokemonInstance Class
	#region Ariados
	public class Ariados : PokemonInstance
	{
		#region Ariados Constructors
		/// <summary>
		/// Ariados Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ariados(string nickname, int level)
		: base(
				AriadosSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ariados Constructor only waiting for a Level
		/// </summary>
		public Ariados(int level)
		: this( "Ariados", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ariados Constructor waiting for no params
		/// </summary>
		/*
		public Ariados() : this( "Ariados", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}